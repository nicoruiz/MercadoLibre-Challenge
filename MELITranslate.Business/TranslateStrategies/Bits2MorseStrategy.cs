using MELITranslate.Business.Exceptions;
using MELITranslate.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MELITranslate.Business.TranslateStrategies
{
    public class Bits2MorseStrategy : ITranslateStrategy
    {
        public string Translate(string value)
        {
            try
            {
                string result = String.Empty;

                for (int i = 0; i < value.Length; i += 2)
                {
                    result += GetMorseEquivalent(value.Substring(i, 2));
                }
                return HasFullStop(result) ? result.TrimEnd() : SetFullStop(result);
            }
            catch(Exception ex) 
            {
                throw new BadInputException($"Error al intentar decodificar los bits. Verifique el input '{value}' ingresado.");
            }
        }

        private string GetMorseEquivalent(string binValue)
            => TranslateTables.Bin2Morse[binValue];

        private string SetFullStop(string morseValue)
            => morseValue.TrimEnd() + " .-.-.-";

        private bool HasFullStop(string morseValue)
            => morseValue.Contains(".-.-.-");
    }
}
