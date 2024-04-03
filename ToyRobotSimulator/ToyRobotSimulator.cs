using System;
using System.Collections.Generic;

namespace ToyRobotSimulator
{
    class ToyRobotSimulator
    {
        private readonly CommandSimulator commandSimulator;

        public ToyRobotSimulator(int sideLength)
        {
            commandSimulator = new CommandSimulator(sideLength);
        }

        public void Run()
        {
            Console.WriteLine("Please enter your commands in the following format:");
            Console.WriteLine("  PLACE X,Y,F");
            Console.WriteLine("  MOVE");
            Console.WriteLine("  LEFT");
            Console.WriteLine("  RIGHT");
            Console.WriteLine("  REPORT");
            Console.WriteLine("Enter an empty line to finish.");

            var inputCommands = new List<string>();
            string? command = null;
            do
            {
                Console.Write("> ");
                command = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(command))
                    inputCommands.Add(command.ToUpper());
            } while (!string.IsNullOrWhiteSpace(command));

            Console.WriteLine("Output:");
            Console.WriteLine(commandSimulator.ExecuteCommands(inputCommands.ToArray()));
            Console.ReadLine();
        }
    }
}