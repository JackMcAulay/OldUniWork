using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMeanProject
{
    class ArrayMean
    {


        public void RunProgram()
        {
            int sum;
            double mean, variance, standardDeviation;

            sum = 0;
            variance = 0.0;

            int[] intArray = { 100, 101, 102, 103, 104, 105, 106, 107 };

            for (int i = 0; i <= 7; i++)
            {
                sum += intArray[i];
            }

            mean = (double) sum / 8;

            for (int i = 0; i <= 7; i++)
            {
                variance += ((intArray[i] - mean) * (intArray[i] - mean));
            }

            variance = variance / 7;

            standardDeviation = Math.Sqrt(variance);

            Console.WriteLine($"Sum :{sum}  Mean = {mean:F3}    Var = {standardDeviation:F3}");

        }


        static void Main(string[] args)
        {

            ArrayMean arrayMean = new ArrayMean();
            arrayMean.RunProgram();


            Console.WriteLine("\n\n===============================");
            Console.WriteLine("ArrayMean: Press any key to finish");
            Console.ReadKey();
        }
    }
}
