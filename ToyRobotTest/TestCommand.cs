using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobot;

namespace ToyRobotTest
{
    [TestClass]
    public class TestCommand
    {
        [TestMethod]
        public void ProcessPlaceCommand()
        {
            Command testSetup = new Command();
            Table table = new Table(5,5);
            testSetup.Simulation = new Simulator(table);
            testSetup.ProcessCommand("PLACE 2,3,EAST");

            Assert.IsNotNull(testSetup.Simulation.Toy);
        }

        [TestMethod]
        public void ProcessInvalidPlaceCommand()
        {

        }

        [TestMethod]
        public void ProcessMoveCommand()
        {

        }

        [TestMethod]
        public void ProcessRightCommand()
        {

        }

        [TestMethod]
        public void ProcessLeftCommand()
        {

        }

        [TestMethod]
        public void ProcessReportCommand()
        {

        }

        [TestMethod]
        public void ProcessInvalidCommand()
        {

        }

        [TestMethod]
        public void LoadCommands()
        {

        }
    }
}
