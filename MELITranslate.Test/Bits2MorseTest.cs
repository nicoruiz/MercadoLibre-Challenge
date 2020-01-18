using MELITranslate.Business;
using MELITranslate.Business.Interfaces;
using MELITranslate.Business.TranslateTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MELITranslate.Test
{
    [TestClass]
    public class Bits2MorseTest
    {
        private Translator _translator; 
        [TestInitialize]
        public void SetUp()
        {
            _translator = new Translator();
            _translator.SetTranslateType(new Bits2Morse());
        }

        [TestMethod]
        public void Given10InBinaryItShouldBeDecodedToEquivalentDotInMorse()
        {
            string binDot = "10";

            var expected = ". .-.-.-";
            var actual = _translator.Translate(binDot);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given11InBinaryItShouldBeDecodedToEquivalentDashInMorse()
        {
            string binDash = "11";

            var expected = "- .-.-.-";
            var actual = _translator.Translate(binDash);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenHolaMeLiWithFullStopInBinaryItShouldBeDecodedToEquivalentInMorse()
        {
            string holaMeLiBin = "101010100111111101101110100110110011110110011011101001101001101110111011";

            var expected = ".... --- .-.. .-  -- . .-.. .. .-.-.-";
            var actual = _translator.Translate(holaMeLiBin);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenHolaMeLiWithLongPauseInBinaryItShouldBeDecodedToEquivalentInMorse()
        {
            string holaMeLiBin = "101010100111111101101110100110110011110110011011101001101000000000";

            var expected = ".... --- .-.. .-  -- . .-.. .. .-.-.-";
            var actual = _translator.Translate(holaMeLiBin);

            Assert.AreEqual(expected, actual);
        }
    }
}
