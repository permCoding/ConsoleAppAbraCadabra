using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbraCadabra
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] massiv = new int[3, 3]; // тут константы - это странно :(
            int rows = massiv.GetLength(0), cols = massiv.GetLength(1);

            void Print2DArray() // метод печати - для удобства
            {
                Console.WriteLine("2D Array");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }


            for (int i = 0; i < rows; i++) // заполняем
            {
                for (int j = 0; j < cols; j++)
                {
                    massiv[i, j] = rand.Next(-10, 10);
                }
            }

            Print2DArray(); // до сортировки

            for (int i = 0; i < rows; i++) // все строки
            {
                for (int j = 0; j < cols - 1; j++) // все столбцы
                {
                    for (int k = 0; k < cols - 1 - j; k++) // пузырёк в строке тонет вправо
                    {
                        if (massiv[i, k] < massiv[i, k + 1])
                        {
                            (massiv[i, k], massiv[i, k + 1]) = (massiv[i, k + 1], massiv[i, k]);
                        }
                    }
                }
            }

            Print2DArray(); // после сортировки

            Console.ReadLine();
        }
    }
}
