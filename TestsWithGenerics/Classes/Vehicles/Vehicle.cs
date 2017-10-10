using System;

namespace TestsWithGenerics.Classes.Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        public virtual int GetPrice()
        {
            throw new NotImplementedException();
        }

        public virtual string GetManufacturerName()
        {
            throw new NotImplementedException();
        }

        public virtual int GetTopSpeed()
        {
            throw new NotImplementedException();
        }
    }

}