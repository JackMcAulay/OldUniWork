using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDArrayProject
{
    class TwoDArrayExample
    {

        
        public void RunProgram()
        {
            double[,] twoDAarray  = {{10, 20, 30, 40}, {4, 3, 2, 100}, {1.5, 20.5, 3.5, 4.5}, {1, 2, 3, 4} };

            double maxValueRow;

            maxValueRow = 0.0;

            Console.WriteLine("Max for each row : ");

            for (int i = 0; i <= 3; i++)
            {
                maxValueRow = twoDAarray[i, 0];

                for (int j = 0; j <= 3; j++)
                {
                    if (twoDAarray[i,j] > maxValueRow)
                    {
                        maxValueRow = twoDAarray[i,j];
                    }
                }
                Console.WriteLine($"Row{i} :{maxValueRow}");
            }
        }


        static void Main(string[] args)
        {

            TwoDArrayExample twoDArrayExample = new TwoDArrayExample();
            twoDArrayExample.RunProgram();


            Console.WriteLine("\n\n===============================");
            Console.WriteLine("TwoDArrayExample: Press any key to finish");
            Console.ReadKey();
        }
    }
}
