using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobot;

namespace ToyRobotTest
{
    [TestClass]
    public class TestSimulator
    {
        [TestMethod]
        public void PlaceRobotOntoValidLocation()
        {
            Table table = new Table(4, 4);
            Simulator instance = new Simulator(table);
            instance.Place(0, 0, "NORTH");

            Assert.IsInstanceOfType(instance.Toy, Robot);
        }

        [TestMethod]
        public void PlaceRobotOntoInvalidLocation()
        {

        }
    }
}
