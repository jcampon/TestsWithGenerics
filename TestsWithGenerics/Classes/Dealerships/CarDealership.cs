using TestsWithGenerics.Classes.Vehicles;

namespace TestsWithGenerics.Classes.Dealerships
{
    public class CarDealership<T> : Dealership<T>, ICarDealership<T> where T : ICar
    {
        protected int MimimumPriceForFreebies = 1000;

        public bool GetFreeSpareWheel(T car)
        {
            return car.GetPrice() > MimimumPriceForFreebies;
        }
    }

}