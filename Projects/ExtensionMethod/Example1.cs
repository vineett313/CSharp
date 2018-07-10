using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class Example1
    {
        public static string DoWelcome(this string name)
        {
            return String.Format("Welcome {0}", name);
        }
    }
}
