# Toy Robot Simulator
## Description
- The application is a simulation of a toy robot moving on a square tabletop, of dimensions
  5 units x 5 units.
- There are no other obstructions on the table surface.
- The robot is free to roam around the surface of the table, but must be prevented from
  falling to destruction. Any movement that would result in the robot falling from the table
  must be prevented, however further valid movement commands must still be allowed.
- Create an application that can read in commands of the following form -
  - PLACE X,Y,F
  - MOVE
  - LEFT
  - RIGHT
  - REPORT
- PLACE will put the toy robot on the table in position X,Y and facing NORTH, SOUTH,
  EAST or WEST.
- The origin (0,0) can be considered to be the SOUTH WEST most corner.
- The first valid command to the robot is a PLACE command, after that, any sequence of
  commands may be issued, in any order, including another PLACE command. The
  application should discard all commands in the sequence until a valid PLACE command
  has been executed.
- MOVE will move the toy robot one unit forward in the direction it is currently facing.
- LEFT and RIGHT will rotate the robot 90 degrees in the specified direction without
  changing the position of the robot.
- REPORT will announce the X,Y and F of the robot. This can be in any form, but standard
  output is sufficient.
- A robot that is not on the table can choose the ignore the MOVE, LEFT, RIGHT and
  REPORT commands.
- Input can be from a file, or from standard input, as the developer chooses.
- Provide test data to exercise the application. (file input commands.txt)

## Constraints
The toy robot must not fall off the table during movement. This also includes the initial
placement of the toy robot.
Any move that would cause the robot to fall must be ignored.
Example Input and Output:
```
PLACE 0,0,NORTH
MOVE
REPORT
Output: 0,1,NORTH

PLACE 0,0,NORTH
LEFT
REPORT
Output: 0,0,WEST
```

## Instructions to run the project
Please follow the following steps to run the Toy Robot Simulator project
1. Clone or download the Toy Robot Simulator project from the git repository 
2. Open Visual Studio (ensure you have .NET 6.0 or later installed), and navigate to the location where you saved the project files. Open the solution file (ToyRobotSimulator.sln) in Visual Studio.
3. Once the project is opened in Visual Studio, build the solution by selecting "Build" --> "Build Solution" from the menu bar. This will compile the code and ensure there are no compilation errors.
4. After successfully building the solution, you can run the Toy Robot Simulator by setting the project containing the main program (i.e. ToyRobotSimulator) as the startup project. Right-click on the project in the Solution Explorer and select "Set as Startup Project." Then, press F5 or click on the "Start" button in the toolbar to run the program.
5. Once the program starts, it will prompt you to enter the dimensions of the tabletop (the length of the sides). Enter the dimensions as requested. Then, follow the instructions to enter the commands for the toy robot simulation. You can provide commands like PLACE X,Y,F, MOVE, LEFT, RIGHT, and REPORT. Enter an empty line to finish entering commands and see the output.
6. After providing input commands, the program will execute the toy robot simulation and display the output. Review the output to see the final position and direction of the robot.
7. You can run the Toy Robot Simulator multiple times with different input commands and tabletop dimensions as needed.

