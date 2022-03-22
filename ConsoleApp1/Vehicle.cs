using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Vehicle
    {
        public string Color;
        public string Brand;
        public int Millage=20;
        public virtual  string  ShowInfo()
        {
            return ("brand :" + Brand + "     " + "Color :" + Color + "    " + "Millage :" + Millage);
        }
        public abstract double Drive();

        //// Console.WriteLine("car color enter :");
        //car.Color = Console.ReadLine();
        //        Console.WriteLine("car brand enter :");
        //        car.Brand = Console.ReadLine();
        //        Console.WriteLine("car fuelcapacity enter :");
        //        car.FuelCapacity = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("car currentfuel enter :");
        //        car.CurrentFuel = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("car fuelfor1km enter :");
        //        car.FuelFor1km = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("car millage enter :");
        //        car.Millage = Convert.ToInt32(Console.ReadLine());
        //        lench++;
    }
}
