using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._4._0
{
    public class NamedParameter
    {
        public void TestMethod(int a, string b)
        {
            Console.WriteLine("In NamedParameter TestMethod Class Method a : {0}, b : {1}", a, b);
        }

        public virtual void TestMethod(int a, int b)
        {
            Console.WriteLine("In NamedParameter TestMethod Class Method a : {0}, b : {1}", a, b);
        }
    }

    public class DerivedClass : NamedParameter
    {
        public override void TestMethod(int b, int a)
        {
            Console.WriteLine("In Derived Class TestMethod Method a : {0}, b : {1}", a, b);
        }

        public void TestMethod(int a, string b)
        {
            Console.WriteLine("In Derived TestMethod Class Method a : {0}, b : {1}", a, b);
        }
    }
}
