using System;
using System.Collections.Generic;
using System.Text;

namespace robot.Helpers
{
    public class ModOperator
    {
        public int Mod(int x, int y)
        {
            return (x % y + y) % y;
        }
    }
}
