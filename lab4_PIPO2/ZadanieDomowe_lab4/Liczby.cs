using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;

namespace ZadanieDomowe_lab4
{
    public class Liczby
    {
        protected int a;
        protected int b;
        protected int c;

        public Liczby()
        {
            a = 0; b = 0; c = 0;
        }

        public int getA() => a;

        public int getB() => b;

        public int getC() => c;

        public void setA(int a)
        {
            this.a = a; ;
        }

        public void setB(int b)
        {
            this.b = b;
        }

        public void setC(int c)
        {
            this.c = c;
        }
    }
}