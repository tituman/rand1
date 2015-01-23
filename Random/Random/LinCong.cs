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
        private int currentVal = 0;

        public LinCong(int a = -1, int c = -1, int m = -1, int seed = 0)
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
                this.a = 16807;
                this.c = 0;
                this.m = int.MaxValue;
                this.currentVal = 42;
            }
            
        }
        public int nextValue(int maxValue = -1)
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
