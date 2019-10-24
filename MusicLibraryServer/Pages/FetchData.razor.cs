using System.Collections.Generic;
//using System.Net.Http;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;

using MusicLibraryServer.Services;
using MusicLibraryServer.Shared;

namespace MusicLibraryServer.Pages
{
	public class FetchDataBase : ComponentBase
	{
		//[Inject]
		//protected HttpClient? HttpClient { get; set; }
		[Inject]
		protected IAlbumService? AlbumService { get; set; }

		protected IReadOnlyCollection<AlbumDto> albumDtos = new List<AlbumDto>();

		protected override async Task OnInitializedAsync()
		{
			if (AlbumService == null) return;

			//albumDtos = await HttpClient.GetJsonAsync<AlbumDto[]>("Album");
			albumDtos = await AlbumService.GetAllAsync();
		}
	}
}
