using SongTranslator.Services;

namespace SongTranslator.Components.Data
{
    public interface IMediaFetchService
    {
        bool ValidateInput(string artist, string song);
       
    }
}
