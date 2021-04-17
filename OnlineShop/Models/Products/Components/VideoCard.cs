namespace OnlineShop.Models.Products
{
    public class VideoCard : Component
    {
        private const double Multiplier = 1.15;
        public VideoCard(double overallPerformance, decimal price, string model, string manufacturer, int id, int generation)
            : base(overallPerformance * Multiplier, price, model, manufacturer, id, generation)
        {
        }
    }
}
