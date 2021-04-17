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
    public abstract class Computer : Product, IComputer
    {
        private List<IComponent> components;
        private List<IPeripheral> peripherals;
        private double overallPerformance;
        private decimal price;
        public Computer(double overallPerformance, decimal price, string model, string manufacturer, int id) 
            : base(overallPerformance, price, model, manufacturer, id)
        {
            this.OverallPerformance = overallPerformance;
            this.Price = price;
            this.components = new List<IComponent>();
            this.peripherals = new List<IPeripheral>();
        }

        public IReadOnlyCollection<IComponent> Components
        {
            get
            {
                return components.AsReadOnly();
            }
        }

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
            if (components.Any(c => c.GetType().Name == component.GetType().Name))
            {
                throw new ArgumentException(string.Format
                    (ExceptionMessages.ExistingComponent, component.GetType().Name, this.GetType().Name, Id)); 
            }
            components.Add(component);
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            if (peripherals.Any(c => c.GetType().Name == peripheral.GetType().Name))
            {
                throw new ArgumentException(string.Format
                    (ExceptionMessages.ExistingComponent, peripheral.GetType().Name, this.GetType().Name, Id));
            }
            peripherals.Add(peripheral);
        }

        public IComponent RemoveComponent(string componentType)
        {
            if (components.Any(c => c.GetType().Name == componentType)||components.Count==0)
            {
                throw new ArgumentException(string.Format
                    (ExceptionMessages.NotExistingComponent, componentType, this.GetType().Name, Id));
            }
            else
            {
                var compForRemouving = components.First(c => c.GetType().Name == componentType);
                components.Remove(compForRemouving);
                return compForRemouving;
            }
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            if (peripherals.Any(c => c.GetType().Name == peripheralType) || peripherals.Count == 0)
            {
                throw new ArgumentException(string.Format
                    (ExceptionMessages.NotExistingPeripheral, peripheralType, this.GetType().Name, Id));
            }
            else
            {
                var peripForRemouving = peripherals.First(c => c.GetType().Name == peripheralType);
                peripherals.Remove(peripForRemouving);
                return peripForRemouving;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($" Components ({components.Count}):");
            foreach (var component in components)
            {
                sb.AppendLine(component.GetType().Name);
            }
            sb.AppendLine($"Peripherals ({peripherals.Count}); " +
                $"Average Overall Performance ({peripherals.Average(p => p.OverallPerformance)}):");
            foreach (var peripheral in peripherals)
            {
                sb.AppendLine(peripheral.GetType().Name);
            }

            return base.ToString() + sb.ToString().TrimEnd();
        }
    }
}
