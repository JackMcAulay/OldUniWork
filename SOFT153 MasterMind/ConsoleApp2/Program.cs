using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[100];

            test[0] = 1;
            test[1] = 2;
            test[2] = 3;
            test[3] = 4;


            for (int i = 0; i <= test.Length - 1; i++)
            {
                if (test[i] != 0)
                {
                    Console.Write(test[i]);
                }
            }
        }
    }
}
