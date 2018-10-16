using System;
using System.Collections.Generic;

namespace ServiceStation.Models
{    
    public class Order
    {
        public int OrderId { get; set; }
        public byte StateOrder { get; set; }
        public decimal CostOrder { get; set; }
        public decimal OrderPaid { get; set; }
        public DateTime DateOrder { get; set; }

        public decimal CostFixCar(Price price, Car currentCar)
        {
            decimal currentPrice =
                (price.CarBody / 100 * currentCar.CarBody) +
                (price.CarWheels / 100 * currentCar.CarWheels) +
                (price.CarEngine / 100 * currentCar.CarEngine) +
                (price.CarBrakes / 100 * currentCar.CarBody) +
                (price.CarUndercarriage / 100 * currentCar.CarUndercarriage) +
                (price.BusHandsrails / 100 * currentCar.BusHandsrails) +
                (price.PasCarwheelBalancing / 100 * currentCar.PasCarwheelBalancing) +
                (price.TruckHydraulics / 100 * currentCar.TruckHydraulics);
            return currentPrice;
        }
    }
}

