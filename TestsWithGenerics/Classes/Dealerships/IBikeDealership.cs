using TestsWithGenerics.Classes.Vehicles;

namespace TestsWithGenerics.Classes.Dealerships
{
    public interface IBikeDealership<T> : IDealership<T> where T : IBike
    {
        double GetFreeHelmet(T bike);
    }

}