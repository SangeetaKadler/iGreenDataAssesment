using System;
using System.Text.RegularExpressions;

namespace ToyRobotSimulator
{
    public class CommandSimulator
    {
        private readonly int side;
        private Robot? toyRobot = null;

        public CommandSimulator(int length)
        {
            this.side = length;
        }

        public string ExecuteCommands(string[] commands)
        {
            foreach (var command in commands)
            {
                if (Regex.IsMatch(command, "^PLACE"))
                {
                    var coordinates = command.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (coordinates.Length == 4 &&
                        int.TryParse(coordinates[1], out int positionX) &&
                        int.TryParse(coordinates[2], out int positionY) &&
                        Enum.TryParse<Direction>(coordinates[3], out Direction direction) &&
                        ValidatePosition(positionX, positionY))
                    {
                        toyRobot = new Robot(positionX, positionY, direction);
                    }
                    else
                    {
                        return "Invalid PLACE command.";
                    }
                }
                else if (toyRobot != null)
                {
                    switch (command)
                    {
                        case "MOVE":
                            toyRobot.Move(this.side);
                            break;
                        case "LEFT":
                            toyRobot.Left();
                            break;
                        case "RIGHT":
                            toyRobot.Right();
                            break;
                        case "REPORT":
                            return toyRobot.Report();
                        default:
                            return "Invalid command.";
                    }
                }
                else
                {
                    return "Robot has not been placed yet.";
                }
            }

            return "No REPORT command executed.";
        }


        //Validate the initial position. the horizontal and vertical position should be within the table boundary. 
        public bool ValidatePosition(int PositionX, int PositionY)
        {
            return PositionX >= 0 && PositionX <= side && PositionY >= 0 && PositionY <= side ? true : false;
        }
    }
}