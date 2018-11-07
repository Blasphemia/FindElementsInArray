using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of lines in the array: ");
            int lines = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns in the array: ");
            int columns = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter min number for random generation:");
            int min = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter max number for random generation:");
            int max = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n");



            int[,] bubaArray = new int[lines, columns];
            var rnd = new Random();

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    bubaArray[i, j] = rnd.Next(min, max + 1);
                    Console.Write("{0}\t", bubaArray[i, j]);
                }
                Console.WriteLine("\n");
            }

            int minValue = bubaArray[0, 0];
            int maxValue = bubaArray[0, 0];

            foreach (var value in bubaArray)
            {
                if (value < minValue)
                {
                    minValue = value;
                }

                if (value > maxValue)
                {
                    maxValue = value;
                }
            }


            Console.WriteLine($"Min in array: {minValue}");
            Console.WriteLine($"Max in array: {maxValue}");







            Console.ReadLine();
        }


    }
}