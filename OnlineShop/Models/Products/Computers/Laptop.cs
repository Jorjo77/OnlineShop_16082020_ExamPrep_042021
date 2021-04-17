
namespace OnlineShop.Models.Products
{
    public class Laptop : Computer
    {
        private const double BasicOveralPerformance = 10;
        public Laptop(decimal price, string model, string manufacturer, int id)
            : base(BasicOveralPerformance, price, model, manufacturer, id)
        {
        }
    }
}
