using System.Threading.Tasks;

using Microsoft.JSInterop;

namespace MusicLibrary.Client.Helpers
{
	public static class IJSRuntimeExtensions
	{
		public static ValueTask SetInLocalStorage(this IJSRuntime js, string key, string content)
			=> js.InvokeVoidAsync("localStorage.setItem", key, content);

		public static ValueTask<string> GetFromLocalStorage(this IJSRuntime js, string key)
			=> js.InvokeAsync<string>("localStorage.getItem", key);

		public static ValueTask RemoveItem(this IJSRuntime js, string key)
			=> js.InvokeVoidAsync("localStorage.removeItem", key);

	}
}
