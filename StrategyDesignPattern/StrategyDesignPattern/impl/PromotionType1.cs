using System;
using StrategyDesignPattern.interfaces;

namespace StrategyDesignPattern.impl
{
    class PromotionType1 : Promotion
    {
        public void promote()
        {
            Console.Out.WriteLine("This is promotion type 1");
        }
    }
}
