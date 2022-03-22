using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bycle : Vehicle
    {
        public override double Drive()
        {
          return   Millage++;
           
        }
    }
}
