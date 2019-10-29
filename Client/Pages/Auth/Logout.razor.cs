using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;

using MusicLibrary.Client.Auth;
using MusicLibrary.Shared.Models;

namespace MusicLibrary.Client.Pages.Auth
{
	public class LogoutBase : ComponentBase
	{
		protected UserInfo userInfo = new UserInfo();

		[Inject]
		protected ILoginService? LoginService { get; set; }
		[Inject]
		protected NavigationManager? NavigationManager { get; set; }

		protected async override Task OnInitializedAsync()
		{
			if (LoginService == null ||
				NavigationManager == null)
			{
				return;
			}

			await LoginService.Logout();
			NavigationManager.NavigateTo("");
		}
	}
}
