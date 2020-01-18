using MELITranslate.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MELITranslate.Business.TranslateTypes
{
    public class Bits2Morse : ITranslateType
    {
        public string Translate(string value)
        {
            string result = String.Empty;

            for(int i=0; i < value.Length; i+=2)
            {
                result += GetMorseEquivalent(value.Substring(i, 2));
            }
            return result;
        }

        private string GetMorseEquivalent(string binValue)
        {
            string morseValue = String.Empty;
            switch(binValue)
            {
                case "10":
                    morseValue = ".";
                    break;
                case "11":
                    morseValue = "-";
                    break;
                case "01":
                    morseValue = " ";
                    break;
                case "00":
                    morseValue = "  ";
                    break;
                default:
                    break;
            }
            return morseValue;
        }
    }
}
