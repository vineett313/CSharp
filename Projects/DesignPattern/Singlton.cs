using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Singlton
    {
        private static readonly object obj = new object();

        private static Singlton _instance = null;
        public static Singlton Instance
        {
            get
            {
                lock(obj)
                {
                    if(null ==_instance)
                    {
                        _instance = new Singlton();
                    }
                }
                return _instance;
            }
        }
        private Singlton()
        {

        }
    }

    public sealed class SingltonOptimized
    {
        private static readonly SingltonOptimized _SingltonOptimized = new SingltonOptimized();

        private SingltonOptimized()
        {

        }

        public static SingltonOptimized GetInstance()
        {
            return _SingltonOptimized;
        }
    }
}
