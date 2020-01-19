using MELITranslate.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MELITranslate.Business.TranslateTypes
{
    public class Morse2Text : ITranslateType
    {
        public string Translate(string value)
        {
            string result = String.Empty;
            var mCodes = value.Split().Where(x => x != " ").ToList();
            foreach (string mCode in mCodes)
            {
                result += mCode != "" ? TranslateTables.Morse2Text[mCode] : " ";
            }
            return result;
        }
    }
}
