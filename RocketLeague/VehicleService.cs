using System.Collections.Generic;
using RocketLeague.Data;

namespace RocketLeague
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;
        
        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public List<Vehicle> GetAllVehicles()
        {
            var vehicles = _vehicleRepository.GetVehicles();
            return vehicles;
        }
    }
}
