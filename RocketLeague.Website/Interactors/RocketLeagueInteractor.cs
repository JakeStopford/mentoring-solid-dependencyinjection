using RocketLeague.Website.Mappers;
using RocketLeague.Website.ViewModels;

namespace RocketLeague.Website.Interactors
{
    public class RocketLeagueInteractor : IRocketLeagueInteractor
    {
        private readonly IVehicleService _vehicleService;

        public RocketLeagueInteractor(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        public RocketLeagueViewModel GetViewModel()
        {
            var vehicles = _vehicleService.GetAllVehicles();
            return new RocketLeagueViewModel
            {
                Vehicles = VehicleMapper.Map(vehicles)
            };
        }
    }
}
