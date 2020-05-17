using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
   public class HasUniqueChars
    {
        public static void ReadVar() { 
        Console.WriteLine("please enter a word");
            string word = Console.ReadLine();
        bool result = CheckWord(word);
        Console.WriteLine(result);
      
        } 

           public static bool CheckWord(string wordd)
        {
            bool resultt = true;
            for (int i = 0; i < wordd.Length - 1; i++)
            {
                for (int j = i + 1; j < wordd.Length; j++)
                {
                    Console.WriteLine($"{ wordd[i]},{i},{wordd[j]},{j}");
                    if (wordd[i] == wordd[j])
                    {

                        resultt = false;
                    }

                }
            }
            return resultt;
        }
    }
}
