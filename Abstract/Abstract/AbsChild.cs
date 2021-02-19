using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class AbsChild : AbsParent
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        static void Main()
        {
            AbsChild c = new AbsChild();
            c.Add(50, 50);
            c.Mul(2, 5);
            Console.ReadLine();
        }
    }
}
