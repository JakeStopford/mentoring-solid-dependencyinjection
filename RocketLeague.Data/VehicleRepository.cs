using System.Collections.Generic;

namespace RocketLeague.Data
{
    public class VehicleRepository : IVehicleRepository
    {
        public List<Vehicle> GetVehicles()
        {
            return new List<Vehicle>
            {
                new Vehicle
                {
                    Name = "Breakout",
                    Hitbox = "Breakout",
                    Description = "Breakout is a battle-car released on July 7, 2015, with the release of the game. It can be unlocked by completing matches. It is classified as \"Common\" rarity.",
                    ReleaseDate = "2015-07-07"
                },
                new Vehicle
                {
                    Name = "Merc",
                    Hitbox = "Merc",
                    Description = "Merc is a vehicle body released on July 7, 2015, with the release of the game. It is one of the three bodies already unlocked at the beginning of the game since Free to Play. It is classified as \"Common\" rarity.",
                    ReleaseDate = "2015-07-07"

                },
                new Vehicle
                {
                    Name = "Octane",
                    Hitbox = "Octane",
                    Description = "The Octane is a vehicle body released on July 7, 2015, along with the game release. It originally appeared in the Rocket League precursor Supersonic Acrobatic Rocket-Powered Battle-Cars. The Octane is classified as \"Common\" rarity.",
                    ReleaseDate = "2015-07-07"
                },
                new Vehicle
                {
                    Name = "Hotshot",
                    Hitbox = "Dominus",
                    Description = "Hotshot is a battle-car introduced on July 7, 2015 with the release of the game.",
                    ReleaseDate = "2015-07-07"
                },
                new Vehicle
                {
                    Name = "Gizmo",
                    Hitbox = "Octane",
                    Description = "Hotshot is a battle-car introduced on July 7, 2015 with the release of the game.",
                    ReleaseDate = "2015-07-07"
                },
                new Vehicle
                {
                    Name = "Backfire",
                    Hitbox = "Octane",
                    Description = "Backfire is a battle-car released on July 7, 2015, which originally appeared in Rocket League precursor Supersonic Acrobatic Rocket-Powered Battle-Cars.",
                    ReleaseDate = "2015-07-07"
                },
                new Vehicle
                {
                    Name = "X-Devil",
                    Hitbox = "Hybrid",
                    Description = "X-Devil is a battle-car released on July 7, 2015, with the release of the game. It is classified as \"Common\" rarity.",
                    ReleaseDate = "2015-07-07"
                },
                new Vehicle
                {
                    Name = "Paladin",
                    Hitbox = "Plank",
                    Description = "Paladin is a battle-car released on July 7, 2015.",
                    ReleaseDate = "2015-07-07"
                },
                new Vehicle
                {
                    Name = "Road Hog",
                    Hitbox = "Octane",
                    Description = "Road Hog is a battle-car released on July 7, 2015, with the release of the game. It is classified as \"Common\" rarity.",
                    ReleaseDate = "2015-07-07"
                },
                new Vehicle
                {
                    Name = "Venom",
                    Hitbox = "Hybrid",
                    Description = "Venom is a battle-car released on July 7, 2015, with the release of the game. It is classified as \"Common\" rarity.",
                    ReleaseDate = "2015-07-07"
                },
                new Vehicle
                {
                    Name = "Dominus",
                    Hitbox = "Hybrid",
                    Description = "The Dominus is a vehicle released on August 13, 2015,[3] which could only be obtained as DLC from the Supersonic Fury DLC Pack before it was made unlockable for free without purchase. The Dominus hitbox, used by other cars, is based off of it.",
                    ReleaseDate = "2015-08-13"
                },
            };
        }

    }
}
