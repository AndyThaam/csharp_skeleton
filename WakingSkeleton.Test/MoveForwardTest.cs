using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WakingSkeleton.Test
{
    public class MoveForewardsTest
    {
        [Test]
        public void MoveForeWardsTest()
        {
            var xCoordinant = 1;
            var yCoordinant = 1;
            Rover rover = new Rover(new int[] { xCoordinant, yCoordinant }, "North");


            new RoverCommands().ProcessCommandString("F", rover);
            Assert.That(rover.Position, Is.EqualTo(new int[] { 1, 2 }));
        }
    }
}