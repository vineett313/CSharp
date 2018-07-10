using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class Example3
    {
        public static int GetCount(this int[] obj)
        {
            return obj.Length;
        }
    }
}
