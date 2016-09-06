using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    class FacadeDemo
    {
        static void Main(string[] args)
        {
            IceCreamMaker maker = new IceCreamMaker();

            maker.makeBananaIceCream();
            maker.makeChocolateIceCream();
            maker.makeChocolateIceCream();
        }
    }
}
