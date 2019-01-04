using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SSWPF.Model
{   
    public class Order : INotifyPropertyChanged
    {       
        public int OrderId { get; set; }
        public DateTime _dateTimeOrder;
        public string _modelCar;
        public string _numberCar;
        public string _stateOrder;        
        public decimal _costOrder;
        public decimal _orderPaid;        

        public DateTime DateTimeOrder
        {
            get { return _dateTimeOrder; }
            set
            {
                _dateTimeOrder = value;
                OnPropertyChanged("DateOrder");
            }
        }
        public string ModelCar
        {
            get { return _modelCar; }
            set
            {
                _modelCar = value;
                OnPropertyChanged("ModelCar");
            }
        }

        public string NumberCar
        {
            get { return _numberCar; }
            set
            {
                _numberCar = value;
                OnPropertyChanged("NumberCar");
            }
        }

        public string StateOrder
        {
            get { return _stateOrder; }
            set
            {
                _stateOrder = value;
                OnPropertyChanged("StateOrder");
            }
        }    
                
        public decimal CostOrder
        {
            get { return _costOrder; }
            set
            {
                _costOrder = value;
                OnPropertyChanged("CostOrder");
            }
        }
        public decimal OrderPaid
        {
            get { return _orderPaid; }
            set
            {
                _orderPaid = value;
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
        public static void AddNewOrder(Order o)
        {
            using (var ordersContext = new SSWPFContextOrder())
            {
                ordersContext.Orders.Add(o);
                ordersContext.SaveChanges();
            }
        }
    }
}



