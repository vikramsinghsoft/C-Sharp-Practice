using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class AbsParent
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        public abstract void Mul(int x, int y);
    }
}
