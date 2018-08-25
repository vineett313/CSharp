using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._4._0
{
    public class CoAndContraVariance
    {

        public void CoVarianceExample()
        {
            // Covariance.   
            IEnumerable<string> strings = new List<string>();
            // An object that is instantiated with a more derived type argument   
            // is assigned to an object instantiated with a less derived type argument.   
            // Assignment compatibility is preserved.   
            IEnumerable<object> objects = strings;

            Func<string> strFunc = GetString;

            Func<object> objFunc = strFunc;
        }

        private string GetString()
        {
            return "Hello";
        }

        public void ContraVarianceExample()
        {
            // Contravariance.             
            // Assume that the following method is in the class:   
            // static void SetObject(object o) { }   
            Action<object> actObject = SetObject;
            // An object that is instantiated with a less derived type argument   
            // is assigned to an object instantiated with a more derived type argument.   
            // Assignment compatibility is reversed.   
            Action<string> actString = actObject;

        }

        private void SetObject(object obj)
        {
            
        }
    }
}
