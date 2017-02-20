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
            Command testSetup = new Command();
            Table table = new Table(5, 5);
            testSetup.Simulation = new Simulator(table);
            testSetup.ProcessCommand("PLACE 6,3,EAST");

            Assert.AreSame(testSetup.ErrorInputs, testSetup.Message);
        }

        [TestMethod]
        public void ProcessMoveCommand()
        {
            Command testSetup = new Command();
            Table table = new Table(5, 5);
            testSetup.Simulation = new Simulator(table);
            testSetup.ProcessCommand("PLACE 2,3,EAST");
            testSetup.ProcessCommand("MOVE");

            Robot expected = new Robot {east = 3, north = 3, direction = "east"};

            Assert.AreEqual(expected.east, testSetup.Simulation.Toy.east);
        }

        [TestMethod]
        public void ProcessMoveWallCommand()
        {
            Command testSetup = new Command();
            Table table = new Table(5, 5);
            testSetup.Simulation = new Simulator(table);
            testSetup.ProcessCommand("PLACE 4,4,EAST");
            testSetup.ProcessCommand("MOVE");

            Robot expected = new Robot { east = 4, north = 4, direction = "east" };

            Assert.AreEqual(expected.east, testSetup.Simulation.Toy.east);
        }

        [TestMethod]
        public void ProcessRightCommand()
        {
            Command testSetup = new Command();
            Table table = new Table(5, 5);
            testSetup.Simulation = new Simulator(table);
            testSetup.ProcessCommand("PLACE 2,3,EAST");
            testSetup.ProcessCommand("RIGHT");

            Robot expected = new Robot { east = 2, north = 3, direction = "south" };

            Assert.AreEqual(expected.direction, testSetup.Simulation.Toy.direction);
        }

        [TestMethod]
        public void ProcessLeftCommand()
        {
            Command testSetup = new Command();
            Table table = new Table(5, 5);
            testSetup.Simulation = new Simulator(table);
            testSetup.ProcessCommand("PLACE 2,3,EAST");
            testSetup.ProcessCommand("LEFT");

            Robot expected = new Robot { east = 2, north = 3, direction = "north" };

            Assert.AreEqual(expected.direction, testSetup.Simulation.Toy.direction);
        }

        [TestMethod]
        public void ProcessReportCommand()
        {
            Command testSetup = new Command();
            Table table = new Table(5, 5);
            testSetup.Simulation = new Simulator(table);
            testSetup.ProcessCommand("PLACE 2,3,EAST");
            testSetup.ProcessCommand("REPORT");

            string expected = "2,3,EAST";

            Assert.AreEqual(expected, testSetup.Message);
        }

        [TestMethod]
        public void ProcessInvalidCommand()
        {
            Command testSetup = new Command();
            Table table = new Table(5, 5);
            testSetup.Simulation = new Simulator(table);
            testSetup.ProcessCommand("GIBBERISH");

            string expected = testSetup.ErrorInputs;

            Assert.AreEqual(expected, testSetup.Message);
        }
    }
}
