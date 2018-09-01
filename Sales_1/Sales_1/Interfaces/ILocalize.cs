using System;
using System.Collections.Generic;
using System.Text;

namespace Sales_1.Interfaces
{
    using System.Globalization;
    public interface ILocalize
    {
        CultureInfo GetCurrentCultureInfo();
        void SetLocale(CultureInfo ci);
    }
}


