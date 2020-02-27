using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string c = "awwww\t man so we back in the mine";
            string f = "awwww\t man so we back in the u0488";
            string g = @"C:\awwww man\t so we back in the u0488";
            string k = "awwww" + "man" + "so we back in the mine";
            int x = 0b0010_1001;
            int y = 0b1101_1110;
            string p = "awwww" + x + "so we back in the" + y;
            string m = "awwww man" + "so we back in the {x + y}";
            string z;

            {
                Console.WriteLine(c);
                Console.WriteLine(f);
                Console.WriteLine(g);
                Console.WriteLine(k);
                Console.WriteLine(p);
                Console.WriteLine(m);
                Console.WriteLine("awww man so we back in the {0}", z);

            }
        }
    }
}
