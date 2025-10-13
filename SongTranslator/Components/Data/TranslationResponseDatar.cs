namespace SongTranslator.Components.Data
{
    public class TranslationResponseDatar
    {

        public long Alternatives { get; set; }
        public string[] Detectedlanguage { get; set; }
        public long TranslatedText { get; set; }


        public TranslationResponseDatar(long alternatives, string[] detectedLangArray, long text)
        {
            Alternatives = alternatives;
            Detectedlanguage = detectedLangArray;
            TranslatedText = text;
        }
    }
}
