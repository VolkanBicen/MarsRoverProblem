using robot.Helpers;
using robot.Models;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace robot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // max Alan (5 5)
            // currentPosition (1 2 N)
            // Commands (L M L M L M M)

            Robot modelRobot = new Robot();
            Console.WriteLine("Max Area:");
            string[] tempArea = Console.ReadLine().Split(' ');
            modelRobot.MaxArea = new Vector2(float.Parse(tempArea[0]), float.Parse(tempArea[1]));
            
            while (true)
            {
                Console.WriteLine("Current Position:");
                string[] tempLocation = Console.ReadLine().Split(' ');
                modelRobot.CurrentLocation = new Vector2(float.Parse(tempLocation[0]), float.Parse(tempLocation[1]));
                modelRobot.CurrentDirection = tempLocation[2];

                Console.WriteLine("Commands:");
                modelRobot.Commands = Console.ReadLine(); 

                RobotOperation robot = new RobotOperation();
                robot.Operation(modelRobot);

               Console.WriteLine(modelRobot.CurrentLocation + " " + modelRobot.CurrentDirection);
            }
        }
    }
}
