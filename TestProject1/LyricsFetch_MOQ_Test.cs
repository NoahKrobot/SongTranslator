using Moq;
using RestSharp;
using SongTranslator.Services;

namespace TestProject1;

public class LyricsFetch_MOQ_Test
{
    private Mock<IRestClient> _mockClient = null!;
    private FetchLyricsService _service = null!;

    [SetUp]
    public void Setup()
    {
        _mockClient = new Mock<IRestClient>();
        _service = new FetchLyricsService(_mockClient.Object);
    }

    [Test]
    public async Task LyricsTextAsync_ReturnsLyrics_WhenValid()
    {
        // Arrange
        var fakeResponse = new RestResponse
        {
            Content = "{\"lyrics\": \"I did my time, and I want out\"}"
        };

        _mockClient
            .Setup(c => c.ExecuteAsync(It.IsAny<RestRequest>(), default))
            .ReturnsAsync(fakeResponse);

        // Act
        var result = await _service.LyricsTextAsync("Slipknot", "Psychosocial");

        // Assert
        Assert.That(result, Is.EqualTo("I did my time, and I want out"));
    }
}
