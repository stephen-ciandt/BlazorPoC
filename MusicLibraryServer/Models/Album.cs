using System.ComponentModel.DataAnnotations;

namespace MusicLibraryServer.Models
{
	public class Album
	{
		[Required]
		public int Id { get; set; }

		[Required]
		public bool IsMono { get; set; }
		[Required]
		public bool Is45rpm { get; set; }

		[Required]
		public byte Rating { get; set; }

		[Required]
		public short Year { get; set; }
		[Required]
		public short Number { get; set; }
		[Required]
		public short ReleaseYear { get; set; }

		[Required]
		public string Label { get; set; } = string.Empty;
		[Required]
		public string Notes { get; set; } = string.Empty;
		[Required]
		public string Title { get; set; } = string.Empty;
		[Required]
		public string Artist { get; set; } = string.Empty;
		[Required]
		public string Artists { get; set; } = string.Empty;
		[Required]
		public string Engineer { get; set; } = string.Empty;
	}
}
