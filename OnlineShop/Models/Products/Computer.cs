using OnlineShop.Common.Constants;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Computers;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Models.Products
{
    public class Computer : Product, IComputer
    {
        private List<IComponent> components;
        private List<IPeripheral> peripherals;
        private double overallPerformance;
        private decimal price;
        public Computer(double overallPerformance, decimal price, string model, string manufacturer, int id) 
            : base(overallPerformance, price, model, manufacturer, id)
        {
            components = new List<IComponent>();
            peripherals = new List<IPeripheral>();
            OverallPerformance = overallPerformance;
            Price = price;
        }

        public IReadOnlyCollection<IComponent> Components
            => components.AsReadOnly();

        public IReadOnlyCollection<IPeripheral> Peripherals 
            => peripherals.AsReadOnly();

        public override double OverallPerformance
        {
            get
            {
                return overallPerformance;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidOverallPerformance);
                }
                else if (Components.Count==0)
                {
                    overallPerformance = value;
                }
                else
                {
                    overallPerformance = components.Sum(c => c.OverallPerformance) + value;
                }
            }
        }

        public override decimal Price
        {
            get
            {
                return price;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPrice);
                }
                decimal componentsPrice = components.Sum(c => c.Price);
                decimal peripheral = peripherals.Sum(p => p.Price);
                price = componentsPrice + peripheral + value;
            }
        }
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

        public override string ToString()
        {
            //" Components ({components count}):"
            //"  {component one}"
            //"  {component two}"
            //"  {component n}"
            //" Peripherals ({peripherals count}); Average Overall Performance ({average overall performance peripherals}):"
            //"  {peripheral one}"
            //"  {peripheral two}"
            //"  {peripheral n}"
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($" Components ({components.Count}):");
            foreach (var component in components)
            {
                sb.AppendLine(component.GetType().Name);
            }

            return base.ToString() + ;
        }
    }
}
