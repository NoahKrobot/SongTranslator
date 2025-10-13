using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using SongTranslator.Components.Data;

namespace SongTranslator.Services
{
    public class TranslationService
    {

        static readonly string Translation_API_URL = "https://api.lyrics.ovh/v1/";
        static readonly string languagesData = "Services/languages.json";
        public async Task<List<LanguagesData>> GetLanguagesToList()
        {

            string languageJson = await File.ReadAllTextAsync(languagesData);

            if (languageJson == null)
            {
                return new List<LanguagesData>();
            }

            var languageData = JsonConvert.DeserializeObject<List<LanguagesData>>(languageJson);

            if (languageData == null)
            {
                return new List<LanguagesData>();

            }
            
            return languageData;
        }


    }

  
}
