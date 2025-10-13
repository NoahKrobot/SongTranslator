using RestSharp;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;
using System;

namespace SongTranslator.Services
{
    public class FetchLyricsService
    {
        static readonly string Lyrics_URL = "https://api.lyrics.ovh/v1/";

        public async Task<string> LyricsTextAsync(string artist, string title)
        {
            var client = new RestClient(Lyrics_URL);
            var request = new RestRequest($"{artist}/{title}");

            var responseLyrics = await client.ExecuteAsync(request);

            if (responseLyrics.Content == null)
            {
                return "Response is null";
            }

            var data = JsonConvert.DeserializeObject<Lyric>(responseLyrics.Content);


            if (data == null)
            {
                return "Response is null";
            }

            if (data.lyrics == null)
            {
                return "Response is null";
            }

            return data.lyrics;
        }
    }
    public class Lyric
    {
        [JsonProperty("lyrics")]
        public string ?lyrics { get; set; }
    }
}
