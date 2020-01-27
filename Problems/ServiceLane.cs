using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Problems
{
    public class ServiceLane
    {
        // Complete the serviceLane function below.
        //public   static int[] serviceLane(int n, int[][] cases,int []width)
        public static int[] serviceLane(int[][] cases, int[] width)

        {
           // int[] result2 = new int[] { };
           List<int> result2 = new List<int>();
              int min = width.Max();
            
            for (int col = 0; col < cases.GetLength(0); col++)
            {
              //  Console.WriteLine("this is the first loop");
                for (int row = 0; row < 2; row++)
                {
                   // Console.WriteLine("this is the 2nd loop");

                }
                for (int k = cases[col][0]; k <= cases[col][1]; k++)
                    {
                   // Console.WriteLine("this is the 3rd loop");
                        if (width[k] < min)
                        {
                            min = width[k];
                        }
                    // int max = width[0];
                    //int[] subArray = new List<int>(width).GetRange(cases[col][0], cases[col][1]).ToArray();
                    //for (int k = 0;  k < subArray.Length-1;  k++)
                    //{
                    //    if (subArray[k]<max)
                    //    {
                    //        max = subArray[k];
                    //        result2.Add(max);
                    //    }
                    //}

                }
                            result2.Add(min);
                           min = int.MaxValue;
                
            }       
            return result2.ToArray();


        }

    public    static void ReadVar()
        {
           // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nt = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nt[0]);

            int t = Convert.ToInt32(nt[1]);

            int[] width = Array.ConvertAll(Console.ReadLine().Split(' '), widthTemp => Convert.ToInt32(widthTemp))
            ;

            int[][] cases = new int[t][];

            for (int i = 0; i < t; i++)
            {
                cases[i] = Array.ConvertAll(Console.ReadLine().Split(' '), casesTemp => Convert.ToInt32(casesTemp));
            }

            // int[] result = serviceLane(n, cases,width);
            int[] result = serviceLane(cases, width);


            for (int j = 0; j < result.Length; j++)
            {
                Console.WriteLine(string.Join("\n", result[j]));

            }
            //  Console.ReadLine();


            //textWriter.WriteLine(string.Join("\n", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
