using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
           
            Console.WriteLine("car count enter :");
            int count=Convert.ToInt32(Console.ReadLine());
            int lench=0;
            if (count == 0)
            {
                Console.WriteLine("car yoxdur");
                return;
            }
            int []meny=new int[count];
            for (int i = 0; i < count; i++)
            {
                do
                {
                    Console.WriteLine("car color enter :");
                    car.Color = Console.ReadLine();
                    Console.WriteLine("car brand enter :");
                    car.Brand = Console.ReadLine();
                    Console.WriteLine("car fuelcapacity enter :");
                    car.FuelCapacity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("car currentfuel enter :");
                    car.CurrentFuel = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("car fuelfor1km enter :");
                    car.FuelFor1km = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("car millage enter :");
                    car.Millage = Convert.ToInt32(Console.ReadLine());
                    lench++;
                  

                } while (count == lench - 1);
            }
            if (car.FuelCapacity < car.CurrentFuel)
            {
                return;
            }
            Console.WriteLine("====================menu====================");
            Console.WriteLine("1. Masinlari millage-e gore filtirle ");
            Console.WriteLine("2. Butun masinlari goster ");
            Console.WriteLine("3. Prosesi bitir");
            Console.WriteLine("========================================");
            Console.WriteLine("eded daxil edin :");
             int count2=Convert.ToInt32(Console.ReadLine());
            switch (count2)
            {
                case 1:
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(car.Millage); 
                    }
                        break;
                    case 2:
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(car.Brand );
                    }
                    break;
                case 3:break;
                default:break;
            }
            Console.ReadLine();
        }
    }
}
