using System;
using StrategyDesignPattern.objects;
using StrategyDesignPattern.impl;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicClient basic = new BasicClient("Christina", "Nastevska", "15/05/2016", 60);
            BusinessType1Client businessType1Client = new BusinessType1Client("Mark", "Markson", "14/05/2016", 70);
            BusinessType2Client businessType2Client = new BusinessType2Client("Homer", "Simpson", "15/05/2016", 80);
            FamilyClient famulyClient = new FamilyClient("Marge", "Simpson", "14/05/2016", 100, 5);
            PremiumClient premiumClient = new PremiumClient("Bart", "Simpson", "15/05/2016", 150);

            basic.displayInfo();
            basic.set(new PromotionType1());
            basic.promotions();
            basic.services();

            Console.Out.WriteLine("\n");

           businessType1Client.displayInfo();
            businessType1Client.services();
            businessType1Client.promote();

            Console.Out.WriteLine("\n");

            premiumClient.displayInfo();
            premiumClient.promote();
            premiumClient.services();

            Console.Out.WriteLine("\n");

            famulyClient.displayInfo();
            famulyClient.promote();
            famulyClient.services();

            Console.Out.WriteLine("\n");

            businessType2Client.displayInfo();
            businessType2Client.services();
            businessType2Client.promote();
        }
    }
}
