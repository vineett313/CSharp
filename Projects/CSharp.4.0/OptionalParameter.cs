using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._4._0
{
    public class OptionalParameter
    {
        public void TestMethod(int a = 5, int b = 5)
        {
            Console.WriteLine("TestMethod with paramter a : {0}, b : {1}", a, b);
        }

        public void TestMethod(int a = 5)
        {
            Console.WriteLine("TestMethod with paramter a : {0}", a);
        }

    }
}
