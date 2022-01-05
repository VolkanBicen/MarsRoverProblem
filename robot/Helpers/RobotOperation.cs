using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using robot.Concrete;
using robot.Models;

namespace robot.Helpers
{
    internal class RobotOperation
    {
        public void Operation(Robot robot)
        {
            DirectionsOperations directionsOperations = new DirectionsOperations();
            MoveOperations moveOperations = new MoveOperations();

            foreach (var item in robot.Commands)
            {
                if (item == 'L')
                  directionsOperations.L(robot);

                else if (item == 'R')
                    directionsOperations.R(robot);
                else
                {
                    switch (robot.CurrentDirection)
                    {
                        case "N":
                            moveOperations.N(robot);
                            break;
                        case "E":
                            moveOperations.E(robot);
                            break;
                        case "S":
                            moveOperations.S(robot);
                            break;
                        case "W":
                            moveOperations.W(robot);
                            break;
                    }
                }

            }
        }
    }
}
