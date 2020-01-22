using MELITranslate.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MELITranslate.Business.TranslateStrategies
{
    public class Text2MorseStragety : ITranslateStrategy
    {
        public string Translate(string value)
        {
            string result = String.Empty;
            foreach (var letter in value)
            {
                string current = letter.ToString();
                if(current != " ") 
                    result += TranslateTables.Text2Morse[letter.ToString()];

                if (current != ".")
                    result += BinaryConstants.LETTER_SPACE;
            }
            return result;
        }
    }
}
