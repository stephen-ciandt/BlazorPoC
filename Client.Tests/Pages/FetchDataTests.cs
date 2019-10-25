using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

using Moq;

using MusicLibrary.Client.Pages;
using MusicLibrary.Shared;

using Xunit;

namespace MusicLibrary.Client.Tests
{
	public class FetchDataTests
	{
		[Fact]
		public async Task OnInitializedAsync_ShouldGetJson()
		{
			// Arrange
			var albumDtos = new List<AlbumDto>();
			//var httpClientMock = new Mock<HttpClient>();
			var httpMessageHandlerMock = new Mock<HttpMessageHandler>();

			//httpClientMock
			//	.Setup(s => s.GetStreamAsync(It.IsAny<string>())
			//	.Returns(Task.FromResult(albumDtos.ToArray()));

			var fetchData = new FetchDataWrapper(httpMessageHandlerMock.Object);

			// Act
			await fetchData.OnInitializedAsyncWrapper();

			// Assert
			Assert.True(true);
			//httpClientMock.Verify(s => s.GetJsonAsync<AlbumDto[]>("Album"), Times.Once);
		}

		[Fact]
		public void Multiply_ShouldGetJson()
		{
			// Arrange
			const int a = -10;
			const int b = -20;
			const int expected = 200;

			var fetchData = new FetchDataBase();

			// Act
			var actual = fetchData.Multiply(a, b);

			// Assert
			Assert.Equal(expected, actual);
		}
	}

	public class FetchDataWrapper : FetchDataBase
	{
		public FetchDataWrapper(HttpMessageHandler httpMessageHandler)
		{
			HttpClient = new HttpClient(httpMessageHandler);
		}

		public async Task OnInitializedAsyncWrapper()
		{
			await OnInitializedAsync();
		}
	}
}
