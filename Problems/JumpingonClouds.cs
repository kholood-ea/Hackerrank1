using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class JumpingOnClouds
    {
       public static int jumpingOnClouds(int[] c, int k)
        {

            int energy = 100;
            for (int i = 0; i < c.Length; i += (k % c.Length))
            {
                if (c.Length <= i + k)
                {
                    i = 0;
                }
                else
                {

                    i = i + k;
                }

                    if (c[i] == 0)
                    {
                        Console.WriteLine($"c[{i}] = {i}");
                        energy--;
                    }
                    if (c[i] == 1)
                    {
                        energy = energy - 3;
                        Console.WriteLine($"c[{i}] = {i} ");

                    }

                }
            

            return energy;
        }

        public static void ReadVar()
        {

            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            
            int result = jumpingOnClouds(c, k);

            Console.WriteLine(result);

        }
    }
}
