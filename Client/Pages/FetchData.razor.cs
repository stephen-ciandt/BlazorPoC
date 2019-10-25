using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;

using MusicLibrary.Shared;

namespace MusicLibrary.Client.Pages
{
	public class FetchDataBase : ComponentBase
	{
		[Inject]
		protected HttpClient? HttpClient { get; set; }

		protected bool isLoaded = false;
		protected IReadOnlyCollection<AlbumDto> albumDtos = new List<AlbumDto>();

		protected override async Task OnInitializedAsync()
		{
			if (HttpClient == null) return;

			albumDtos = await HttpClient.GetJsonAsync<AlbumDto[]>("Album");
			isLoaded = true;
		}

		public int Multiply(int a, int b)
		{
			return Math.Abs(a) * Math.Abs(b);
		}
	}
}
