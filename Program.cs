using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace szamosszeg
{
    internal class Program
    {
        static int[] pos = new int[10];
        static int[] neg = new int[10];
        static int counter1 = 0;
        static int counter2 = 0;
        
        static void input() {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Kérek egy számot!");
               int num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                {
                    neg[counter2] = num;
                    counter2++;
                }
                else if (num > 0)
                {
                    pos[counter1] = num;
                    counter1++;
                }
            }
        }

        static int sumpositives()
        {
            int sumpos = 0;
            foreach (int i in pos)
            {
                sumpos += i;
            }
            return sumpos;
        }

        static int sumnegatives()
        {
            int sumneg = 0;
            foreach(int i in neg)
            {
                sumneg += i;
            }
            return sumneg;
        }

        static void Main(string[] args)
        {
            input();
            Console.WriteLine("A pozitív számok összege: " + sumpositives());
            Console.WriteLine("A negatív számok összege: " + sumnegatives());
        }
    }
}
