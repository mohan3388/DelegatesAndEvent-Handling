using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleCastDelegate
{
    internal class Delegate
    {
        public delegate int data(int x, int y);
        public static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
