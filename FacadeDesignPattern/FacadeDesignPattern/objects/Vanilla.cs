using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern.objects
{
    class Vanilla : IceCream
    {
        public void makeIceCream()
        {
            Console.Out.WriteLine("Making vanilla ice cream");
        }
    }
}
