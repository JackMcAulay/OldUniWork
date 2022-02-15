using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberProject
{
    class PrimeNumber
    {
        public void RunProgram()
        {
            int upperLimit;
            bool isWholePositive;
            char done;

            done = 'y';

            while(done == 'y')
            {

                isWholePositive = false;

                Console.WriteLine("Please enter in a positive upper limit :");
                upperLimit = Convert.ToInt32(Console.ReadLine());

                while (!isWholePositive)
                {
                    if (upperLimit >= 2)
                    {
                        isWholePositive = true;
                    }
                    else
                    {
                        Console.WriteLine("The number must be positive and greater than zero, please re-enter :");
                        upperLimit = Convert.ToInt32(Console.ReadLine());
                    }
                }




                bool[] primeArray = new bool[1000];

                for (int i = 1; i <= upperLimit; i++)
                {
                    primeArray[i] = true;
                }
                for (int i = 2; i <= upperLimit; i++)
                {
                    if (primeArray[i])
                    {
                        for (int j = i + 1; j <= upperLimit; j++)
                        {
                            if ((primeArray[j]) && ((j % i) == 0))
                            {
                                primeArray[j] = false;
                            }
                        }
                    }
                }

                for (int k = 1; k <= upperLimit; k++)
                {
                    Console.WriteLine($"{k} - {primeArray[k]}");
                }

                Console.WriteLine("Would you like to enter another positive upper limit? y/n :");
                done = Convert.ToChar(Console.ReadLine());
            }
        }



        static void Main(string[] args)
        {

            PrimeNumber primeNumber = new PrimeNumber();
            primeNumber.RunProgram();


            Console.WriteLine("\n\n===============================");
            Console.WriteLine("PrimeNumber: Press any key to finish");
            Console.ReadKey();

        }
    }
}
