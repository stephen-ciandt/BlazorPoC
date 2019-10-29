using System.Net.Http;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;

using MusicLibrary.Client.Auth;
using MusicLibrary.Shared.Models;

namespace MusicLibrary.Client.Pages.Auth
{
	public class LoginBase : ComponentBase
	{
		protected UserInfo userInfo = new UserInfo();

		[Inject]
		protected HttpClient? HttpClient { get; set; }
		[Inject]
		protected ILoginService? LoginService { get; set; }
		[Inject]
		protected NavigationManager? NavigationManager { get; set; }

		protected async Task LoginUser()
		{
			if (HttpClient == null ||
				LoginService == null ||
				NavigationManager == null)
			{
				return;
			}

			var result = await HttpClient.PostJsonAsync<UserToken>("api/accounts/login", userInfo);

			if (result != null)
			{
				await LoginService.Login(result.Token ?? string.Empty);
				NavigationManager.NavigateTo("");
			}
		}
	}
}
