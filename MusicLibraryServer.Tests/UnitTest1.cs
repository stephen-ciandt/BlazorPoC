using Xunit;

namespace MusicLibraryServer.Tests
{
	public class UnitTest1
	{
		[Fact]
		public void shouldDoSomething()
		{
			// Arrange
			var fullName = "Stephen Cousins";

			// Act
			var surname = fullName.Split(' ')[1];

			// Assert
			Assert.Equal("Cousins", surname);
		}
	}
}
