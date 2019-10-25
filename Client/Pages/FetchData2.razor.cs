using System;
using System.Net.Http;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;

namespace MusicLibrary.Client.Pages
{
	public class FetchData2Base : ComponentBase
	{
		[Inject]
		protected HttpClient? HttpClient { get; set; }

		protected bool isLoaded = false;
		protected Guid guid = Guid.NewGuid();

		protected async Task GetGuid()
		{
			if (HttpClient == null) return;

			guid = await HttpClient.GetJsonAsync<Guid>("Test");
			isLoaded = true;
		}
	}
}
