using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random
{        
    enum TypeGen
    {
        eLinearCongruence,
        eAdditiveCongruence,
        eVonNeumann
    };
    class RandomGen
    {
        private TypeGen variant;
        private int seed;

        public RandomGen()
        {
            this.seed = -1;
        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="variant">which kind of random num generator</param>
        public RandomGen(TypeGen variant, int a = -1, int c = -1, int m = -1, int N = -1, int seed = 0)
        {
            this.variant = variant;
            this.seed = unchecked((int)DateTime.Now.Ticks);

            //TODO
            switch (variant)
            {
                case TypeGen.eLinearCongruence:
                    if (a>=0 && c>=0 && m>0)
                    {
                        ;
                    }
                    break;
                case TypeGen.eAdditiveCongruence:
                    break;
                case TypeGen.eVonNeumann:
                    break;
                default:
                    break;
            }
        }

        //public RandomGen(TypeGen variant, int seed)
        //{
        //    this.variant = variant;
        //    this.seed = seed;

        //    //TODO
        //    switch (variant)
        //    {
        //        case TypeGen.eLinearCongruence:
        //            break;
        //        case TypeGen.eAdditiveCongruence:
        //            break;
        //        case TypeGen.eVonNeumann:
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //public int nextValue()
        //{
        //    //TOD
        //    return 0;        
        //}

        public int nextValue(int maxValue = -1)
        {
            int next = 0;
            //TODO
            if (maxValue > 0)
            {
                return next % maxValue;
            }
            return next;
        }

        // get set members
        internal TypeGen Variant
        {
            get { return variant; }
            set { variant = value; }
        }
        public int Seed
        {
            get { return seed; }
            set { seed = value; }
        }

    }
}
