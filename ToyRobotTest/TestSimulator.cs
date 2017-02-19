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
            Table tableTop = new Table(4, 4);
            Simulator instance = new Simulator(tableTop);
            instance.Place(0, 0, "NORTH");

            Robot expectedToy = new Robot
            {
                direction = "north",
                east = 0,
                north = 0
            };

            Assert.AreEqual(expectedToy.east, instance.Toy.east);
            Assert.AreEqual(expectedToy.north, instance.Toy.north);
            Assert.AreEqual(expectedToy.direction, instance.Toy.direction);
        }

        [TestMethod]
        public void PlaceRobotOntoInvalidLocation()
        {
            Table tableTop = new Table(4, 4);
            Simulator instance = new Simulator(tableTop);
            instance.Place(5, 5, "NORTH");
            
            Assert.IsNull(instance.Toy);
        }
    }
}
