namespace SongTranslator.Components.Data
{
    public class LanguagesData
    {
        public string? Code { get; set; }
        public string? Name { get; set; }

        public LanguagesData() {}

        public LanguagesData(string code, string name)
        {
            Code = code;
            Name = name;
        }
    }
}
