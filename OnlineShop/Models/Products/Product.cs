using OnlineShop.Common.Constants;
using System;

namespace OnlineShop.Models.Products
{
    public abstract class Product : IProduct
    {
        private int id;
        private string manufacturer;
        private string model;
        private decimal price;
        private double overallPerformance;

        public Product(double overallPerformance, decimal price, string model, string manufacturer, int id)
        {
            OverallPerformance = overallPerformance;
            Price = price;
            Model = model;
            Manufacturer = manufacturer;
            Id = id;
        }

        public virtual double OverallPerformance
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
                overallPerformance = value;
            }
        }

        public virtual decimal Price
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
                price = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidModel);
                }
                model = value;
            }
        }

        public string Manufacturer
        {
            get 
            {
                return manufacturer;
            }
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidManufacturer);
                }
                manufacturer = value;
            }
        }


        public int Id
        {
            get 
            {
                return id;
            }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidProductId);
                }
                id = value; 
            }
        }

        public override string ToString()
        {
            return $"Overall Performance: {OverallPerformance}. Price: {Price} - {this.GetType().Name}: {Manufacturer} {Model} (Id: {Id})";
        }

    }
}
