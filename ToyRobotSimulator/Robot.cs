using System;

namespace ToyRobotSimulator
{
    class Robot
    {
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
        public Direction FacingDirection { get; private set; }
        public Robot(int positionX, int positionY, Direction facing)
        {
            PositionX = positionX;
            PositionY = positionY;
            FacingDirection = facing;
        }


        // If the Robot is already at the position at the edge of the table, example 0,5 and facing east then next move is not posible. Similary,
        // at position 5,0 when facing NORTH next move will get to position 6,0 which is not possible, So skip the move as per the requirement
        // Skipping the move when the move gets the Robot out of the table, We can display user a message if required. 
        public void Move(int sideLength)
        {
            switch (FacingDirection)
            {
                case Direction.NORTH:
                    if (PositionY < sideLength)
                        PositionY++;
                    break;
                case Direction.SOUTH:
                    if (PositionY > 0)
                        PositionY--;
                    break;
                case Direction.EAST:
                    if (PositionX < sideLength)
                        PositionX++;
                    break;
                case Direction.WEST:
                    if (PositionX > 0)
                        PositionX--;
                    break;
            }
        }


        public void Left()
        {
            switch (FacingDirection)
            {
                case Direction.NORTH:
                    FacingDirection = Direction.WEST;
                    break;
                case Direction.SOUTH:
                    FacingDirection = Direction.EAST;
                    break;
                case Direction.EAST:
                    FacingDirection = Direction.NORTH;
                    break;
                case Direction.WEST:
                    FacingDirection = Direction.SOUTH;
                    break;
            }
        }

        public void Right()
        {
            switch (FacingDirection)
            {
                case Direction.NORTH:
                    FacingDirection = Direction.EAST;
                    break;
                case Direction.SOUTH:
                    FacingDirection = Direction.WEST;
                    break;
                case Direction.EAST:
                    FacingDirection = Direction.SOUTH;
                    break;
                case Direction.WEST:
                    FacingDirection = Direction.NORTH;
                    break;
            }
        }


        public string Report()
        {
            return string.Concat(PositionX, ",", PositionY, ",", FacingDirection);
        }
    }
}





