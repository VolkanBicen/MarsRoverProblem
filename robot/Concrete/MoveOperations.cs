using robot.Models;
using robot.Helpers;
using System;
using System.Numerics;

namespace robot.Concrete
{
    internal class MoveOperations 
    {
        Vector2 newLocation = new Vector2();
        public void E(Robot robot)
        {
            newLocation = new Vector2(robot.CurrentLocation.X + 1, robot.CurrentLocation.Y);
          
            if (Boundary.CheckBoundary(newLocation , robot))
                robot.CurrentLocation = newLocation;
        }
        public void N(Robot robot)
        {
            newLocation = new Vector2(robot.CurrentLocation.X, robot.CurrentLocation.Y + 1);
            if (Boundary.CheckBoundary(newLocation, robot))
                robot.CurrentLocation = newLocation;
        }
        public void S(Robot robot)
        {
            newLocation = new Vector2(robot.CurrentLocation.X, robot.CurrentLocation.Y - 1);
            if (Boundary.CheckBoundary(newLocation, robot))
                robot.CurrentLocation = newLocation;
        }
        public void W(Robot robot)
        {
            newLocation = new Vector2(robot.CurrentLocation.X - 1, robot.CurrentLocation.Y);
            if (Boundary.CheckBoundary(newLocation, robot))
                robot.CurrentLocation = newLocation;
        }
    }
}
