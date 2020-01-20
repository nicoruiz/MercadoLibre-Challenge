using MELITranslate.Business;
using MELITranslate.Business.Interfaces;
using MELITranslate.Business.TranslateTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MELITranslate.Test
{
    [TestClass]
    public class Text2MorseTest
    {
        private ITranslateType _text2Morse;
        [TestInitialize]
        public void SetUp()
        {
            _text2Morse = new Text2Morse();
        }

        [TestMethod]
        public void GivenHolaMeLiInTextItShouldBeTranslatedToEquivalentInMorse()
        {
            var holaMeLi = "HOLA MELI.";

            var expected = ".... --- .-.. .-  -- . .-.. .. .-.-.-";
            var actual = _text2Morse.Translate(holaMeLi);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenASentenceInTextItShouldBeTranslatedToEquivalentInMorse()
        {
            var probando = "PROBANDO TRADUCCION A CODIGO MORSE.";
            
            var expected = ".--. .-. --- -... .- -. -.. ---  - .-. .- -.. ..- -.-. -.-. .. --- -.  .-  " +
                           "-.-. --- -.. .. --. ---  -- --- .-. ... . .-.-.-";
            var actual = _text2Morse.Translate(probando);

            Assert.AreEqual(expected, actual);
        }
    }
}
