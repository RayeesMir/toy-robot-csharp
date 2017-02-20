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

            string expected = "5,4,NORTH";

            string position = Toy.Report();
            
            Assert.AreEqual(expected, position);
        }
    }
}
