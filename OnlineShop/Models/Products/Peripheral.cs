using OnlineShop.Models.Products.Peripherals;

namespace OnlineShop.Models.Products
{
    public abstract class Peripheral : Product, IPeripheral
    {
        private readonly string connectionType;

        public string ConnectionType
        {
            get 
            {
                return connectionType; 
            }
        }

        protected Peripheral(double overallPerformance, decimal price, string model, string manufacturer, int id, string connectionType)
            : base(overallPerformance, price, model, manufacturer, id)
        {
            this.connectionType = connectionType;
        }
        public override string ToString()
        {
            return base.ToString() + $"Connection Type: {ConnectionType}";
        }
    }
}
