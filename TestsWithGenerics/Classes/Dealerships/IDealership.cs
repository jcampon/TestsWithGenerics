using System.Collections.Generic;
using TestsWithGenerics.Classes.Vehicles;

namespace TestsWithGenerics.Classes.Dealerships
{
    public interface IDealership<T> where T : IVehicle
    {
        List<T> GetListOfVehicles();
        double GetInsuranceQuoteForVehicle(T vehicle);
        string GetManufacturer();
        string GetModelName();
    }
}