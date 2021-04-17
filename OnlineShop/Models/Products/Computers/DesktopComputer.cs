namespace OnlineShop.Models.Products
{
    public class DesktopComputer : Computer
    {
        private const double BasicOveralPerformance = 15; 
        public DesktopComputer(decimal price, string model, string manufacturer, int id)
            : base(BasicOveralPerformance, price, model, manufacturer, id)
        {
        }
    }
}
