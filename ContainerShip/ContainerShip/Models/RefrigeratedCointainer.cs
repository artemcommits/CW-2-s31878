using System;

namespace ContainerShip.Models
{
    using System;
    using System.Collections.Generic;

    public class RefrigeratedContainer : Container
    {
        public string ProductType { get; }
        public double Temperature { get; }

        private static readonly Dictionary<string, double> ProductTemperatureMap = new()
    {
        { "Bananas", 13.3 },
        { "Chocolate", 18 },
        { "Fish", 2 },
        { "Meat", -15 },
        { "Ice cream", -18 },
        { "Frozen pizza", -30 },
        { "Cheese", 7.2 },
        { "Sausages", 5 },
        { "Butter", 20.5 },
        { "Eggs", 19 }
    };

        public RefrigeratedContainer(double height, double ownWeight, double depth, double maxLoadCapacity, string productType)
            : base(height, ownWeight, depth, maxLoadCapacity)
        {
            if (!ProductTemperatureMap.ContainsKey(productType))
                throw new ArgumentException("Unknown product type!");

            ProductType = productType;
            Temperature = ProductTemperatureMap[productType];
        }

        protected override string GetContainerType() => "C";

        public override string ToString()
        {
            return base.ToString() + $" | Product: {ProductType} | Temperature: {Temperature}°C";
        }
    }

}
