using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace robot.Models
{
    public class Robot
    {
        public Vector2 MaxArea { get; set; }
        public Vector2 CurrentLocation { get; set; }
        public string CurrentDirection { get; set; }
        public string Commands { get; set; }
    }
}
