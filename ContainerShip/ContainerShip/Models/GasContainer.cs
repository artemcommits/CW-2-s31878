using System;

namespace ContainerShip.Models
{
    public class GasContainer : Container, IHazardNotifier
    {
        public double Pressure { get; }

        public GasContainer(double height, double ownWeight, double depth, double maxLoadCapacity, double pressure)
            : base(height, ownWeight, depth, maxLoadCapacity)
        {
            Pressure = pressure;
        }

        protected override string GetContainerType() => "G";

        public override void Load(double mass)
        {
            if (mass > MaxLoadCapacity)
            {
                NotifyHazard("Permissible weight for the gas container has been exceeded!");
                throw new InvalidOperationException("OverfillException: Permissible weight exceeded!");
            }
            base.Load(mass);
        }

        public new void Unload() 
        {
            LoadMass *= 0.05; 
        }

        public void NotifyHazard(string message)
        {
            Console.WriteLine($"[WARNING] Container {SerialNumber}: {message}");
        }
    }


}
