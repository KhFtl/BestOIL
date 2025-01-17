using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOIL.Domain
{
    public static class Helpers
    {
        public static List<Fuel> GetFuels()
        {
            List<Fuel> Fuels = new List<Fuel>();
            Fuels.Add(new Fuel { Name = "A-92", Price = 55.55 });
            Fuels.Add(new Fuel { Name = "A-95", Price = 58.35 });
            Fuels.Add(new Fuel { Name = "A-100 Super", Price = 62.85 });
            Fuels.Add(new Fuel { Name = "A-110 Super Race", Price = 72.55 });
            Fuels.Add(new Fuel { Name = "ДП", Price = 58.15 });
            Fuels.Add(new Fuel { Name = "LPG", Price = 36.50 });
            return Fuels;
        }
        public static double? GetFuelPrice(string nameFuel)
        {
            List<Fuel> Fuels = GetFuels();
            foreach (var item in Fuels)
            {
                if (item.Name == nameFuel) return item.Price;
            }
            return null;
        }

        public static List<Cafee> GetCafees()
        {
            List<Cafee> Cafees = new List<Cafee>();
            Cafees.Add(new Cafee { Name = "Гамбургер", Price = 75.50 });
            Cafees.Add(new Cafee { Name = "Картопля-фрі", Price = 45.50 });
            Cafees.Add(new Cafee { Name = "Coca-cola", Price = 10.50 });
            Cafees.Add(new Cafee { Name = "Хот-дог", Price = 85.50 });
            return Cafees;
        }
        public static double? GetCafeePrice(string nameCafee)
        {
            List<Cafee> Cafees = GetCafees();
            foreach (var item in Cafees)
            {
                if (item.Name == nameCafee) return item.Price;
            }
            return null;
        }
    }
}

