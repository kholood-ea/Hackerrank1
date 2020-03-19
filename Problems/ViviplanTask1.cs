using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    class ViviplanTask1
    {
        static int findTotalSum(int Dice1sides,int Dice2sides)
        {
            int total=0;
            for (int i = 1; i <=Dice1sides; i++)
            {
                for (int j = 1; j <= Dice2sides; j++)
                {
                    if (i+j==12)
                    {
                    Console.WriteLine($"{i} + {j} = {i+j}");
                        total++;
                    }
                }
            }
           

            return total;
        }


        public static void ReadVar() {
            Console.WriteLine("please enter the number of sides for dice 1");
            //int Dice1sides=Convert.ToInt32(Console.ReadLine());
            int Dice1sides;
            int Dice2sides;

            string x,y;
            x=Console.ReadLine();
            if (!int.TryParse(x, out Dice1sides)||Dice1sides==0)
            {
                Console.WriteLine("please type a valid integer number");
                
            }


            else
            {
                Console.WriteLine("please enter the number of sides for dice 2");
            y = Console.ReadLine();
           
              if(!int.TryParse(y,out Dice2sides) || Dice2sides == 0)
            {
                Console.WriteLine("please type a valid integer number");

            }
           
                else
            {


           // int Dice2sides=Convert.ToInt32(Console.ReadLine());
            int result= findTotalSum(Dice1sides, Dice2sides);

            if (Dice1sides > 0 && Dice2sides > 0)
            {
            Console.WriteLine($"Total number of sum that equals 12 = {result}");

            }

            }
            }



        }
    }
}
