using SongTranslator.Components.Data;

namespace TestProject1
{
    public class SortList_Descending_Test
    {
        private MediaFetchServices? mediaService;

        [SetUp]
        public void Setup()
        {
            mediaService = new MediaFetchServices();
        }

        /*
          * TEST CASES:
          * 
          * 1: Three words: "Crawling", "Betrayer", "Duality" -> returns:  Duality,  Crawling, Betrayer,
          * 2: Different caps three words: "Crawling", "duality", "betrayer"  -> returns  Duality,  Crawling, Betrayer,
          * 3: Empty list -> returns empty
          * 4: Null list -> returns empty or same null-safe list
          * 5: Duplicates: Betrayer, Broken Cog, Betrayer,  -> return Broken Cog, Betrayer, Betrayer, 
        */

        [Test]
        public void ThreeWords_ExpectedAlphabeticalOrder()
        {
            List<MediaData> songs = new List<MediaData>();
            YouTubeVideo y1 = new YouTubeVideo { Title = "Betrayer" };
            YouTubeVideo y2 = new YouTubeVideo { Title = "Crawling" };
            YouTubeVideo y3 = new YouTubeVideo { Title = "Duality" };
            songs.Add(y1);
            songs.Add(y2);
            songs.Add(y3);

            var sorted = mediaService.SortListDescending(songs);

            Assert.That(sorted[2].Title, Is.EqualTo("Betrayer"));
            Assert.That(sorted[1].Title, Is.EqualTo("Crawling"));
            Assert.That(sorted[0].Title, Is.EqualTo("Duality"));
        }


        [Test]
        public void ThreeWords_ExpectedAlphabeticalOrderWithCase()
        {
            List<MediaData> songs = new List<MediaData>();
            YouTubeVideo y1 = new YouTubeVideo { Title = "betrayer" };
            YouTubeVideo y2 = new YouTubeVideo { Title = "Crawling" };
            YouTubeVideo y3 = new YouTubeVideo { Title = "duality" };
            songs.Add(y1);
            songs.Add(y2);
            songs.Add(y3);

            var sorted = mediaService.SortListDescending(songs);

            Assert.That(sorted[2].Title, Is.EqualTo("betrayer"));
            Assert.That(sorted[1].Title, Is.EqualTo("Crawling"));
            Assert.That(sorted[0].Title, Is.EqualTo("duality"));
        }


        [Test]
        public void Sort_EmptyList_ExpectedEmptyReturn()
        {
            List<MediaData> songs = new List<MediaData>();

            var sorted = mediaService.SortListDescending(songs);

            Assert.That(sorted, Is.Empty);
        }


        [Test]
        public void Sort_NullList_ExpectedNullReturn()
        {
            List<MediaData> songs = null;

            var sorted = mediaService.SortListDescending(songs);

            Assert.That(sorted, Is.Empty);
        }


        [Test]
        public void ThreeWords_Duplicates_ExpectedPairedDuplicates()
        {
            List<MediaData> songs = new List<MediaData>();
            YouTubeVideo y1 = new YouTubeVideo { Title = "Betrayer" };
            YouTubeVideo y2 = new YouTubeVideo { Title = "Broken Cog" };
            YouTubeVideo y3 = new YouTubeVideo { Title = "Betrayer" };
            songs.Add(y1);
            songs.Add(y2);
            songs.Add(y3);

            var sorted = mediaService.SortListDescending(songs);

            Assert.That(sorted[2].Title, Is.EqualTo("Betrayer"));
            Assert.That(sorted[1].Title, Is.EqualTo("Betrayer"));
            Assert.That(sorted[0].Title, Is.EqualTo("Broken Cog"));
        }

    }
}
