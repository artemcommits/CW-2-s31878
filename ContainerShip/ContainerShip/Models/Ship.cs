using System;
using System.Collections.Generic;

namespace ContainerShip.Models
{
    using System;
    using System.Collections.Generic;

    public class Ship
    {
        public string Name { get; }
        public double MaxSpeed { get; }
        public int MaxContainers { get; }
        public double MaxWeight { get; }
        private readonly List<Container> containers = new();

        public Ship(string name, double maxSpeed, int maxContainers, double maxWeight)
        {
            Name = name;
            MaxSpeed = maxSpeed;
            MaxContainers = maxContainers;
            MaxWeight = maxWeight;
        }

        public void LoadContainer(Container container)
        {
            double totalWeight = containers.Sum(c => c.OwnWeight + c.LoadMass);
            if (containers.Count >= MaxContainers || totalWeight + container.OwnWeight + container.LoadMass > MaxWeight)
                throw new InvalidOperationException("Vessel loading limit exceeded!");

            containers.Add(container);
        }

        public void UnloadContainer(string serialNumber)
        {
            containers.RemoveAll(c => c.SerialNumber == serialNumber);
        }

        public void DisplayContainers()
        {
            Console.WriteLine($"Ship {Name} transports:");
            foreach (var container in containers)
            {
                Console.WriteLine(container);
            }
        }
    }

}
