using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
   public class BonAppétit
    {
       public static string bonAppetit(List<int> bill, int k, int b)
        {
            int sum=0;
            string bon = "";
            for (int i = 0; i < bill.Count; i++)
            {
                sum += bill[i];

            }

            if (((sum-bill[k]) / 2) == b)
            {
                bon = "Bon Appetit";
              //  Console.WriteLine(bon);
            }
            else
            {
                bon = (b - ((sum - bill[k]) / 2)).ToString();

                //    Console.WriteLine(b - ((sum - bill[k]) / 2));
            }
            return bon;

        }

      public  static void ReadVar()
        {
            string[] nk = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

           string bon= bonAppetit(bill, k, b);
            Console.WriteLine(bon);
        }
    }


}
