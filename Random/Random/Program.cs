using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare three different generators
            //LinCong linearCongruentialGenerator = new LinCong(a: 7, c: 0, m: 227, seed: 42);
            LinCong linearCongruentialGenerator = new LinCong();
            AddCong additiveCongruentialGenerator = new AddCong();
            VonNeumann vonNeumannGenerator = new VonNeumann();

            int times = 0;
            while (!Int32.TryParse(Console.ReadLine(), out times) || times < 2)
            {
                Console.WriteLine("try again");
            }


            Console.Write("{0,15} ", "linear");
            Console.Write("{0,15} ", "additive");
            Console.WriteLine("{0,15} ", "von Neuman");

            for(int i = 0; i <= times; i++)
            {
                Console.Write("{0,15} ", linearCongruentialGenerator.nextValue(10));
                Console.Write("{0,15} ", additiveCongruentialGenerator.nextValue(10));
                Console.WriteLine("{0,15} ", vonNeumannGenerator.nextValue());
            }

            Console.ReadKey();
        }
    }
}
