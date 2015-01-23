using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random
{
    class AddCong
    {
        
        private int k;
        private int b;
        private int c;
        private int m = int.MaxValue;
        private int[] a;
        private int currentVal = 0;
        private int j;

        public AddCong(int k = -1, int b = -1, int c = -1, int m = -1, int seed = 0)
        {
            if (k > 0 && b >= 0 && c >= 0 && b != c)
            {
                this.k = k;
                this.b = b;
                this.c = c;
            }
            else
            {
                this.k = 55;
                this.b = 31;
                this.c = 55;
            }

            //populate array with a linear congruential
            a = new int[k];
            a[0] = seed;
            LinCong lingen = new LinCong();
            for (int i = 1; i < a.Length; i++)
            {
                a[i] = lingen.nextValue();
            }

            if (m > 1)
            {
                this.m = m;
            }
            // else, already initialized at member declaration
            j = 0;
        }
        public int nextValue(int maxValue = -1)
        {
            j = (j + 1) % k;

            a[j] = (a[(j + b) % k] ^ a[(j + c) % k]) % m;
            
            if (maxValue > 0)
            {
                a[j] = a[j] % maxValue;
            }
            return a[j];
        }
    }
}
