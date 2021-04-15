namespace OnlineShop.Models.Products
{
    public class RandomAccessMemory : Component
    {
        private const double Multiplier = 1.20;
        public RandomAccessMemory(double overallPerformance, decimal price, string model, string manufacturer, int id, int generation)
            : base(overallPerformance * Multiplier, price, model, manufacturer, id, generation)
        {
        }
    }
}
