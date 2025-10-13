using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace SongTranslator.Services
{
    public class Translatelyrics
    {

        static readonly string languagesData = "languages.json";
        public async Task<List<Language>> GetLanguagesToList()
        {

            string languageJson = await File.ReadAllTextAsync(languagesData);

            if (languageJson == null)
            {
                return new List<Language>();
            }

            var languageData = JsonConvert.DeserializeObject<List<Language>>(languageJson);

            if (languageData == null)
            {
                return new List<Language>();

            }
            
            return languageData;
        }
    }

    public class Language
    {
        public string ?Code { get; set; }
        public string ?Name { get; set; }
    }
}
