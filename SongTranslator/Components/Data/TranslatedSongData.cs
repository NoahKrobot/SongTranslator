namespace SongTranslator.Components.Data
{
    public class TranslatedSongData
    {
        public string SongName { get; set; }
        public long OriginalLyrics { get; set; }
        public long TranslatedLyrics { get; set; }

        public TranslatedSongData(string name, long original, long translated)
        {
            SongName = name;
            OriginalLyrics = original;
            TranslatedLyrics = translated;
        }
    }
}
