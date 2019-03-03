using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleDelegate
{
    public delegate int MultiDel(int x, int y);
    public class Multi
    {
        public int MultiMethod(int x, int y)
        {
            return x * y;
        }
    }
}
