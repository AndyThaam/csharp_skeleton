using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WakingSkeleton.Test
{
    public class RoverCommands
    {
        public Rover MoveBackwards(Rover rover, string direction)
        {
            switch (direction)
            {
                case "North":
                    rover.Position = new int[] { rover.Position[0], rover.Position[1] - 1 };
                    break;
                case "South":
                    rover.Position = new int[] { rover.Position[0], rover.Position[1] + 1 };
                    break;
                case "East":
                    rover.Position = new int[] { rover.Position[0] - 1, rover.Position[1] };
                    break;
                case "West":
                    rover.Position = new int[] { rover.Position[0] + 1, rover.Position[1] };
                    break;
                default:
                    throw new ArgumentException("Invalid direction");
            }
            return rover;
        }

        public int[] MoveForwards(Rover rover, string direction)
        {
            switch (direction)
            {
                case "North":
                    return new int[] { rover.Position[0], rover.Position[1] + 1 };
                case "South":
                    return new int[] { rover.Position[0], rover.Position[1] - 1 };
                case "East":
                    return new int[] { rover.Position[0] + 1, rover.Position[1] };
                case "West":
                    return new int[] { rover.Position[0] - 1, rover.Position[1] };
                default:
                    throw new ArgumentException("Invalid direction");
            }
        }

        public Rover ProcessCommandString(string command, Rover rover)
        {
            switch (command)
            {
                case "B":
                    MoveBackwards(rover, rover.Direction);
                    break;
                case "F":
                    MoveForwards(rover, rover.Direction);
                    break;
                default:
                    throw new ArgumentException("Invalid command");
            }
            return rover;
        }
    }
}
