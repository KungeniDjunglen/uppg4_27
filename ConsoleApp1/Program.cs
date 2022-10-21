
using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett medelande:");
            string medelande = Console.ReadLine();
            Console.WriteLine("Hur många steg åt höger ska medelandet stå?");
            int steg = int.Parse(Console.ReadLine());

            for (int i = 0; i < medelande.Length; i++)
            {

                string ord = medelande[i].ToString();

                for (int j = 0; j < steg; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(ord);
                Console.WriteLine();
            }

        }
    }
}
