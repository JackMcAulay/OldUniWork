using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFindProject
{
    class ArrayFind
    {


        public void RunProgram()
        {

            int[] intArray = { 10, 45, 102, -1, 31, 67, 106, 2 };

            int number;
            bool isThere;

            isThere = false;

            Console.WriteLine("Please enter in a number to find :");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 7; i++)
            {
                if (number == intArray[i])
                {
                    isThere = true;
                }
            }

            if (isThere)
            {
                Console.WriteLine($"The number {number} is there.");
            }
            else
            {
                Console.WriteLine($"The number {number} is not there.");
            }

        }




        static void Main(string[] args)
        {

            ArrayFind arrayFind = new ArrayFind();
            arrayFind.RunProgram();


            Console.WriteLine("\n\n===============================");
            Console.WriteLine("ArrayFind: Press any key to finish");
            Console.ReadKey();

        }
    }
}
