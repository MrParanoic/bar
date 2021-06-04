using System;

namespace Bar
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int barProcent = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                drawBar(barProcent);
            }
        }
        static void drawBar(int bar) 
        {
            char[] healgh = {' ',' ',' ',' ',' ',' ',' ', ' ',' ',' ' };
            Console.Write("[");
            Console.BackgroundColor = ConsoleColor.Red;
            for (int i = 0; i <= healgh.Length; i++)
            {
                if (i < bar)
                {
                    Console.Write(healgh[i]);
                }
                if (i > bar)
                {
                    Console.ResetColor();
                    Console.Write("_");
                }
            }
            Console.Write("]");
            Console.Write("[");
            Console.BackgroundColor = ConsoleColor.Blue;
            for (int i = 0; i <= healgh.Length; i++)
            {
                if (i < bar)
                {
                    Console.Write(healgh[i]);

                }
                if (i > bar)
                {
                    Console.ResetColor();
                    Console.Write("_");
                }
            }
            Console.Write("]");

        }
    }
}
