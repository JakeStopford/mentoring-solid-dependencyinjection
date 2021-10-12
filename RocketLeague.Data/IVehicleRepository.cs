using System.Collections.Generic;

namespace RocketLeague.Data
{
    public interface IVehicleRepository
    {
        List<Vehicle> GetVehicles();
    }
}
