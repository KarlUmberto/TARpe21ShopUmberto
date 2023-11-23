using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpe21ShopUmberto.Core.Domain.Spaceship
{
    public class Spaceship
    {
        [Key]
        public Guid? Id { get; set; } // globally unique identifier
        public string Name { get; set; } // ship name
        public string Descrioption { get; set; } // ship desc
        public int[] Dimensions { get; set; } // contains an array of int, with x, y and z values
        public int PassengerCount { get; set; } // how many passangers can the ship carry
        public int CrewCount { get; set; } // how many crew members is needed to operate the ship
        public int CargoWeight { get; set; } // how much cargo is the ship able to carry
        public int MaxSpeedInVaccuum { get; set; } // maximum speed after exiting the atmosphere
        public DateTime BuildDate { get; set; } 
        public DateTime MaidenLaunch { get; set; } // the ships first voyage date
        public string Manufacturer { get; set; } // company
        public bool IsSpaceshipPreviouslyOwned { get; set; } // is the ship secomdhand or not
        public int FullTripsCount { get; set; } // how many round trips has the ship taken
        public string Type { get; set; } // bodytype, build type
        public int EnginePower { get; set; } // engine power in kilowatts
        public int FuelConsumptionPerDay { get; set; } // fuel consumed in a days worth of space travelled at max speed
        public int MaintenenceCount { get; set; }  // how many maintenence sessions have been conducted 
        public DateTime LastMaintenence { get; set; } // when was the last maintenence conducted

        // only in database

        public DateTime CreatedAt { get; set; } // when the entry was created
        public DateTime ModifiedAt { get; set; } // when was the entry modified
    }
}
