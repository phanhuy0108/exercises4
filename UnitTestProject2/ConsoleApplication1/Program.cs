using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static int Ceil(float x)
        {   
            int n = (int) x;
            if (x !=n)
            {         
                if (x > 0)
                {
                    n = n + 1;
                }
            }
            return n;
        }
        public static int Floor(float x)
        {
            int k = (int)x;
            if (x < 0)
            {
                if (k != x)
                {
                    k = k - 1;
                }

            }
            return (int)x+1;
        }
    }
}
