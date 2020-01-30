using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
   public class BonAppétit
    {
       public static void bonAppetit(List<int> bill, int k, int b)
        {
            int sum=0;
            for (int i = 0; i < bill.Count; i++)
            {
                sum += bill[i];

            }

            if (((sum-bill[k]) / 2) == b)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(b - ((sum - bill[k]) / 2));
            }

        }

      public  static void ReadVar()
        {
            string[] nk = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            bonAppetit(bill, k, b);
        }
    }


}
