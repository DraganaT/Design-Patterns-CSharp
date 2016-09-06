using FacadeDesignPattern.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    class IceCreamMaker
    {
        private IceCream vanilla;
        private IceCream chocolate;
        private IceCream banana;


        public IceCreamMaker()
        {
            banana = new Banana();
            chocolate = new Chocolate();
            vanilla = new Vanilla();
        }

        public void makeVanillaIceCream()
        {
            vanilla.makeIceCream();
        }

        public void makeChocolateIceCream()
        {
            chocolate.makeIceCream();
        }

        public void makeBananaIceCream()
        {
            banana.makeIceCream();
        }


    }
}
