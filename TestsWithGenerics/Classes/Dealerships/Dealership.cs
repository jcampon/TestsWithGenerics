using System;
using System.Collections.Generic;
using TestsWithGenerics.Classes.Vehicles;

namespace TestsWithGenerics.Classes.Dealerships
{
    public abstract class Dealership<T> : IDealership<T> where T : IVehicle
    {
        protected List<T> ListOfVehicles = new List<T>();

        public virtual List<T> GetListOfVehicles()
        {
            return ListOfVehicles;
        }

        public virtual double GetInsuranceQuoteForVehicle(T vehicle)
        {
            throw new NotImplementedException();
        }

        public virtual string GetManufacturer()
        {
            throw new NotImplementedException();
        }

        public virtual string GetModelName()
        {
            throw new NotImplementedException();
        }
    }

    
}
