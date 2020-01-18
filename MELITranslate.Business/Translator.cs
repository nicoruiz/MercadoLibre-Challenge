using MELITranslate.Business.Interfaces;
using System;

namespace MELITranslate.Business
{
    public class Translator
    {
        private ITranslateType _translateType { get; set; }

        public void SetTranslateType(ITranslateType translateType)
        {
            _translateType = translateType;
        }

        public string Translate(string value)
            => _translateType.Translate(value);
    }
}
