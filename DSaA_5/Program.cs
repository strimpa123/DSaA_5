using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaA_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] mainArray = new int[100];
            int[] genCounter = new int[100];
            int sumNum = 0;
            float avgCount = 0;
            for (int i = 0; i < mainArray.Length; i++)    // This is the loop that is reponsible for the main Array and goes through all index from 0 to 99
            {
                bool passNum = false;
                int gCount = 0;
                if (i == 0)                               // initially assigns the first index to generate a random number since it doesnt have anything to compare
                {
                    mainArray[i] = rnd.Next(1, 101);        
                    genCounter[i] = 1;                    // initially added 1 generation of random number
                }
                else
                {
                    while (!passNum)                     // this loops until the conditions are met
                    {
                        int tempNum = rnd.Next(1, 101); // This generates the random number and assignes it in a temporary variable
                        gCount++;                       // increments every time that it generates a random number

                        for (int j = 0; j < i; j++)     // This loop only goes through index 0 until [i] since it only checks the assigned index with existing elements
                        {
                            if (tempNum == mainArray[j])// if the number matches with existing element, it will break the loop and return to generating number
                                break;
                            if (j+1==i)                 // This checks if it checked all exsisting index that has an element
                            {
                                mainArray[i] = tempNum; // assigns the number that passed the check to the mainArray on the index [i]
                                genCounter[i] = gCount; //assigns the collected counter of how many times it generated a new number to the respective index of the array
                                passNum = true;
                            }
                        }
                    }
                }
                if (i % 10 == 0)
                    Console.WriteLine();
                Console.Write($"[{mainArray[i]}]\t");
            }
            foreach (int i in genCounter)           // sums all the generated counter per element
                sumNum = sumNum+i;
            avgCount = (float)sumNum / 100;         // averages the sum
            Console.WriteLine($"\nThe Avarage Generation is [{avgCount}]");
        }
    }
}
