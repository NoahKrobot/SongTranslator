using RestSharp;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;
using System;

namespace SongTranslator.Services
{
    public class FetchLyricsService : IFetchLyricsService
    {
        //static readonly string Lyrics_URL = "https://api.lyrics.ovh/v1/";

        private readonly IRestClient _client;

        public FetchLyricsService(IRestClient client)
        {
            _client = client;
        }


        public async Task<string> LyricsTextAsync(string artist, string title)
        {
            //var client = new RestClient(Lyrics_URL);
            var request = new RestRequest($"{artist}/{title}");

                var responseLyrics = await _client.ExecuteAsync(request);

                if (responseLyrics.Content == null)
                {
                    return "Response is null";
                }

                var data = JsonConvert.DeserializeObject<Lyric>(responseLyrics.Content);


                if (data == null || data.lyrics == null)
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

    public interface IFetchLyricsService
    {
        Task<string> LyricsTextAsync(string artist, string title);
    }
}
