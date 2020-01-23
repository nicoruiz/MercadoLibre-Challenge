using MELITranslate.Business.Interfaces;
using System;

namespace MELITranslate.Business
{
    public class Translator
    {
        private ITranslateStrategy _translateType { get; set; }

        public void SetTranslateType(ITranslateStrategy translateType)
        {
            _translateType = translateType;
        }

        public string Translate(string value)
            => _translateType.Translate(value);
    }
}
