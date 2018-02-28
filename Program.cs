using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int system;
            double kg;
            double m;
            double lb;
            double ft;



            Console.WriteLine("-----------Welcome to Body Mass Index (BMI) Calculator---------");
            Console.WriteLine("-----Press 1 to check your BMI Category on the Metric System-----");
            Console.WriteLine("----Press 2 to check your BMI Category on the Standard System----");
            system = int.Parse(Console.ReadLine());


            if (system == 1)
            {
                Console.WriteLine("Enter weight in kg:");
                kg = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter height in m:");
                m = double.Parse(Console.ReadLine());
                if (Calculation.bmi1(kg, m) <= 18.5)
                Console.WriteLine("Your BMI Category is Underweight");
                else if(Calculation.bmi1(kg, m) > 18.5 & Calculation.bmi1(kg, m) <= 24.9)
                Console.WriteLine("Your BMI Category is Normal Weight");
                else if(Calculation.bmi1(kg, m) >= 25 & Calculation.bmi1(kg, m) <= 29.9)
                Console.WriteLine("Your BMI Category is Overweight");
                else if(Calculation.bmi1(kg, m) >= 30)
                Console.WriteLine("Your BMI Category is Obesity");
            }

            if (system == 2)
            {
                Console.WriteLine("Enter weight in lb:");
                lb = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter height in ft:");
                ft = double.Parse(Console.ReadLine());
                if (Calculation.bmi2(lb, ft) <= 18.5)
                Console.WriteLine("Your BMI Category is Underweight");
                else if(Calculation.bmi2(lb, ft) > 18.5 & Calculation.bmi2(lb, ft) <= 24.9)
                Console.WriteLine("Your BMI Category is Normal Weight");
                else if(Calculation.bmi2(lb, ft) >= 25 & Calculation.bmi1(lb, ft) <= 29.9)
                Console.WriteLine("Your BMI Category is Overweight");
                else if(Calculation.bmi2(lb, ft) >= 30)
                Console.WriteLine("Your BMI Category is Obesity");
            }



            ////    //1 m = 3.28084 ft
            ////    //1 kg = 2.20462 pounds


        }

        class Calculation
        {

          public static double bmi1(double kg, double m)

        {

            return kg / Math.Pow(m, 2);
        }


        public static double bmi2(double lb, double ft)

        {

            return (lb / 2.20462) / Math.Pow((ft / 3.28084), 2);

        }


    }
}
}
