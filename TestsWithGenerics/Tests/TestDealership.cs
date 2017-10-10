using NUnit.Framework;
using TestsWithGenerics.Classes.Dealerships;
using TestsWithGenerics.Classes.Vehicles;

namespace TestsWithGenerics.Tests
{
    [TestFixture]
    class TestsForClasses
    {
        [Test]
        public void Test_that_CarDealership_class_implements_interface_inheritance()
        {
			var carDealership = new CarDealership<ICar>();

            Assert.That(carDealership, Is.Not.TypeOf<IDealership<IVehicle>>());
			Assert.That(carDealership, Is.Not.TypeOf<IDealership<IBike>>());			
			Assert.That(carDealership, Is.Not.TypeOf<IDealership<ICar>>());	
			Assert.That(carDealership, Is.Not.TypeOf<ICarDealership<ICar>>());
			
			Assert.That(carDealership, Is.TypeOf<CarDealership<ICar>>());

			Assert.That(carDealership is ICarDealership<ICar>);
			Assert.That(carDealership is IDealership<ICar>);
        }

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

			Assert.That(carDealership2 is CarDealership<Car>);
			Assert.That(carDealership2 is Dealership<Car>);
        }
    }
}
