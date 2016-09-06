using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern.objects
{
    class Banana : IceCream
    {
        public void makeIceCream()
        {
            Console.Out.WriteLine("Making banana ice cream....");
        }
    }
}
