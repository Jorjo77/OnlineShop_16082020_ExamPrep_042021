namespace OnlineShop.Models.Products
{
    public class PowerSupply : Component
    {
        private const double Multiplier = 1.05;
        public PowerSupply(double overallPerformance, decimal price, string model, string manufacturer, int id, int generation)
            : base(overallPerformance * Multiplier, price, model, manufacturer, id, generation)
        {
        }
    }
}
