using System;
using StrategyDesignPattern.impl;

namespace StrategyDesignPattern.objects
{
    class PremiumClient : Client
    {
        public PremiumClient(string name, string surname, string startDate, double pricePerMinute) : base(name, surname, startDate, pricePerMinute)
        {
            base.service = new ServicesType4();
            base.promotion = new PromotionType3();
        }

        public override void displayInfo()
        {
            Console.Out.WriteLine("Name is: " + this.Name + " Surname is: " + this.Surname + " Start Date: " + this.StartDate);
        }

        internal void promote()
        {
            promotion.promote();
        }
    }
}
