using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    class ViviplanTask2
    {
        public static double findPVofAnnuityDue(double PeriodicPayment, double Rate, int Periods)
        {
            double Rateper = Rate / 100;
            double result = PeriodicPayment;
            for (int i = 1; i <= Periods-1; i++)
            {
                result += (PeriodicPayment / (Math.Pow((1 + Rateper), i)));
            }
            return result;
        }
        public static double findFVofAnnuityDue(double PeriodicPayment, double Rate, int Periods)
        {
            double Rateper = Rate / 100;
            double result = 
                ((1 + Rateper) * PeriodicPayment) *
                
               ((Math.Pow(1 + Rateper, Periods) - 1) / Rateper)
               
                ;
            return result;
        }
        public static double findAnnuityDue(double PresentValue, double Rate, int Periods)
        {
            double Rateper = Rate / 100;
            double result = PresentValue*
                (Rateper / (1-Math.Pow(1+Rateper,-Periods)))
                 *
                (1/ (1+Rateper));
            return result;
        }

        public static void ReadProcess() {

            Console.WriteLine("Pleace choose the number of process you wish to calculate\n \n" +
                "#1 Present Value of Annuity Due\n" +
                "#2 Future Value of Annuity Due\n" +
                "#3 Annuity Due Payment\n");
            //int number = Convert.ToInt32(Console.ReadLine());
            int number ;
            string validation =Console.ReadLine();
            if (!int.TryParse(validation, out number)||number<1||number>3)
            { 
                Console.WriteLine("please select a valid process number");
            }
            switch (number)
            {
                case 1:ReadVarPV();
                    break;
                case 2:ReadVarFV();
                    break;
                case 3:ReadVarADP();
                    break;
            }

        }
        public static void ReadVarPV() {
            Console.WriteLine("Please enter the periodic payment");
            double PeriodicPayment=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter rate per period");
            double Rate=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the number of periods");
            int Periods=Convert.ToInt32(Console.ReadLine());

            double result= findPVofAnnuityDue(PeriodicPayment,Rate,Periods);

            Console.WriteLine($"The present Value of Annuity Due = {result} ");

        
        }
        public static void ReadVarFV()
        {
            Console.WriteLine("Please enter the periodic payment");
            double PeriodicPayment = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter rate per period");
            double Rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the number of periods");
            int Periods = Convert.ToInt32(Console.ReadLine());

            double result = findFVofAnnuityDue(PeriodicPayment, Rate, Periods);

            Console.WriteLine($"The future Value of Annuity Due = {result} ");


        }
        public static void ReadVarADP()
        {
            Console.WriteLine("Please enter the periodic payment");
            double PresentValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter rate per period");
            double Rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the number of periods");
            int Periods = Convert.ToInt32(Console.ReadLine());

            double result = findAnnuityDue(PresentValue, Rate, Periods);

            Console.WriteLine($"The Value of Annuity Due = {result} ");


        }

    }
}
