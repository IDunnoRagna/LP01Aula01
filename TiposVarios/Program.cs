using System;

namespace TiposVarios
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int i = 0b0010_1001;
            char symbol = '\u058D';
            char invert = '\u058E';
            bool condition = 6 < 2;
            bool real = 9 > 2;
            double amount = 1984.2 - 34.82;
            {
                Console.WriteLine(symbol);
                Console.WriteLine(i);
                Console.WriteLine(invert);
                Console.WriteLine(condition);
                Console.WriteLine(real);
                Console.WriteLine(amount);
            }
        }
    }
}
