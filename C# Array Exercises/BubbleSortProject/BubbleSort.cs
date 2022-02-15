using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortProject
{
    class BubbleSort
    {
        public void RunProgram()
        {

            int[] intArray = { 100, 45, 102, -1, 31, 67, 106, 2 };

            int temp, count;

            for (int i = 0; i <= 8; i++)
            {
                count = 0;
                for (int j = 0; j <= 6; j++)
                {
                    if (intArray[j] > intArray[j + 1])
                    {
                        temp = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = temp;
                        count++;
                    }
                }
                if (count == 0)
                {
                    break;
                }
            }

            WriteArray(intArray);

        }


        public void WriteArray(int[] someArray)
        {

            for (int i = 0; i < someArray.Length; i++)
            {
                Console.Write(" {0} ", someArray[i]);
            }
        }



        static void Main(string[] args)
        {

            BubbleSort arrayFind = new BubbleSort();
            arrayFind.RunProgram();


            Console.WriteLine("\n\n===============================");
            Console.WriteLine("BubbleSort: Press any key to finish");
            Console.ReadKey();
        }
    }
}
