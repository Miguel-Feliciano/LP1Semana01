using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 14.21;
            float f = 123.456f;
            decimal z = 789.34m;
            int i = 21;
            uint u = 14U;
            long l = 420L;
            ulong n = 2319UL;

            char spadeSymbol = '\u2660';
            char starSymbol = '\u2605';
            char noteSymbol = '\u266c';
            char recycleSymbol = '\u267b';
            char nuclearSymbol = '\u2622';

            bool yes = true;
            bool no = false;
            
            

            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.WriteLine(z);
            Console.WriteLine(i);
            Console.WriteLine(u);
            Console.WriteLine(l);
            Console.WriteLine(n);

            Console.WriteLine(spadeSymbol);
            Console.WriteLine(starSymbol);
            Console.WriteLine(noteSymbol);
            Console.WriteLine(recycleSymbol);
            Console.WriteLine(nuclearSymbol);

            Console.WriteLine(yes);
            Console.WriteLine(no);

        }
    }
}
