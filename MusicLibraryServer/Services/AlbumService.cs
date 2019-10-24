using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MusicLibraryServer.Models;
using MusicLibraryServer.Shared;

namespace MusicLibraryServer.Services
{
	public class AlbumService : IAlbumService
	{
		private readonly IAlbumRepository albumRepository;

		public AlbumService(IAlbumRepository albumRepository)
		{
			this.albumRepository = albumRepository;
		}

		public Task<IReadOnlyCollection<AlbumDto>> GetAllAsync()
		{
			var albums = albumRepository.GetAll();
			var albumDtos = TranslateAlbumsToAlbumDtos(albums);
			return Task.FromResult(albumDtos);
		}

		private IReadOnlyCollection<AlbumDto> TranslateAlbumsToAlbumDtos(IReadOnlyCollection<Album> albums)
		{
			var albumDtos = albums.Select(album => new AlbumDto
			{
				Id = album.Id,
				IsMono = album.IsMono,
				Is45rpm = album.Is45rpm,

				Rating = album.Rating,

				Year = album.Year,
				Number = album.Number,
				ReleaseYear = album.ReleaseYear,

				Label = album.Label ?? string.Empty,
				Notes = album.Notes ?? string.Empty,
				Title = album.Title ?? string.Empty,
				Artist = album.Artist ?? string.Empty,
				Artists = album.Artists ?? string.Empty,
				Engineer = album.Engineer ?? string.Empty
			}).ToList();

			return albumDtos.AsReadOnly();
		}
	}
}
