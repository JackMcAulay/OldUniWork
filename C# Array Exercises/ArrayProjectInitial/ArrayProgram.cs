using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProjectInitial
{
    class ArrayProgram
    {

         public void RunProgram()
        {
            //int[] intArray = { 20, 30, 40, 50, 60, 50, 40, 30, 20, 10 };     // a test integer array

            //intArray[1] = 25;
            //intArray[5] = 25;

            //int sum, product;

            //sum = intArray[1] + intArray[5] + intArray[7];

            //product = intArray[3] + intArray[6] + intArray[8];

            //Console.WriteLine($"Sum = {sum}     Product = {product}");

            //Console.WriteLine("The contents of the array are :\n");

            //for (int i = 0; i <= 9; i++)
            //{
            //    Console.WriteLine($"element {i} has value {intArray[i]}");
            //}

            //Console.WriteLine("\nThe contents of the array in reverse are :\n");

            //for (int i = 9; i >= 0; i--)
            //{
            //    Console.WriteLine($"element {i} has value {intArray[i]}");
            //}

            //bool[] boolArray = { true, false };
            //
            //boolArray[1] = true;
            //
            //for (int k = 0; k <= 1; k++)
            //{
            //    Console.WriteLine("*");
            //}

            int[] numbers = { 3, 4, 3 };

            double sum;

            sum = 0.0;

            for (int i = 0; i < numbers.Length; i++)
            {

                sum += 1 / numbers[i];
                Console.WriteLine(sum += 1 / numbers[i]);


            } // end for

            Console.WriteLine(sum);

        }  // end RunProgram()



        static void Main(string[] args)
        {

            ArrayProgram myArrayProgram = new ArrayProgram();
            myArrayProgram.RunProgram();


            Console.WriteLine("\n\n===============================");
            Console.WriteLine("ArrayProgram: Press any key to finish");
            Console.ReadKey();

        }
    }
}
