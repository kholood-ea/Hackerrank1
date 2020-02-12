using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class MaximizingXOR
    {
        // Complete the maximizingXor function below.
      public  static int maximizingXor(int l, int r)
        {
            List<int> xor = new List<int>();
            for (int i = l; i <= r; i++)
            {
                for (int j = i; j <= r; j++)
                {
                    xor.Add(i^j);
                   // Console.WriteLine($"{i}^{j}={i^j}");
                }
            }

            return xor.Max();
        }

       public static void ReadVar()
        {
          //  TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int l = Convert.ToInt32(Console.ReadLine());

            int r = Convert.ToInt32(Console.ReadLine());

            int result = maximizingXor(l, r);
            Console.WriteLine(result);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
