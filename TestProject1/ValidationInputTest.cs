using SongTranslator.Components.Data;

namespace TestProject1
{
    public class MediafetchService_ValidationInput_Test
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
         * 1 both filled IN -> TRUE
         * 2 both empty  -> FALSE
         * 3 both null  -> FALSE
         * 4 first empty second filled in  -> FALSE
         * 5 second empty first filled in  -> FALSE
         * 6 second null first filled in  -> FALSE
         * 7 first filled in second null  -> FALSE
         * 8 first has whitespace second filled in  -> FALSE
         * 9 second has whitespace first filled in  -> FALSE
         */

        [Test]
        public void ValidateInput_BothFieldsFilled_ReturnTrue()
        {
            var expected = true;
            var actual = mediaService.ValidateInput("Slipknot", "Custer");
            
            Assert.That(actual, Is.EqualTo(expected));
        }


        [Test]
        public void ValidateInput_NoFieldsFilled_ReturnFalse()
        {
            var expected = false;
            var actual = mediaService.ValidateInput("", "");

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ValidateInput_FieldsNull_ReturnFalse()
        {
            var expected = false;
            var actual = mediaService.ValidateInput(null, null);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ValidateInput_FirstE_SecondF_ReturnFalse()
        {
            var expected = false;
            var actual = mediaService.ValidateInput("Slipknot", "");

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidateInput_FirstF_SecondE_ReturnFalse()
        {
            var expected = false;
            var actual = mediaService.ValidateInput("", "One");

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidateInput_FirstF_SecondNull_ReturnFalse()
        {
            var expected = false;
            var actual = mediaService.ValidateInput("Slipknot", null);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidateInput_FirstNull_SecondF_ReturnFalse()
        {
            var expected = false;
            var actual = mediaService.ValidateInput(null, "One");

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidateInput_FirstWhitespace_SecondF_ReturnFalse()
        {
            var expected = false;
            var actual = mediaService.ValidateInput("      ", "One");

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidateInput_FirstF_SecondWhitespace_ReturnFalse()
        {
            var expected = false;
            var actual = mediaService.ValidateInput("Slipknot", "      ");

            Assert.AreEqual(expected, actual);
        }
    }
}