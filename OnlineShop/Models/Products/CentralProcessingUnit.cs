namespace OnlineShop.Models.Products
{
    public class CentralProcessingUnit : Component
    {
        private const double Multiplier = 1.25;
        public CentralProcessingUnit(double overallPerformance, decimal price, string model, string manufacturer, int id, int generation)
            : base(overallPerformance * Multiplier, price, model, manufacturer, id, generation)
        {
        }
    }
}
