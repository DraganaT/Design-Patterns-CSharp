using System;
using StrategyDesignPattern.impl;

namespace StrategyDesignPattern.objects
{
    class BasicClient : Client
    {
        public BasicClient(string name, string surname, string startDate, double pricePerMinute) : base(name, surname, startDate, pricePerMinute)
        {
            base.service = new ServicesType1();
        }

        public override void displayInfo()
        {
            Console.Out.WriteLine("Name is: " + this.Name + " Surname is: " + this.Surname + " Start Date: " + this.StartDate);
        }

        internal void set(PromotionType1 promotionType1)
        {
            promotion = promotionType1;
        }
    }
}
