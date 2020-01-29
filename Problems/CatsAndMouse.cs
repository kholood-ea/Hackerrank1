using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
   public class CatsAndMouse
    {
       public static string catAndMouse(int x, int y, int z)
        {
            string WhoWon="";
           
            if (Math.Abs(z-x)< Math.Abs(z - y))
            {
                WhoWon = "Cat A";
            }
            if (Math.Abs(z - x) > Math.Abs(z - y))
            {
                WhoWon = "Cat B";
            }
            if (Math.Abs(z - x) == Math.Abs(z - y))
            {
                WhoWon = "Mouse C";
            }

            return WhoWon;
        }

       public static void ReadVar()
        {
           // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);

                int y = Convert.ToInt32(xyz[1]);

                int z = Convert.ToInt32(xyz[2]);

                string result = catAndMouse(x, y, z);
                Console.WriteLine(result);

              //  textWriter.WriteLine(result);
            }

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
