using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Problems
{
   public class NumberOfWords
    {
    public    static int camelcase(string s)
        {
            int NumberOfWords=0;
            for (int i = 0; i < s.Length; i++)
            {
                if (System.Char.IsUpper(s[i]) == true)
                {
                     NumberOfWords++;

                }
                
            }

           return NumberOfWords+1;

        }

     public static void ReadVariables()
        {

            string s = Console.ReadLine();

            int result = camelcase(s);

            Console.WriteLine(result);

          
        }
    }
}
