using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
   public class UtopianTree
    {
        // Complete the utopianTree function below.
      public  static int utopianTree(int n)
        {
            int height = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i%2==1)
                {
                    height = height * 2;
                }
                if (i%2==0)
                {
                    height++;
                }
            }
            
                
            return height;
        }
           public static void ReadVar()
            {
                //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                int t = Convert.ToInt32(Console.ReadLine());

                for (int tItr = 0; tItr < t; tItr++)
                {
                    int n = Convert.ToInt32(Console.ReadLine());

                    int result = utopianTree(n);
                Console.WriteLine(result);

                   // textWriter.WriteLine(result);
                }
                Console.ReadLine();

               // textWriter.Flush();
               // textWriter.Close();
            }
        }
}
