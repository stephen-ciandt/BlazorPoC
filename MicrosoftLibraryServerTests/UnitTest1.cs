using Xunit;

namespace MicrosoftLibraryServerTests
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
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
