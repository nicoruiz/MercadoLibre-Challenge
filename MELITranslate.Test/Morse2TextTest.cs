using MELITranslate.Business;
using MELITranslate.Business.TranslateTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MELITranslate.Test
{
    [TestClass]
    public class Morse2TextTest
    {
        private Translator _translator;
        [TestInitialize]
        public void SetUp()
        {
            _translator = new Translator();
            _translator.SetTranslateType(new Morse2Text());
        }

        [TestMethod]
        public void GivenHolaMeLiInMorseItShouldBeTranslatedToEquivalentInText()
        {
            string holaMeLi = ".... --- .-.. .-  -- . .-.. .. .-.-.-";

            var expected = "HOLA MELI.";
            var actual = _translator.Translate(holaMeLi);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenASentenceInMorseItShouldBeTranslatedToEquivalentInText()
        {
            string probando = ".--. .-. --- -... .- -. -.. ---  - .-. .- -.. ..- -.-. -.-. .. --- -.  .-  " +
                              "-.-. --- -.. .. --. ---  -- --- .-. ... . .-.-.-";

            var expected = "PROBANDO TRADUCCION A CODIGO MORSE.";
            var actual = _translator.Translate(probando);

            Assert.AreEqual(expected, actual);
        }
    }
}
