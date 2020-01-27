using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class DivisibleSumPairs
    {
       public static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int NumOfPairs = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = 0; j < ar.Length; j++)
                {
                    if (i<j)
                    {
                        if ((ar[i] + ar[j]) % k == 0)
                        {
                           // Console.WriteLine((ar[i]+ar[j])%k);

                            NumOfPairs++;
                        }
                    }

                    

                }
                // Console.WriteLine($"this is i{ar[i]+ar[i+1]}");

            }

            return NumOfPairs;
        }

        public static void ReadVar()
        {
          //  TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = divisibleSumPairs(n, k, ar);
            Console.WriteLine(result);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }


    }
}
