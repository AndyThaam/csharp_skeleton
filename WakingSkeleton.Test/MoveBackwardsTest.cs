using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WakingSkeleton.Test
{
    public class MoveBackwardsTest
    {
        [Test]
        public void MoveBackWardsTest()
        {
            var xCoordinant = 1;
            var yCoordinant = 1;
            Rover rover = new Rover(new int[] { xCoordinant, yCoordinant }, "North");

            //var TargetPosition = new Position(1, 0);

            rover = new RoverCommands().ProcessCommandString("B", rover);
            Assert.That(rover.Position, Is.EqualTo(new int[] { 1, 0 }));
        }
    }
}


