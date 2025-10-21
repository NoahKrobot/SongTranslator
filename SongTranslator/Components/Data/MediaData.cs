using static SongTranslator.Components.Data.MediaSourceEnum;

namespace SongTranslator.Components.Data
{

    //abstraction used for Firebase
    public abstract class MediaData
    {
        public MediaSourceEnum Source { get; set; }
        public string Title { get; set; }
    }

    //public class MediaData
    //{
    //    public string Thumbnail { get; set; }
    //    public string Title { get; set; }
    //    public string VideoId { get; set; }
    //}

    public class YouTubeVideo : MediaData
    {
        public string Thumbnail { get; set; }
        public string VideoId { get; set; }
        public string Url => $"https://www.youtube.com/watch?v={VideoId}";
    }

    public class SongLyrics : MediaData
    {
        public string Artist { get; set; }
        public string SongName { get; set; }
        public string Lyrics { get; set; }

    }
}
