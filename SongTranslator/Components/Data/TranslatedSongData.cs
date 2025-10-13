namespace SongTranslator.Components.Data
{
    public class TranslatedSongData
    {
        public string SongName { get; set; }
        public string ArtistName { get; set; }
        public long OriginalLyrics { get; set; }
        public long TranslatedLyrics { get; set; }

        public TranslatedSongData(string songName, string artistName, long original, long translated)
        {
            SongName = songName;
            ArtistName = artistName;
            OriginalLyrics = original;
            TranslatedLyrics = translated;
        }
    }
}
