# toy-robot-csharp
Coding Challenge question: Toy Robot Simulator

Toy Robot Simulator

Description

The application is a simulation of a toy robot moving on a square tabletop, 
of dimensions 5 units x 5 units.

There are no other obstructions on the table surface.

The robot is free to roam around the surface of the table, but must be 
prevented from falling to destruction. Any movement that would result in the 
robot falling from the table must be prevented, however further valid movement 
commands will still be allowed.

The applications reads in a .txt file with commands in the following form:

PLACE X,Y,F

MOVE

LEFT

RIGHT

REPORT


PLACE will put the toy robot on the table in position X,Y and facing 
NORTH, SOUTH, EAST or WEST.

The origin (0,0) can be considered to be the SOUTH WEST most corner.

The first valid command to the robot is a PLACE command, after that, 
any sequence of commands may be issued, in any order, including another PLACE command. 
The application should discard all commands in the sequence until a valid PLACE 
command has been executed

MOVE will move the toy robot one unit forward in the direction it is currently facing.

LEFT and RIGHT will rotate the robot 90 degrees in the specified direction without 
changing the position of the robot.

REPORT will announce the X,Y and F of the robot. This can be in any form, but standard 
output is sufficient.

A robot that is not on the table will ignore the MOVE, LEFT, RIGHT and 
REPORT commands.

Example Input and Output:

Example a

PLACE 0,0,NORTH

MOVE

REPORT

Expected output: 0,1,NORTH

Example b

PLACE 0,0,NORTH

LEFT

REPORT

Expected output: 0,0,WEST

Example c

PLACE 1,2,EAST

MOVE

MOVE

LEFT

MOVE

REPORT

Expected output: 3,3,NORTH

Setup

Because C# is a compiled language you will need to load this repo in Visual Studio and
build it. This application was developed Visual Studion 2015 Community.

Clone this repo:

git clone git@github.com:Julzerator/toy-robot-csharp.git

Open the ToyRobot.sln and build Release. The application will be here:
../ToyRobot/bin/Release

And you're ready to go!

To Use:

Create a .txt file with a series of commands on new lines, such as test.txt
Save this file in the same directory as the .exe
In a cmd window, navigate to the directory and type in the following.

>ToyRobot test.txt
