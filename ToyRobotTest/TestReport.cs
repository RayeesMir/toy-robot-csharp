using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobot;

namespace ToyRobotTest
{
    [TestClass]
    public class TestReport
    {
        [TestMethod]
        public void ReportLocation()
        {
            Robot Toy = new Robot
            {
                direction = "north",
                east = 5,
                north = 4
            };

            string expected = "Robot is currently at (5, 4) and it's facing NORTH";

            string position = Toy.Report();
            
            Assert.AreEqual(expected, position);
        }
    }
}
