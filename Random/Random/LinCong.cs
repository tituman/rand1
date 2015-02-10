using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random
{
    class LinCong
    {
        private int a;
        private int c;
        private int m;
        private long currentVal = 0;

        public LinCong(int a = -1, int c = -1, int m = -1, int seed = 1)
        {
            if (a >= 0 && c >= 0 && m > 0)
            {
                this.a = a;
                this.c = c;
                this.m = m;
                this.currentVal = seed;
            }
            else
            {
                // starting numbers from
                // http://www.cs.princeton.edu/courses/archive/spring03/cs126/assignments/cycle.html
                this.a = 11; //16807;
                this.c = 37; //0;
                this.m = 100; //int.MaxValue;
                this.currentVal = 1;
            }
            
        }
        public long nextValue(int maxValue = -1)
        {
            currentVal = (a * currentVal + c) % m;
            
            if (maxValue > 1)
            {
                currentVal = currentVal % maxValue;
            }
            return currentVal;
        }

    }
}
