using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "Miguel";
            string n = @"\This in literally between backslashes\";
            string m = "The following unicode will show: \u26a1 ";
            string b = @"The following unicode won't show: \u26a1";
            string c = "This tab\t spaces out but this tab \\t shows up";
            
            Console.WriteLine(s);
            Console.WriteLine(n);
            Console.WriteLine(m);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
