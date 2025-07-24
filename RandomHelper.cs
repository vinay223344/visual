using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace firstlab
{
    class RandomHelper
    {
        public static int randint(int a, int b)
        {
            Random rnd = new Random();
            return rnd.Next(a, b + 1);
        }
        public static double randdouble(int  a, int b)
        {
            Random rnd = new Random();
            return rnd.NextDouble()*(b-a)+a;
        }

    }
}
