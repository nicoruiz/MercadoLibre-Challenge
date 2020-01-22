using MELITranslate.Business;
using MELITranslate.Business.Interfaces;
using MELITranslate.Business.TranslateStrategies;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MELITranslate.Test
{
    [TestClass]
    public class Morse2TextTest
    {
        private ITranslateStrategy _morse2Text;
        [TestInitialize]
        public void SetUp()
        {
            _morse2Text = new Morse2TextStrategy();
        }

        [TestMethod]
        public void GivenHolaMeLiInMorseItShouldBeTranslatedToEquivalentInText()
        {
            var holaMeLi = ".... --- .-.. .-  -- . .-.. .. .-.-.-";

            var expected = "HOLA MELI.";
            var actual = _morse2Text.Translate(holaMeLi);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenASentenceInMorseItShouldBeTranslatedToEquivalentInText()
        {
            var probando = ".--. .-. --- -... .- -. -.. ---  - .-. .- -.. ..- -.-. -.-. .. --- -.  .-  " +
                              "-.-. --- -.. .. --. ---  -- --- .-. ... . .-.-.-";

            var expected = "PROBANDO TRADUCCION A CODIGO MORSE.";
            var actual = _morse2Text.Translate(probando);

            Assert.AreEqual(expected, actual);
        }
    }
}
