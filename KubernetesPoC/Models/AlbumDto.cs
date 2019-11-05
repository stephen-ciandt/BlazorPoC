namespace KubernetesPoC.Models
{
	public class AlbumDto
	{
		public int Id { get; set; }

		public bool IsMono { get; set; }
		public bool Is45rpm { get; set; }

		public byte Rating { get; set; }

		public short Year { get; set; }
		public short Number { get; set; }
		public short ReleaseYear { get; set; }

		public string Label { get; set; } = string.Empty;
		public string Notes { get; set; } = string.Empty;
		public string Title { get; set; } = string.Empty;
		public string Artist { get; set; } = string.Empty;
		public string Artists { get; set; } = string.Empty;
		public string Engineer { get; set; } = string.Empty;
	}
}
