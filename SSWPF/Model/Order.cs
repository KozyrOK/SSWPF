using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using Telerik.Windows.Data;

namespace SSWPF.Model
{
    public class Order : INotifyPropertyChanged
    {
        public int? OrderId { get; set; }
        public DateTime _dateTimeOrder;
        public string _modelCar;
        public string _numberCar;
        public string _stateOrder;
        public decimal _costOrder;
        public decimal _orderPaid;
        public int _conditionCar;

        public Order()
        {
            OrderId = null;
            _dateTimeOrder = DateTime.Now;
            _modelCar = null;
            _numberCar = null;
            _stateOrder ="actual";
            _costOrder = 0;
            _orderPaid = 0;
            _conditionCar = 0;
        }
        
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

        public int ConditionCar
        {
            get { return _conditionCar; }
            set
            {
                _conditionCar = value;
                OnPropertyChanged("ConditionCar");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public void CostOrderSet()
        {
            Price price = new Price();
            CarCondition car = new CarCondition();
            price.GetCurrentValuePrice();            
            this.CostOrder =
                (price.CarBody / 100 * car.CarBody) +
                (price.CarWheels / 100 * car.CarWheels) +
                (price.CarEngine / 100 * car.CarEngine) +
                (price.CarBrakes / 100 * car.CarBrakes) +
                (price.CarUndercarriage / 100 * car.CarUndercarriage) +
                (price.BusHandsrails / 100 * car.BusHandsrails) +
                (price.BusUpholstery / 100 * car.BusUpholstery) +
                (price.BusSalon / 100 * car.BusSalon) +
                (price.TruckHydraulics / 100 * car.TruckHydraulics) +
                (price.PasCarwheelBalancing / 100 * car.PasCarwheelBalancing);
        }

        public void AddNewOrder()
        {
            using (var ordersContext = new SSWPFContext())
            {
                ordersContext.Orders.Add(this);
                ordersContext.SaveChanges();
            }
        }

        public Order GetLastOrder()
        {
            using (var ordersContext = new SSWPFContext())
            {
                ordersContext.Orders.Load();
                var lo = ordersContext.Orders.Local.Last();
                return lo;               
            }
        }
        
        public void EditOrderInBase()
        {
            var id = OrderId;
            using (var ordersContext = new SSWPFContext())
            {
                ordersContext.Orders.Load();
                var newOrder = ordersContext.Orders.Find(id);
                if (newOrder != null)
                {
                    OrderId = newOrder.OrderId;
                    DateTimeOrder = newOrder.DateTimeOrder;
                    ModelCar = newOrder.ModelCar;
                    NumberCar = newOrder.NumberCar;
                    StateOrder = newOrder.StateOrder;
                    CostOrder = newOrder.CostOrder;
                    OrderPaid = newOrder.OrderPaid;
                    ordersContext.SaveChanges();
                }
            }
        }

        public Order FindOrder(int id)
        {            
            using (var ordersContext = new SSWPFContext())
            {
                ordersContext.Orders.Load();                
                var or = ordersContext.Orders.Find(id);
                return or;               
            }
        }

        public static List<Order> GetActualOrders()
        {
            SSWPFContext context = new SSWPFContext();
            return context.Orders.Where(p => p.StateOrder == "actual").OrderBy(p => p.OrderId).ToList<Order>();
        }

        public static List<Order> GetDoneOrders()
        {
            SSWPFContext context = new SSWPFContext();
            return context.Orders.Where(p => p.StateOrder == "done").OrderBy(p => p.OrderId).ToList<Order>();
        }
    }
}
