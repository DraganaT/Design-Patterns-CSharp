using StrategyDesignPattern.interfaces;

namespace StrategyDesignPattern.objects
{
    abstract class Client
    {
        private string name;
        private string surname;
        private string startDate;
        private double pricePerMinute;
        public  Promotion promotion;
        public Services service;

        public Client(string name, string surname, string startDate, double pricePerMinute)
        {
            this.Name = name;
            this.Surname = surname;
            this.StartDate = startDate;
            this.PricePerMinute = pricePerMinute;

        }
        public void services()
        {
            service.services();
        }
        public void promotions()
        {
            promotion.promote();
        }
        public abstract void displayInfo();

        public string Name { get; set; }

        public string Surname { get; set; }

        public string StartDate { get; set; }

        public double PricePerMinute { get; set; }

        internal Promotion Promotion { get; set; }

        internal Services Service { get; set; }
    }
}
