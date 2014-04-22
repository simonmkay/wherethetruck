using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Truck.Models
{
    public class FoodTruck
    {
        public int ID { get; set; }
        public string TruckName { get; set; }
        public DateTime Hours { get; set; }
        public string HotDogTypeA { get; set; }
        public string HotDogTypeB { get; set; }
        public string HotDogTypeC { get; set; }
        public decimal Price { get; set; }
    }
    public class FoodTruckContext : DbContext
    {
        public DbSet<FoodTruck> Trucks { get; set; }
    }

}