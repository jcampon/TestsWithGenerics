using NUnit.Framework;
using TestsWithGenerics.Classes.Dealerships;
using TestsWithGenerics.Classes.Vehicles;

namespace TestsWithGenerics.Tests
{
    [TestFixture]
    public class TestCarDealership
    {
        [Test]
        public void Test_that_CarDealership_class_implements_type_inheritance()
        {
            var carDealership = new CarDealership<ICar>();

			Assert.That(carDealership, Is.Not.TypeOf<Dealership<IVehicle>>());
			Assert.That(carDealership, Is.Not.TypeOf<Dealership<Vehicle>>());
			Assert.That(carDealership, Is.Not.TypeOf<Dealership<ICar>>());
			Assert.That(carDealership, Is.Not.TypeOf<Dealership<Car>>());
			Assert.That(carDealership, Is.Not.TypeOf<Dealership<IBike>>());			
			Assert.That(carDealership, Is.Not.TypeOf<CarDealership<Car>>());

			Assert.That(carDealership, Is.TypeOf<CarDealership<ICar>>());

			var carDealership2 = new CarDealership<Car>();

			Assert.That(carDealership2, Is.Not.TypeOf<CarDealership<ICar>>());
			Assert.That(carDealership2, Is.TypeOf<CarDealership<Car>>());

	        var dealership = carDealership2 as CarDealership<Car>;
	        Assert.That(dealership != null);

	        var dealership1 = carDealership2 as Dealership<Car>;
	        Assert.That(dealership1 != null);
        }
    }
}
