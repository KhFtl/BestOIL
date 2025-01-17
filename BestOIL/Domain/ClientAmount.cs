using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOIL.Domain
{
    public class ClientAmount
    {
        public Fuel Fuel { get; set; }
        public List<Cafee> Cafees { get; set; }
        public double TotalAmount
        {
            get
            {
                return FuelAmount + CaffeAmount;
            }
        }
        public ClientAmount()
        {
           Cafees = new List<Cafee>();
        }
        public double FuelAmount { get; set; } = 0;
        public double CaffeAmount 
        {
            get
            {
                double sum = 0;
                foreach(var item in Cafees)
                {
                    sum += item.Price * item.Count;
                }
                return sum;
            }
        }
        public void Clear()
        {
            Fuel = null;
            Cafees = null;
            FuelAmount = 0;
        }
    }
}
