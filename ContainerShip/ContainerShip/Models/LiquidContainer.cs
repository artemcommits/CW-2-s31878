using System;

namespace ContainerShip.Models
{
    using System;

    public class LiquidContainer : Container, HazardNotifier
    {
        private readonly bool isHazardous;

        public LiquidContainer(double height, double ownWeight, double depth, double maxLoadCapacity, bool isHazardous)
            : base(height, ownWeight, depth, maxLoadCapacity)
        {
            this.isHazardous = isHazardous;
        }

        protected override string GetContainerType() => "L";

        public override void Load(double mass)
        {
            double allowedCapacity = isHazardous ? MaxLoadCapacity * 0.5 : MaxLoadCapacity * 0.9;

            if (LoadMass + mass > allowedCapacity)
            {
                NotifyHazard("Permissible load for liquid container exceeded!");
                throw new InvalidOperationException("OverfillException: permissible load exceeded!");
            }

            base.Load(mass);
        }

        public void NotifyHazard(string message)
        {
            Console.WriteLine($"[WARNING] Container {SerialNumber}: {message}");
        }
    }

}
