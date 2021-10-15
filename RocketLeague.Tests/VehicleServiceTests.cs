using Moq;
using NUnit.Framework;
using RocketLeague.Data;
using System.Collections.Generic;
using System.Linq;

namespace RocketLeague.Tests
{
    [TestFixture]
    internal class VehicleServiceTests
    {
        [Test]
        public void GetAllVehicles_WhenOneVehicleIsAvailable()
        {
            // Arrange
            var mockVehicles = new List<Vehicle>
            {
                new Vehicle
                {
                    Name = "Breakout",
                    Hitbox = "Breakout",
                    Description = "Breakout is a battle-car released on July 7, 2015, with the release of the game. It can be unlocked by completing matches. It is classified as \"Common\" rarity.",
                    ReleaseDate = "2015-07-07"
                }
            };

            var vehicleRepository = new Mock<IVehicleRepository>();
            vehicleRepository.Setup(x => x.GetVehicles()).Returns(mockVehicles);
            var vehicleService = new VehicleService(vehicleRepository.Object);

            // Act
            var result = vehicleService.GetAllVehicles();

            // Assert

            /*
             * TODO: Modify code to use dependency injection so that assertion below passes 
             * TODO: Assert that each property of the only vehicle is as expected
             */
            Assert.That(result.Count == 1);
            Assert.That(result.First().Description ==
                        "Breakout is a battle-car released on July 7, 2015, with the release of the game. It can be unlocked by completing matches. It is classified as \"Common\" rarity.");
            Assert.That(result.First().Hitbox == "Breakout");
            Assert.That(result.First().ReleaseDate == "2015-07-07");
        }
    }
}