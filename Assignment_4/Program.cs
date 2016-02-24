using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNum1, randomNum2 = 0;
            int[] PairOfNumbers = new int[37];
            int[] frequencyOfSum = new int[13];
            int sum = 0;
            int num = 1;
            
            //declare random class
            Random random = new Random();

            //throw two dice 36,000 times
            for (int i = 1; i <= 36000; i++)
            {

                randomNum1 = random.Next(1, 7);
                randomNum2 = random.Next(1, 7);

                //assign two number from each different dice to 'PairOfNumbers' array
                //element in array assigned from PairOfNumbers[1]
                PairOfNumbers[ (6 * (randomNum1 - 1)) + randomNum2]++;  
 
                sum = randomNum1 + randomNum2;
                
                //assign frequnency of sum to 'frequencyOfSum' array
                frequencyOfSum[sum]++;
            }

            Console.WriteLine("The frequency of Sum out of 36,000");
            Console.WriteLine();
            //display frequency of sum out of 36,000 trial
            
            for (int j = 2; j <= 12; j++)
            {
                    Console.WriteLine("         {0,4} is {1,4}",j , frequencyOfSum[j]);
            }
            
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            
            Console.WriteLine("How many times each number was rolled?");
            Console.WriteLine();
            Console.Write(" ");

            
            for (int dice2 = 1; dice2 <= 6; dice2++)
            {
                
                Console.Write("{0,5}",dice2);
               
            }
            Console.WriteLine();
            //display each number from two dice 
            for (int dice1 = 1; dice1 <= 6; dice1++)
            {
                
                Console.WriteLine("{0}{1,5}{2,5}{3,5}{4,5}{5,5}{6,5}",
                    dice1, PairOfNumbers[num], PairOfNumbers[num + 1], PairOfNumbers[num + 2],
                    PairOfNumbers[num + 3], PairOfNumbers[num + 4], PairOfNumbers[num + 5]);
                num += 6;
            }



        }
    }
}
