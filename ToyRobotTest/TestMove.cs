using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobot;

namespace ToyRobotTest
{
    [TestClass]
    public class TestMove
    {
        [TestMethod]
        public void MoveThreeTimesEast()
        {
            Robot Toy = new Robot {direction = "east"};

            Toy.Move();
            Toy.Move();
            Toy.Move();

            Assert.AreEqual(3, Toy.east);
        }

        [TestMethod]
        public void MoveFourTimesEast()
        {
            Robot Toy = new Robot {direction = "east"};

            Toy.Move();
            Toy.Move();
            Toy.Move();
            Toy.Move();

            Assert.AreEqual(4, Toy.east);
        }

        [TestMethod]
        public void MoveThreeTimesWest()
        {
            Robot Toy = new Robot {direction = "west"};

            Toy.Move();
            Toy.Move();
            Toy.Move();

            Assert.AreEqual(-3, Toy.east);
        }

        [TestMethod]
        public void MoveFourTimesWest()
        {
            Robot Toy = new Robot { direction = "west" };

            Toy.Move();
            Toy.Move();
            Toy.Move();
            Toy.Move();

            Assert.AreEqual(-4, Toy.east);
        }

        [TestMethod]
        public void MoveThreeTimesNorth()
        {
            Robot Toy = new Robot { direction = "north" };

            Toy.Move();
            Toy.Move();
            Toy.Move();

            Assert.AreEqual(3, Toy.north);
        }

        [TestMethod]
        public void MoveFourTimesNorth()
        {
            Robot Toy = new Robot { direction = "north" };

            Toy.Move();
            Toy.Move();
            Toy.Move();
            Toy.Move();

            Assert.AreEqual(4, Toy.north);
        }

        [TestMethod]
        public void MoveThreeTimesSouth()
        {
            Robot Toy = new Robot { direction = "south" };

            Toy.Move();
            Toy.Move();
            Toy.Move();

            Assert.AreEqual(-3, Toy.north);
        }

        [TestMethod]
        public void MoveFourTimesSouth()
        {
            Robot Toy = new Robot { direction = "south" };

            Toy.Move();
            Toy.Move();
            Toy.Move();
            Toy.Move();

            Assert.AreEqual(-4, Toy.north);
        }

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
