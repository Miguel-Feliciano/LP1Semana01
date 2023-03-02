using System;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string item in args)
            {
               Console.WriteLine(item); 
            }
            
        }
    }
}
