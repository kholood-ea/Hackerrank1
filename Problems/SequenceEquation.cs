using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
  public  class SequenceEquation
    {

      public  static List<int> permutationEquation(List<int> p)
        {
          

            p.Insert(0, 0);

            List<int> array = new List<int>();
            for (int i = 1; i < p.Count; i++)
            {


                for (int j = 1; j < p.Count; j++)
                {

                    if (p[p[j]]==i)
                    {
                       
                        array.Add(j);
                    }

                }




            }

            return array;

        }

    public    static void ReadVar()
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), pTemp => Convert.ToInt32(pTemp));
            List<int> p1 = p.ToList();
            IList<int> result = permutationEquation(p1);

            //int[] result = permutationEquation(p);

            Console.WriteLine(string.Join("\n", result));

           
        }
    }
}
