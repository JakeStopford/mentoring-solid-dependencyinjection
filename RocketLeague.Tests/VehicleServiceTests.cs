using Moq;
using NUnit.Framework;
using RocketLeague.Data;

namespace RocketLeague.Tests
{
    [TestFixture]
    internal class VehicleServiceTests
    {
        [Test]
        public void GetAllVehicles_WhenOneVehicleIsAvailable()
        {
            // Arrange
            var mock = new Mock<IVehicleRepository>();
            IVehicleService vehicleService = new VehicleService();

            // Act
            var result = vehicleService.GetAllVehicles();

            // Assert

            /*
             * TODO: Modify code to use dependency injection so that assertion below passes 
             * TODO: Assert that each property of the only vehicle is as expected
             */
            Assert.That(result.Count == 1);
        }
    }
}