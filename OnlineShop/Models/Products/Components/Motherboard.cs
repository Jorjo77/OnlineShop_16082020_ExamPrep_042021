namespace OnlineShop.Models.Products
{
    public class Motherboard : Component
    {
        private const double Multiplier = 1.25;
        public Motherboard(double overallPerformance, decimal price, string model, string manufacturer, int id, int generation)
            : base(overallPerformance * Multiplier, price, model, manufacturer, id, generation)
        {
        }
    }
}
