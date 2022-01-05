using robot.Models;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace robot.Helpers
{
    internal class Boundary
    {
        public static bool CheckBoundary(Vector2 nextLocation, Models.Robot robot)
        {
            var maxBoundary = new Vector2(robot.MaxArea.X, robot.MaxArea.Y);
            var result = Vector2.Subtract(maxBoundary, nextLocation);

            if (result.X>=0 && result.Y >= 0)
                return true;
            
            return false;
        }
    }
}
