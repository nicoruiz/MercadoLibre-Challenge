using MELITranslate.Business.Exceptions;
using MELITranslate.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MELITranslate.Business.TranslateStrategies
{
    public class Morse2TextStrategy : ITranslateStrategy
    {
        public string Translate(string value)
        {
            try
            {
                string result = String.Empty;
                var mCodes = value.Split().Where(x => x != " ").ToList();
                foreach (string mCode in mCodes)
                {
                    result += mCode != "" ? TranslateTables.Morse2Text[mCode] : " ";
                }
                return result;
            }            
            catch (Exception ex)
            {
                throw new BadInputException($"Error al intentar traducir el texto morse. Verifique el input '{value}' ingresado.");
            }
        }
    }
}
