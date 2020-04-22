using System;

namespace зад4
{
    class Program
    {
        static void Main()
        {
            string a = "Строка и несколько слов";
            string[] b = a.Split();
            Array.Sort(b);
            a = String.Join(' ', b);
            Console.WriteLine(a);
        }
    }
}
