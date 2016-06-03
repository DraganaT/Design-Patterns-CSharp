using System;
using StrategyDesignPattern.interfaces;

namespace StrategyDesignPattern.impl
{
    class ServicesType2 : Services
    {
        public void services()
        {
            Console.Out.WriteLine("This is services type 2");
        }
    }
}
