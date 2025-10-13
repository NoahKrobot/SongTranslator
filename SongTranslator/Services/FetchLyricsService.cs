using RestSharp;
using System.Threading.Tasks;

namespace SongTranslator.Services
{
    public class FetchLyricsService
    {
        static readonly string Lyrics_URL = "https://api.lyrics.ovh/v1/";

        public async Task<string> LyricsTextAsync(string artist, string title)
        {
            var client = new RestClient(Lyrics_URL);
            var request = new RestRequest($"{artist}/{title}");

            var response = await client.ExecuteAsync(request);

            if (response.Content == null)
            {
                return "Response is null";
            }

            return response.Content;
        }
    }
}
