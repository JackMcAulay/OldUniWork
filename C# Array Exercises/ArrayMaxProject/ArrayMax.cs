using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMaxProject
{
    class ArrayMax
    {

        public void RunProgram()
        {

            int[] intArray = { 10, 45, 102, -1, 31, 67, 106, 250 };

            int maxValue;

            maxValue = intArray[0];

            for (int i = 0; i <= 7; i++)
            {
                if (intArray[i] > maxValue)
                {
                    maxValue = intArray[i];
                }
            }

            Console.WriteLine($"Max Value :{maxValue}");

        }


        static void Main(string[] args)
        {

            ArrayMax arrayMax = new ArrayMax();
            arrayMax.RunProgram();


            Console.WriteLine("\n\n===============================");
            Console.WriteLine("ArrayMax: Press any key to finish");
            Console.ReadKey();
        }
    }
}
