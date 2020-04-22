using System;

namespace Часть2зад4
{
    class Program
    {
        static void Main()
        {
            Int16 a = 3;
            Int32 b = 4;
            double c = 5;
            c = a;
            c = b;
            // a = c;
            // a = b;
            b = a;
            // b = c;
            a = (Int16)b;
            a = (Int16)c;
            Console.WriteLine(a);
        }
    }
}
