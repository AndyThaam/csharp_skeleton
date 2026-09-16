using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WakingSkeleton.Test
{
    public class Rover
    {
        public Rover(int[] position, string direction)
        {
            Position = position;
            Direction = direction;
        }

        public int[] Position { get; set; }
        public string Direction { get; set; }


        public void Command(string commandType, string direction)
        {
            switch (commandType)
            {
                case "F":
                    MoveForwards(direction);
                    break;
                case "B":
                    MoveBackwards(direction);
                    break;
                default:
                    break;
            }
        }

        public void MoveBackwards(string direction)
        {
            switch (direction)
            {
                case "North":
                    Position[1] -= 1;
                    break;
                case "South":
                    Position[1] += 1;
                    break;
                case "East":
                    Position[0] -= 1;
                    break;
                case "West":
                    Position[0] += 1;
                    break;
                default:
                    throw new ArgumentException("Invalid direction");
            }

        }

        public void MoveForwards(string direction)
        {
            switch (direction)
            {
                case "North":
                    Position[1] += 1;
                    break;
                case "South":
                    Position[1] -= 1;
                    break;
                case "East":
                    Position[0] += 1;
                    break;
                case "West":
                    Position[0] -= 1;
                    break;
                default:
                    throw new ArgumentException("Invalid direction");
            }

        }
    }
}
