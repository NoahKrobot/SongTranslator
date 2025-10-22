using Google.Apis.YouTube.v3;
using SongTranslator.Services;
using SongTranslator.Components.Data;

namespace SongTranslator.Components.Data
{
    public class MediaFetchServices : IMediaFetchService
    {
        public List<MediaData> SortListAscending(List<MediaData> fetchedLyricsVideo)
        {

            fetchedLyricsVideo = fetchedLyricsVideo.OrderBy(m => m.Title ?? string.Empty).ToList();

            return fetchedLyricsVideo;
        }

        public List<MediaData> SortListDescending(List<MediaData> fetchedLyricsVideo)
        {
            fetchedLyricsVideo = fetchedLyricsVideo.OrderByDescending(m => m.Title ?? string.Empty).ToList();

            return fetchedLyricsVideo;
        }

        public bool ValidateInput(string artist, string song)
        {
            if (string.IsNullOrEmpty(artist) || string.IsNullOrEmpty(song)
                ||
                string.IsNullOrWhiteSpace(artist)
                ||
                string.IsNullOrWhiteSpace(song)
                )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
