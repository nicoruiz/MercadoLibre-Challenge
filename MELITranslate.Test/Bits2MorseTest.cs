using MELITranslate.Business;
using MELITranslate.Business.Interfaces;
using MELITranslate.Business.TranslateTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MELITranslate.Test
{
    [TestClass]
    public class Bits2MorseTest
    {
        private ITranslateType _bits2Morse;
        [TestInitialize]
        public void SetUp()
        {
            _bits2Morse = new Bits2Morse();
        }

        [TestMethod]
        public void Given10InBinaryItShouldBeDecodedToEquivalentDotInMorse()
        {
            var binDot = "10";

            var expected = ". .-.-.-";
            var actual = _bits2Morse.Translate(binDot);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given11InBinaryItShouldBeDecodedToEquivalentDashInMorse()
        {
            var binDash = "11";

            var expected = "- .-.-.-";
            var actual = _bits2Morse.Translate(binDash);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenHolaMeLiWithFullStopInBinaryItShouldBeDecodedToEquivalentInMorse()
        {
            var holaMeLiBin = "101010100111111101101110100110110011110110011011101001101001101110111011";

            var expected = ".... --- .-.. .-  -- . .-.. .. .-.-.-";
            var actual = _bits2Morse.Translate(holaMeLiBin);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenHolaMeLiWithLongPauseInBinaryItShouldBeDecodedToEquivalentInMorse()
        {
            var holaMeLiBin = "101010100111111101101110100110110011110110011011101001101000000000";

            var expected = ".... --- .-.. .-  -- . .-.. .. .-.-.-";
            var actual = _bits2Morse.Translate(holaMeLiBin);

            Assert.AreEqual(expected, actual);
        }
    }
}
