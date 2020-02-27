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
            {
                Console.WriteLine(c);
                Console.WriteLine(f);
                Console.WriteLine(g);
            }
        }
    }
}
