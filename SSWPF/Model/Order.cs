using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SSWPF.Model
{   
    public class Order : INotifyPropertyChanged
    {       
        public int OrderId { get; set; }
        public DateTime dateTimeOrder;
        public string stateOrder;
        public Car orderCar;
        public Price orderPrice;
        public decimal costOrder;
        public decimal orderPaid;

        public DateTime DateTimeOrder
        {
            get { return dateTimeOrder; }
            set
            {
                dateTimeOrder = value;
                OnPropertyChanged("DateOrder");
            }
        }

        public string StateOrder
        {
            get { return stateOrder; }
            set
            {
                stateOrder = value;
                OnPropertyChanged("StateOrder");
            }
        }

        public Car OrderCar
        {
            get { return orderCar; }
            set
            {
                orderCar = value;
                OnPropertyChanged("OrderCar");
            }
        }

        public Price OrderPrice
        {
            get { return orderPrice; }
            set
            {
                orderPrice = value;
                OnPropertyChanged("OrderPrice");
            }
        }

        public decimal CostOrder
        {
            get { return costOrder; }
            set
            {
                costOrder = value;
                OnPropertyChanged("CostOrder");
            }
        }
        public decimal OrderPaid
        {
            get { return orderPaid; }
            set
            {
                orderPaid = value;
                OnPropertyChanged("OrderPaid");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public static decimal CostFixPasCar(Price price, Car currentCar)
        {
            decimal currentPrice =
                (price.CarBody / 100 * currentCar.CarBody) +
                (price.CarWheels / 100 * currentCar.CarWheels) +
                (price.CarEngine / 100 * currentCar.CarEngine) +
                (price.CarBrakes / 100 * currentCar.CarBody) +
                (price.CarUndercarriage / 100 * currentCar.CarUndercarriage) +
                (price.PasCarwheelBalancing / 100 * currentCar.PasCarwheelBalancing);
            return currentPrice;
        }
        public static decimal CostFixBus(Price price, Car currentCar)
        {
            decimal currentPrice =
                (price.CarBody / 100 * currentCar.CarBody) +
                (price.CarWheels / 100 * currentCar.CarWheels) +
                (price.CarEngine / 100 * currentCar.CarEngine) +
                (price.CarBrakes / 100 * currentCar.CarBody) +
                (price.CarUndercarriage / 100 * currentCar.CarUndercarriage) +
                (price.BusHandsrails / 100 * currentCar.BusHandsrails) +
                (price.BusUpholstery / 100 * currentCar.BusUpholstery) +
                (price.BusSalon / 100 * currentCar.BusSalon);
            return currentPrice;
        }
        public static decimal CostFixTruck(Price price, Car currentCar)
        {
            decimal currentPrice =
                (price.CarBody / 100 * currentCar.CarBody) +
                (price.CarWheels / 100 * currentCar.CarWheels) +
                (price.CarEngine / 100 * currentCar.CarEngine) +
                (price.CarBrakes / 100 * currentCar.CarBody) +
                (price.CarUndercarriage / 100 * currentCar.CarUndercarriage) +                
                (price.TruckHydraulics / 100 * currentCar.TruckHydraulics);
            return currentPrice;
        }
    }
}


