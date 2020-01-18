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

            var expected = ".";
            var actual = _translator.Translate(binDot);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given11InBinaryItShouldBeDecodedToEquivalentDashInMorse()
        {
            string binDot = "11";

            var expected = "-";
            var actual = _translator.Translate(binDot);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenHolaMeLiInBinaryItShouldBeDecodedToEquivalentInMorse()
        {
            string holaMeLiBin = "1010101001111111011011101001101100111101100110111010011010";

            var expected = ".... --- .-.. .-  -- . .-.. ..";
            var actual = _translator.Translate(holaMeLiBin);

            Assert.AreEqual(expected, actual);
        }
    }
}
