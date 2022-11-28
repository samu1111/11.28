using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._28
{
    class Program
    {
        static void Main(string[] args)
        {
            //    RENDEZES 
            int[] t = new int[] { 3, 4, 1, };
            for (int j = 0; j < t.Length -1; j++)
            {
                int min = j;
                for (int i = j+1; i < t.Length; i++)
                {
                    if (t[min] > t[i])
                    {
                        min = i;
                    }
                }

                int temp = t[min];
                t[min] = t[j];
                t[j] = temp;
            }
            foreach (var sz in t)
            {
                Console.Write($"{sz},");
            }


            Console.ReadKey();
        }
    }
}
