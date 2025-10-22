using Google.Apis.YouTube.v3;
using SongTranslator.Services;
using SongTranslator.Components.Data;

namespace SongTranslator.Components.Data
{

    public class MediaFetchServices : IMediaFetchService
    {

        public bool ValidateInput(string artist, string song)
        {
            if (string.IsNullOrEmpty(artist) || string.IsNullOrEmpty(song))
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
