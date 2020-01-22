using System;
using System.Collections.Generic;
using System.Text;

namespace MELITranslate.Business.Interfaces
{
    public interface ITranslateStrategy
    {
        string Translate(string value);
    }
}
