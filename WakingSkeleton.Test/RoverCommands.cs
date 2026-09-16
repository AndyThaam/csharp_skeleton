using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WakingSkeleton.Test
{
    public class RoverCommands
    {
        public void MoveBackwards(Rover rover, string direction)
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
        }

        public void MoveForwards(Rover rover, string direction)
        {
            switch (direction)
            {
                case "North":
                    rover.Position = new int[] { rover.Position[0], rover.Position[1] + 1 };
                    break;
                case "South":
                    rover.Position = new int[] { rover.Position[0], rover.Position[1] - 1 };
                    break;
                case "East":
                    rover.Position = new int[] { rover.Position[0] + 1, rover.Position[1] };
                    break;
                case "West":
                    rover.Position = new int[] { rover.Position[0] - 1, rover.Position[1] };
                    break;
                default:
                    throw new ArgumentException("Invalid direction");
            }
        }

        public void ProcessCommandString(string command, Rover rover)
        {
            foreach (char c in command)
            {
                switch (c)
                {
                    case 'B':
                        MoveBackwards(rover, rover.Direction);
                        break;
                    case 'F':
                        MoveForwards(rover, rover.Direction);
                        break;
                    default:
                        throw new ArgumentException("Invalid command");
                }
            }
        }
    }
}
