using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga_fel1
{
    internal class Program
    {
        public static void jegyek()
        { var szam = 0;
            Console.WriteLine("Adja meg a pontszámot (0-100): ", szam);
            szam = Convert.ToInt32(Console.ReadLine());
            if (szam >= 0 && szam <= 49)
            { Console.WriteLine("Elégtelen");}
            else if (szam >= 50 && szam <= 59)
            { Console.WriteLine("Elégséges"); }
            else if (szam >= 60 && szam <= 79)
            { Console.WriteLine("Közepes"); }
            else if (szam >= 80 && szam <= 89)
            { Console.WriteLine("Jó"); }
            else if (szam >= 90 && szam <= 100)
            { Console.WriteLine("Jeles"); }
            else { Console.WriteLine("Érvénytelen pontszám"); }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            jegyek();
        }
    }
}
