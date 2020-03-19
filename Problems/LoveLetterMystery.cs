using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
  public  class LoveLetterMystery
    {
        // Complete the theLoveLetterMystery function below.
       public static int theLoveLetterMystery(string s)
        {
            int count = 0;
            for (int i = 0, j = s.Length-1 ; i < s.Length / 2; i++, j--)
            {  count += Math.Abs(s[i] - s[j]); }
                
            return count;
           


        }

       public static void ReadVar()
        {
           // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = theLoveLetterMystery(s);
                Console.WriteLine(result);

              //  textWriter.WriteLine(result);
            }

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
