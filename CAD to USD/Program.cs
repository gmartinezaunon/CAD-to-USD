using System;
// Programmer: Gonzalo Martinez Aunon
// CAD to USD converter
namespace CAD_to_USD
{
    class Program
    {
        static void Main(string[] args)
        {
            int inc_value;
            while (true)
            {
                Console.Write("Enter increment value between 5 and 25:");
                inc_value = Convert.ToInt32(Console.ReadLine());
                if (inc_value >= 5 && inc_value <= 25)
                {
                    break;
                }
               
                Console.WriteLine("Increment value must be between 5 and 25, input new value");
           
            }
            double CAD = 0, USD;
                Console.WriteLine("CAD    USD");
            Console.WriteLine("-------------");


            do
            {
                USD = CAD * 0.792367;
                Console.WriteLine(CAD + "  " + USD);

                CAD += inc_value;
            }
            while (CAD <= 200);
        }
    }
}
