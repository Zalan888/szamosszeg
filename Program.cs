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

        static void Main(string[] args)
        {
        }
    }
}
