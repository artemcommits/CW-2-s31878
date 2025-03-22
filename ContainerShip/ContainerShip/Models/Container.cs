using System;

namespace ContainerShip.Models
{
    using System;

    public abstract class Container
    {

        private static int counter = 1;
        public string SerialNumber { get; }
        public double LoadMass { get; set; }
        public double Height { get; }
        public double OwnWeight { get; }
        public double Depth { get; }
        public double MaxLoadCapacity { get; }

        protected Container(double height, double ownWeight, double depth, double maxLoadCapacity)
        {
            SerialNumber = $"KON-{GetContainerType()}-{counter++}";
            Height = height;
            OwnWeight = ownWeight;
            Depth = depth;
            MaxLoadCapacity = maxLoadCapacity;
            LoadMass = 0;
        }

        protected abstract string GetContainerType();



        public virtual void Load(double mass)
        {
            if (LoadMass + mass > MaxLoadCapacity)
                throw new InvalidOperationException("OverfillException: exceeded allowable capacity!");

            LoadMass += mass;
        }

        public void Unload()
        {
            LoadMass = 0;
        }



        public override string ToString()
        {
            return $"{SerialNumber} | Load: {LoadMass}/{MaxLoadCapacity} kg | Own Weight: {OwnWeight} kg";
        }
    }

}
