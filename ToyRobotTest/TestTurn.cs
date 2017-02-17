using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobot;

namespace ToyRobotTest
{
    [TestClass]
    public class TestTurn
    {
        [TestMethod]
        public void WhenFacingNorthTurnLeft()
        {
            Robot Toy = new Robot {direction = "north"};

            Toy.TurnLeft();
            
            Assert.AreEqual("west", Toy.direction);

        }

        [TestMethod]
        public void WhenFacingNorthTurnRight()
        {
            Robot Toy = new Robot { direction = "north" };

            Toy.TurnRight();

            Assert.AreEqual("east", Toy.direction);

        }

        [TestMethod]
        public void WhenFacingEastTurnLeft()
        {
            Robot Toy = new Robot { direction = "east" };

            Toy.TurnLeft();

            Assert.AreEqual("north", Toy.direction);

        }

        [TestMethod]
        public void WhenFacingEastTurnRight()
        {
            Robot Toy = new Robot { direction = "east" };

            Toy.TurnRight();

            Assert.AreEqual("south", Toy.direction);

        }

        [TestMethod]
        public void WhenFacingSouthTurnLeft()
        {
            Robot Toy = new Robot { direction = "south" };

            Toy.TurnLeft();

            Assert.AreEqual("east", Toy.direction);

        }

        [TestMethod]
        public void WhenFacingSouthTurnRight()
        {
            Robot Toy = new Robot { direction = "south" };

            Toy.TurnRight();

            Assert.AreEqual("west", Toy.direction);

        }

        [TestMethod]
        public void WhenFacingWestTurnLeft()
        {
            Robot Toy = new Robot { direction = "west" };

            Toy.TurnLeft();

            Assert.AreEqual("south", Toy.direction);

        }

        [TestMethod]
        public void WhenFacingWestTurnRight()
        {
            Robot Toy = new Robot { direction = "west" };

            Toy.TurnRight();

            Assert.AreEqual("north", Toy.direction);

        }
    }
}
