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
            
            int avgCount = 0;

            for (int i = 0; i < mainArray.Length; i++)
            {
                int genCount = 0;
                int tempNum;
                if (i == 0)
                    mainArray[i] = rnd.Next(1,101);
                else
                {
                    tempNum = rnd.Next(1, 101);
                    for (int j = 0; j < i; j++)
                    {
                        
                        genCount++;
                        if (tempNum == mainArray[j])
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}
