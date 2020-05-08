using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZadanieDomowe_lab4
{
    public class Lepsze_Liczby : Liczby
    {
        protected int d;

        public Lepsze_Liczby()
        {
            d = 0;
        }
        public int getD() => d;

        public void setD(int d)
        {
            this.d = d;
        }
    }
}