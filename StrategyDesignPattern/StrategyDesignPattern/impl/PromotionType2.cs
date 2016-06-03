using StrategyDesignPattern.interfaces;
using System;

namespace StrategyDesignPattern.impl
{
    class PromotionType2 : Promotion
    {
        public void promote()
        {
            Console.Out.WriteLine("This is promotion type 2");
        }
    }
}
