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
    }
}
