using System;

namespace mis221_lab2_geekygirl3
{
    class Program
    {
       

        static void Main(string[] args)
        {
            double milesTraveled = 0.00;
            double travelTime = 0.00;
            const double GAS_PRICE= 2.96;
            double milesPerGallon = 25.00;
            double gallonsUsed = 0.00;
            

            Console.WriteLine("Please Enter Miles Traveled");
            milesTraveled = double.Parse (Console.ReadLine());
            Console.WriteLine("Please Enter Travel Time In Hours");
            travelTime = double.Parse (Console.ReadLine());
            gallonsUsed = (milesTraveled/milesPerGallon);
            double amtSpentonGas = gallonsUsed * GAS_PRICE;
            amtSpentonGas = Math.Round(amtSpentonGas, 2);
            double speed = milesTraveled/travelTime;
            speed = Math.Round(speed, 2);
            Console.WriteLine("You spent $" + amtSpentonGas.ToString("0.00") + " on gas.");
            Console.WriteLine("Your speed is " + speed + " miles per hour.");
        

            


        }
    }
}
