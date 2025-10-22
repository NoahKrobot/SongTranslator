using SongTranslator.Services;

namespace SongTranslator.Components.Data
{
    public interface IMediaFetchService
    {
        bool ValidateInput(string artist, string song);
        List<MediaData> SortListAscending(List<MediaData> fetchedLyricsVideo);
        List<MediaData> SortListDescending(List<MediaData> fetchedLyricsVideo);
    }
}
