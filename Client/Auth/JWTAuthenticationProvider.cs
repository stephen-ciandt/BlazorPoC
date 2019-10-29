using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;

using MusicLibrary.Client.Helpers;

namespace MusicLibrary.Client.Auth
{
	public class JWTAuthenticationProvider : AuthenticationStateProvider, ILoginService
	{
		private static readonly string TOKEN_KEY = "TOKENKEY";

		private readonly IJSRuntime js;
		private readonly HttpClient httpClient;

		private AuthenticationState Anonymous =>
			new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));

		public JWTAuthenticationProvider(IJSRuntime js, HttpClient httpClient)
		{
			this.js = js;
			this.httpClient = httpClient;
		}

		public async override Task<AuthenticationState> GetAuthenticationStateAsync()
		{
			var token = await js.GetFromLocalStorage(TOKEN_KEY);

			if (string.IsNullOrEmpty(token))
			{
				return Anonymous;
			}

			return BuildAuthenticationState(token);
		}

		public async Task Login(string token)
		{
			await js.SetInLocalStorage(TOKEN_KEY, token);
			var authState = BuildAuthenticationState(token);
			NotifyAuthenticationStateChanged(Task.FromResult(authState));
		}

		public async Task Logout()
		{
			httpClient.DefaultRequestHeaders.Authorization = null;
			await js.RemoveItem(TOKEN_KEY);
			NotifyAuthenticationStateChanged(Task.FromResult(Anonymous));
		}

		private AuthenticationState BuildAuthenticationState(string token)
		{
			httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);
			return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity(ParseClaimsFromJwt(token), "jwt")));
		}

		/// <summary>
		/// Should be part of Blazor in the future
		/// </summary>
		/// <param name="jwt"></param>
		/// <returns></returns>
		private IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
		{
			var claims = new List<Claim>();
			var payload = jwt.Split('.')[1];
			var jsonBytes = ParseBase64WithoutPadding(payload);
			var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);

			keyValuePairs.TryGetValue(ClaimTypes.Role, out object roles);

			if (roles != null)
			{
				if (roles.ToString().Trim().StartsWith("["))
				{
					var parsedRoles = JsonSerializer.Deserialize<string[]>(roles.ToString());

					foreach(var parsedRole in parsedRoles)
					{
						claims.Add(new Claim(ClaimTypes.Role, parsedRole));
					}
				}
				else
				{
					claims.Add(new Claim(ClaimTypes.Role, roles.ToString()));
				}
				keyValuePairs.Remove(ClaimTypes.Role);
			}
			claims.AddRange(keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString())));
			return claims;
		}

		/// <summary>
		/// Should be part of Blazor in the future
		/// </summary>
		/// <param name="base64"></param>
		/// <returns></returns>
		private byte[] ParseBase64WithoutPadding(string base64)
		{
			switch (base64.Length % 4)
			{
				case 2:
					base64 += "==";
					break;
				case 3:
					base64 += "=";
					break;
			}
			return Convert.FromBase64String(base64);
		}
	}
}
