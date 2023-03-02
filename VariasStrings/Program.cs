using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 14;
            int y = 21;
            int z = 2319;

            double xx = 0.12345;
            int ii = 18;

            string s = "Miguel";
            string n = @"\This in literally between backslashes\";
            string m = "The following unicode will show: \u26a1 ";
            string b = @"The following unicode won't show: \u26a1";
            string c = "This tab\t spaces out but this tab \\t shows up\n";

            
            
            Console.WriteLine(s);
            Console.WriteLine(n);
            Console.WriteLine(m);
            Console.WriteLine(b);
            Console.WriteLine(c);
            
            string conc = s + " Feliciano";
            string nonc = "This is exercise number " + 5;
            string inter = $"{x} plus {y} equals {x + y}";
            string format = String.Format("X is {0}, Y is {1}\n", x,y);
            Console.WriteLine("The value of z is :{0}", z);

            Console.WriteLine(conc);
            Console.WriteLine(nonc);
            Console.WriteLine(inter);
            Console.WriteLine(format);

            Console.WriteLine($"xx = {xx:f2}");
            Console.WriteLine($"xx = {xx:p1}");
            Console.WriteLine($"ii = {ii:x}");
            Console.WriteLine($"ii = {ii:c}");
        }
    }
}
