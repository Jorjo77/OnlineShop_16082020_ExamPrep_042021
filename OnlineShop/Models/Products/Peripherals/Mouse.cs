namespace OnlineShop.Models.Products
{
    public class Mouse : Peripheral
    {
        public Mouse(double overallPerformance, decimal price, string model, string manufacturer, int id, string connectionType) 
            : base(overallPerformance, price, model, manufacturer, id, connectionType)
        {
        }
    }
}
