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
        public string Message;
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
                else if (Regex.IsMatch(command, "[PLACED]"))
                {
                    Placed = true;
                    ProcessCommand(command);
                }
            }
            return Message;
        }

        public void ProcessCommand(string command)
        {
            
        }
    }
}
