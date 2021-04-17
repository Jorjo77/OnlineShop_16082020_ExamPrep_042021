using System;
using System.ComponentModel;

namespace OnlineShop.Models.Products
{
    public abstract class Component : Product, IComponent
    {
        private int generation;

        public Component(double overallPerformance, decimal price, string model, string manufacturer, int id, int generation)
            : base(overallPerformance, price, model, manufacturer, id)
        {
            this.generation = generation;
        }
        public int Generation
        {
            get 
            {
                return generation; 
            }

        }

        public ISite Site { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler Disposed;

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return base.ToString() + $"Generation: {generation}";
        }
    }
}
