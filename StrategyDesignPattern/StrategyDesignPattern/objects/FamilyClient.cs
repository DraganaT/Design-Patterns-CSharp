using System;
using StrategyDesignPattern.impl;

namespace StrategyDesignPattern.objects
{
    class FamilyClient : Client
    {
        private int familyMembers;

        public FamilyClient(string name, string surname, string startDate, double pricePerMinute, int familyMembers) : base(name, surname, startDate, pricePerMinute)
        {
            base.service = new ServicesType4();
            base.promotion = new PromotionType3();
            this.familyMembers = familyMembers;
        }
        public override void displayInfo()
        {
            Console.Out.WriteLine("Name is: " + this.Name + " Surname is: " + this.Surname + " Start Date: " + this.StartDate + " Family members: " + this.familyMembers);
        }

        internal void promote()
        {
            promotion.promote();
        }
    }
}
