using System;
using StrategyDesignPattern.interfaces;

namespace StrategyDesignPattern.impl
{
    class ServicesType1 : Services
    {
        public void services()
        {
            Console.Out.WriteLine("This is services type 1");
        }
    }
}
