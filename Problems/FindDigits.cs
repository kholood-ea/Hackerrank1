using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
  public class FindDigits
    {
        // Complete the findDigits function below.
       public static int findDigits(int n)
        {
            int result = 0;
           int[] arr = { };
            for (int i = 0; i < n.ToString().Length; i++)
            {
                 arr = n.ToString().Select(t => int.Parse(t.ToString())).ToArray();

                if (arr[i]!=0 &&n%arr[i]==0)
                {
                    result++;

                }
            }
            return result;
        }

     public  static void ReadVar()
        {
          //  TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = findDigits(n);
                Console.WriteLine(result);

            //    textWriter.WriteLine(result);
            }
            Console.ReadLine();

         //   textWriter.Flush();
         //   textWriter.Close();
        }
    }
}
