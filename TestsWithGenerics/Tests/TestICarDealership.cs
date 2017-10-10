using NUnit.Framework;
using TestsWithGenerics.Classes.Dealerships;
using TestsWithGenerics.Classes.Vehicles;

namespace TestsWithGenerics.Tests
{
    [TestFixture]
    public class TestICarDealership
    {
        [Test]
        public void Test_that_ICarDealership_class_implements_interface_inheritance()
        {
			ICarDealership<ICar> carDealership = new CarDealership<ICar>();

            Assert.That(carDealership, Is.Not.TypeOf<IDealership<IVehicle>>());
			Assert.That(carDealership, Is.Not.TypeOf<IDealership<IBike>>());			
			Assert.That(carDealership, Is.Not.TypeOf<IDealership<ICar>>());	
			Assert.That(carDealership, Is.Not.TypeOf<ICarDealership<ICar>>());
			
			Assert.That(carDealership, Is.TypeOf<CarDealership<ICar>>());

	        var carDealershipInstance1 = carDealership as ICarDealership<ICar>;
			Assert.That(carDealershipInstance1 != null);

	        var dealership3 = carDealership as IDealership<ICar>;
	        Assert.That(dealership3 != null);

			ICarDealership<Car> carDealership2 = new CarDealership<Car>();

			Assert.That(carDealership2, Is.Not.TypeOf<ICarDealership<ICar>>());
			Assert.That(carDealership2, Is.Not.TypeOf<ICarDealership<Car>>());

	        var dealership = carDealership2 as ICarDealership<Car>;
	        Assert.That(dealership != null);

	        var dealership1 = carDealership2 as CarDealership<Car>;
	        Assert.That(dealership1 != null);

	        var dealership2 = carDealership2 as IDealership<Car>;
	        Assert.That(dealership2 != null);
        }
    }
}
