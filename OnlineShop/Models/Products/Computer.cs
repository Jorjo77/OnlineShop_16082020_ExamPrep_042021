using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Computers;
using OnlineShop.Models.Products.Peripherals;
using System.Collections.Generic;

namespace OnlineShop.Models.Products
{
    public class Computer : Product, IComputer
    {
        private List<IComponent> components;
        private List<IPeripheral> peripherals;
        public Computer(double overallPerformance, decimal price, string model, string manufacturer, int id) 
            : base(overallPerformance, price, model, manufacturer, id)
        {
            components = new List<IComponent>();
            peripherals = new List<IPeripheral>();
        }

        public IReadOnlyCollection<IComponent> Components
            => components.AsReadOnly();

        public IReadOnlyCollection<IPeripheral> Peripherals 
            => peripherals.AsReadOnly();

        public void AddComponent(IComponent component)
        {
            throw new System.NotImplementedException();
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            throw new System.NotImplementedException();
        }

        public IComponent RemoveComponent(string componentType)
        {
            throw new System.NotImplementedException();
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            throw new System.NotImplementedException();
        }
    }
}
