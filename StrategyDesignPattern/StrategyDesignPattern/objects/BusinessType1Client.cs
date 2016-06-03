using System;
using StrategyDesignPattern.impl;
namespace StrategyDesignPattern.objects
{
    class BusinessType1Client : Client
    {
        public BusinessType1Client(string name, string surname, string startDate, double pricePerMinute) : base(name, surname, startDate, pricePerMinute)
        {
            base.service = new ServicesType1();
            base.promotion = new PromotionType1();
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
