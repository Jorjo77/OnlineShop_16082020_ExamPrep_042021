namespace OnlineShop.Models.Products
{
    public class SolidStateDrive : Component
    {
        private const double Multiplier = 1.20;
        public SolidStateDrive(double overallPerformance, decimal price, string model, string manufacturer, int id, int generation) 
            : base(overallPerformance * Multiplier, price, model, manufacturer, id, generation)
        {
        }
    }
}
