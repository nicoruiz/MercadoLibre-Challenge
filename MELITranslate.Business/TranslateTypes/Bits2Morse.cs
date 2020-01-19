using MELITranslate.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return HasFullStop(result) ? result.TrimEnd() : SetFullStop(result);
        }

        private string GetMorseEquivalent(string binValue)
            => TranslateTables.Bin2Morse[binValue];

        private string SetFullStop(string morseValue)
            => morseValue.TrimEnd() + " .-.-.-";

        private bool HasFullStop(string morseValue)
            => morseValue.Contains(".-.-.-");
    }
}
