using Newtonsoft.Json;

namespace SongTranslator.Components.Data
{
    public class SupportedLanguages
    {
        /// <summary>
        /// The code of the language
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }
        /// <summary>
        /// The english based language name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
