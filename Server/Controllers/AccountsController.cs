using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

using MusicLibrary.Shared.Models;

namespace MusicLibrary.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountsController : ControllerBase
	{
		private readonly UserManager<IdentityUser>? _userManager;
		private readonly SignInManager<IdentityUser>? _signInManager;
		private readonly IConfiguration? _configuration;

		public AccountsController(
			UserManager<IdentityUser> userManager,
			SignInManager<IdentityUser> signInManager,
			IConfiguration configuration)
		{
			_userManager = userManager;
			_signInManager = signInManager;
			_configuration = configuration;
		}

		[HttpPost("Create")]
		public async Task<ActionResult<UserToken>> CreateUser([FromBody] UserInfo userInfo)
		{
			var user = new IdentityUser { UserName = userInfo.Email, Email = userInfo.Email };
			var result = await _userManager.CreateAsync(user, userInfo.Password);

			if (!result.Succeeded)
			{
				return BadRequest("The username or password is invalid.");
			}
			return BuildToken(userInfo);
		}

		[HttpPost("Login")]	
		public async Task<ActionResult<UserToken>> Login([FromBody] UserInfo userInfo)
		{
			var result = await _signInManager.PasswordSignInAsync(userInfo.Email, userInfo.Password,
				isPersistent: false, lockoutOnFailure: false);

			if (!result.Succeeded)
			{
				ModelState.AddModelError(string.Empty, "Invalid login attempt.");
				return BadRequest(ModelState);
			}
			return BuildToken(userInfo);
		}

		private UserToken BuildToken(UserInfo userInfo)
		{
			var claims = new[]
			{
				new Claim(JwtRegisteredClaimNames.UniqueName, userInfo.Email),
				new Claim(ClaimTypes.Name, userInfo.Email),
				new Claim("myValue", "whatever I want"),
				new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
			};

			var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:key"]));
			var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

			var expiration = DateTime.UtcNow.AddYears(1);

			var token = new JwtSecurityToken(
				issuer: null,
				audience: null,
				claims: claims,
				expires: expiration,
				signingCredentials: credentials);

			return new UserToken
			{
				Token = new JwtSecurityTokenHandler().WriteToken(token),
				Expiration = expiration
			};
		}
	}
}
