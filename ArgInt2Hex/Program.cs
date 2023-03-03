using System;

namespace ArgInt2Hex
{
    class Program
    {
        static void Main(string[] args)
        {
            bool i = false;
            int m;
            foreach (var item in args)
            {
                i = int.TryParse(item, out m);
                if (i)
                {
                     Console.WriteLine($"{m}-> É inteiro, valor hexadecimal: {m:x}");
                }
                else
                {
                    Console.WriteLine(item + "-> Não é inteiro");
                }
            }
                
        }
    }
}
