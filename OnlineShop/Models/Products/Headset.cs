namespace OnlineShop.Models.Products
{
    public class Headset : Peripheral
    {
        public Headset(double overallPerformance, decimal price, string model, string manufacturer, int id, string connectionType) 
            : base(overallPerformance, price, model, manufacturer, id, connectionType)
        {
        }
    }
}
