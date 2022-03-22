using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car:Vehicle
    {
        public double FuelCapacity;
        public  double CurrentFuel;
        public double FuelFor1km;
        public override  double  Drive()
        {
           if (CurrentFuel * FuelFor1km > Millage)
           {
                return Millage++;
                   return  CurrentFuel--;
               
           }
            else
            {
                return -1;
            }  
            
        }
    }
}
