using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ToyRobot
{
    public class Command
    {
        public Simulator Simulation;
        public Table Table = new Table(5, 5);
        public bool Placed;
        public string Message = string.Empty;
        public string ErrorInputs = "The inputs in the file are not correctly formatted.";

        public string Start(string[] commands)
        {
            Simulation = new Simulator(Table);
            foreach (string command in commands)
            {
                if (Placed)
                {
                    ProcessCommand(command);
                }
                else if (Regex.IsMatch(command, "[PLACE]"))
                {
                    Placed = true;
                    ProcessCommand(command);
                }
                if (Message == ErrorInputs)
                {
                    break;
                }
                if (Message.Length > 1)
                {
                    Console.WriteLine(Message);
                    Message = "";
                }
            }
            return Message;
        }

        public void ProcessCommand(string command)
        {
            if (Regex.IsMatch(command, "^PLACE"))
            {
                string[] coordinates = command.Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
                if (coordinates.Length == 4)
                {
                    int east;
                    int north;
                    bool eastTest = Int32.TryParse(coordinates[1], out east);
                    bool northTest = Int32.TryParse(coordinates[2], out north);
                    if (eastTest && northTest)
                    {
                        Simulation.Place(east, north, coordinates[3]);
                    }
                }
                if (Simulation.Toy == null)
                {
                    Message = ErrorInputs;
                }
            }
            else if (Regex.IsMatch(command, "^MOVE") || Regex.IsMatch(command, "^RIGHT") || Regex.IsMatch(command, "^LEFT"))
            {
                Simulation.RobotMoves(command.ToLower());
            }
            else if (Regex.IsMatch(command, "^REPORT"))
            {
                Message = Simulation.Report();
            }
            else
            {
                Message = ErrorInputs;
            }
        }
    }
}
