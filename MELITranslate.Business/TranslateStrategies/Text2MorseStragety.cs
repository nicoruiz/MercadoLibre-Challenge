using MELITranslate.Business.Exceptions;
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
            try
            {
                string result = String.Empty;
                foreach (var letter in value)
                {
                    string current = letter.ToString().ToUpper();
                    if (current != " ")
                        result += TranslateTables.Text2Morse[current];

                    if (current != ".")
                        result += BinaryConstants.LETTER_SPACE;
                }
                return result;
            }            
            catch (Exception ex)
            {
                throw new BadInputException($"Error al intentar traducir el texto. Verifique el input '{value}' ingresado.");
            }
        }
    }
}
