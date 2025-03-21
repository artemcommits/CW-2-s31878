using System;

namespace ContainerShip.Models
{
    public class OverfillException : Exception
    {
        public OverfillException(string message) : base(message) { }
    }
}
