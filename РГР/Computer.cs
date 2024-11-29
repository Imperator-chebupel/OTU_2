using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace РГР
{
    internal class Computer
    {
        public double Number;
        Random r = new Random();
        internal bool Play()
        {
            if (r.NextDouble() > Number)
                return false;
            else
                return true;
        }
    }
}
