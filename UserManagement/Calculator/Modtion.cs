using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Calculator
{
    public class Modtion
    {
        public static float Mod(int NumberOne, int NumberTwo)
        {
            float mod = 0;
            mod = NumberOne % NumberTwo;
            return mod;
        }
    }
}
