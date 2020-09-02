using System;

namespace ConsoleAppAbraCadabra
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] massiv = new int[3, 3];
            Random rand = new Random();
            for (int i = 0; i < massiv.GetLength(0); i++)
                for (int j = 0; j < massiv.GetLength(1); j++)
                {
                    massiv[i, j] = rand.Next(-10, 10);
                }
            for (int i = 0; i < massiv.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < massiv.GetLength(1); j++)
                    Console.Write(massiv[i, j] + "  ");
            }

            Console.WriteLine("");
            var z = 0;
            for (int i = 0; i < massiv.GetLength(0); i++)
            {
                Console.WriteLine("  ");
                for (int j = 0; j < massiv.GetLength(1) - 1; j++)
                {
                    if (massiv[i, j] < massiv[i, j + 1])
                    {

                        z = massiv[i, j];
                        massiv[i, j] = massiv[i, j + 1];
                        massiv[i, j + 1] = z;
                    }
                    else massiv[i, j] = massiv[i, j];
                    Console.Write(massiv[i, j] + "  ");

                }
            }

            Console.ReadLine();
        }
    }
}
