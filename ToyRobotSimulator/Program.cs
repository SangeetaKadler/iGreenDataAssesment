using System;
using System.Collections.Generic;

namespace ToyRobotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length of the tabletop sides:");
            int sideLength = GetTableDimension("Length");

            var simulator = new ToyRobotSimulator(sideLength);
            simulator.Run();
        }

        static int GetTableDimension(string dimension)
        {
            int value;
            bool isValidInput;
            do
            {
                Console.Write($"{dimension}: ");
                isValidInput = int.TryParse(Console.ReadLine(), out value);
                if (!isValidInput || value <= 0)
                    Console.WriteLine("Please enter a valid positive integer for the tabletop dimension.");
            } while (!isValidInput || value <= 0);

            return value;
        }
    }
}
