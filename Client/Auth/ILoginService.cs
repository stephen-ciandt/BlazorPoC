using System.Threading.Tasks;

namespace MusicLibrary.Client.Auth
{
	public interface ILoginService
	{
		Task Login(string token);
		Task Logout();
	}
}
