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
            for (int i = 0; i < mainArray.Length; i++)
            {
                bool passNum = false;
                int gCount = 0;
                if (i == 0)
                {
                    mainArray[i] = rnd.Next(1, 101);
                    genCounter[i] = 1;
                }
                else
                {
                    while (!passNum)
                    {
                        int tempNum = rnd.Next(1, 101);
                        gCount++;

                        for (int j = 0; j < i; j++)
                        {
                            if (tempNum == mainArray[j])
                                break;
                            if (j+1==i)
                            {
                                mainArray[i] = tempNum;
                                genCounter[i] = gCount;
                                passNum = true;
                            }
                        }
                    }
                }
                if (i % 10 == 0)
                    Console.WriteLine();
                Console.Write($"[{mainArray[i]}]\t");
            }
            foreach (int i in genCounter)
                sumNum = sumNum+i;
            avgCount = (float)sumNum / 100;
            Console.WriteLine($"\nThe Avarage Generation is [{avgCount}]");
        }
    }
}
