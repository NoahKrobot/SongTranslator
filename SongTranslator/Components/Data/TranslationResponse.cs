using Newtonsoft.Json;

namespace SongTranslator.Components.Data
{
    public class TranslationResponse
    {
        /// <summary>
        /// The translated text
        /// </summary>
        [JsonProperty("translatedText")]
        public string TranslatedText { get; set; }
    }
}
