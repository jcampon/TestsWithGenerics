using TestsWithGenerics.Classes.Vehicles;

namespace TestsWithGenerics.Classes.Dealerships
{
    public interface ICarDealership<T> : IDealership<T> where T : ICar
    {
        bool GetFreeSpareWheel(T car);
    }

}