using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class IndexOfArrEle
    {
       public static int introTutorial(int V, int[] arr)
        {
            int i;
        for (i = 0; i < arr.Length; i++)
            {
                if (V == arr[i])
                    return i;
            }
            return i;
        }

      public  static void ReadVariables()
        {
            int V = Convert.ToInt32(Console.ReadLine());

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int result = introTutorial(V, arr);
            Console.WriteLine(result);
        }
    }
}

