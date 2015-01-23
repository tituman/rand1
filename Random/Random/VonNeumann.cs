using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random
{
    class VonNeumann
    {
        private int seqLength = 6;
        private int N;
        private long next;

        public VonNeumann(int N = 3, int seed = 1111)
        {
            if (N >= 1)
            {
                this.N = N;
            }
            else
            {
                this.N = 3;
            }
            this.next = seed;

        }

        public int nextValue()
        {
            this.next = (long)((Math.Pow(this.next, 2)) % Math.Pow(10, seqLength));

            char[] tempAll = this.next.ToString().ToCharArray();
            char[] tempNext = new char[this.N];
            Array.Copy(tempAll, (tempAll.Length / 2 - this.N / 2), tempNext, 0, this.N);

            int val = 0;
            int pow = 1;
            for (int i = 0; i < tempNext.Length; i++)
            {
                val += Int32.Parse(tempNext[i].ToString()) * pow;
                pow *= 10;
            }

            return val;
        }
    }
}
