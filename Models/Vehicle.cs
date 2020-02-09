using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalApi.Models
{
    public class Vehicle
    {
        public long Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string TypeOfCar { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }


    }
}
