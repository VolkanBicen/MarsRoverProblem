using robot.Models;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace robot.Helpers
{
    internal class DirectionsOperations
    {
        ModOperator modOperator = new ModOperator();
        public void L(Robot robot)
        {
            int directionValue = (int)Enum.Parse(typeof(Directions), robot.CurrentDirection);
            int nextDirectionValue = modOperator.Mod(directionValue - 1, 4);
            var nextDirection = (Directions)nextDirectionValue;
            robot.CurrentDirection = nextDirection.ToString();
        }
        public void R(Robot robot)
        {
            int directionValue = (int)Enum.Parse(typeof(Directions), robot.CurrentDirection);
            int nextDirectionValue = modOperator.Mod(directionValue + 1, 4);
            var nextDirection = (Directions)nextDirectionValue;
            robot.CurrentDirection = nextDirection.ToString();
        }

    }
}
