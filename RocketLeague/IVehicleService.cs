using RocketLeague.Data;
using System.Collections.Generic;

namespace RocketLeague
{
    public interface IVehicleService
    {
        List<Vehicle> GetAllVehicles();
    }
}
