using System;

namespace Half_of_the_half
{
    class Program
    {
        static void Main(string[] args)
        {
            int przypadki = int.Parse(Console.ReadLine());

            for (int x  = 0; x < przypadki; x++)
            {
                string napis = Console.ReadLine();
                char[] litery = napis.ToCharArray();
                for(int i = 0; i < (litery.Length) / 2; i++)
                {
                    if( i % 2 == 0)
                    {
                        Console.Write(litery[i]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
