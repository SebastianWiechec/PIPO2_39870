using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe_lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Liczby L1 = new Liczby();
            Liczby L2 = new Liczby();

            Console.WriteLine("Wczytanie po stworzeniu obiektu L1");
            Console.WriteLine(L1.getA()+" "+L1.getB()+" "+L1.getC());
            Console.WriteLine("Naciśnij klawisz\n");
            Console.ReadKey();

            L1.setA(10);L1.setB(20);L1.setC(30);
            L2.setA(11);L2.setB(12);L2.setC(13);

            Console.WriteLine("Parametry a,b i c po ustawieniu ich na\n L1 -> 10 20 30\n L2 -> 11 12 13");
            Console.WriteLine(L1.getA() + " " + L1.getB() + " " + L1.getC());
            Console.WriteLine(L2.getA() + " " + L2.getB() + " " + L2.getC());
            Console.WriteLine("Naciśnij klawisz\n");
            Console.ReadKey();

            Lepsze_Liczby LL1 = new Lepsze_Liczby();

            Console.WriteLine("Wczytanie po stworzeniu obiektu LL1");
            Console.WriteLine(LL1.getA() + " " + LL1.getB() + " " + LL1.getC()+" "+LL1.getD());
            Console.WriteLine("Naciśnij klawisz\n");
            Console.ReadKey();

            LL1.setA(91);LL1.setB(92);LL1.setC(93);LL1.setD(94);
            Console.WriteLine("Parametry a,b,c i d po ustawieniu ich na 91 92 93 94");
            Console.WriteLine(LL1.getA() + " " + LL1.getB() + " " + LL1.getC() + " " + LL1.getD());
            Console.WriteLine("Naciśnij klawisz\n");
            Console.ReadKey();
        }
    }
}
