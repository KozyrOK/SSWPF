using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace SSWPF.Model
{
    public class OrderDB : Order, INotifyPropertyChanged
    {
        static readonly object locker = new object();
        public int? OrderDBId { get; set; }

        public OrderDB() { }

        public OrderDB(int id)
        {
            using (SSWPFContext ordersContext = new SSWPFContext())
            {
                var or = ordersContext.Orders.Find(id);
                if (or != null)
                {
                    OrderDBId = or.OrderDBId;
                    _dateTimeOrder = or.DateTimeOrder;
                    _modelCar = or.ModelCar;
                    _numberCar = or.NumberCar;
                    _stateOrder = or.StateOrder;
                    _costOrder = or.CostOrder;
                    _orderPaid = or.OrderPaid;
                    _conditionCar = or.ConditionCar;
                }
            }
        }

        public void AddNewOrderDB()
        {
            using (SSWPFContext ordersContext = new SSWPFContext())
            {
                ordersContext.Orders.Add(this);
                ordersContext.SaveChanges();
            }
        }

        public int GetLastOrderIdDB()
        {
            lock (locker)
            {
                using (SSWPFContext ordersContext = new SSWPFContext())
                {
                    int id = ordersContext.Orders.Count();
                    return id;
                }
            }
        }

        public void EditOrderDB()
        {
            lock (locker)
            {
                int? id = OrderDBId;
                using (SSWPFContext ordersContext = new SSWPFContext())
                {
                    OrderDB newOrder = ordersContext.Orders.Find(id);

                    newOrder.OrderDBId = OrderDBId;
                    newOrder.DateTimeOrder = DateTimeOrder;
                    newOrder.ModelCar = ModelCar;
                    newOrder.NumberCar = NumberCar;
                    newOrder.StateOrder = StateOrder;
                    newOrder.CostOrder = CostOrder;
                    newOrder.OrderPaid = OrderPaid;
                    newOrder.ConditionCar = ConditionCar;

                    ordersContext.SaveChanges();
                }
            }
        }        

        public List<Order> GetActualOrders()
        {
            using (var context = new SSWPFContext())
            {
                return context.Orders.Where(p => p.StateOrder == 0).OrderBy(p => p.OrderDBId).ToList<Order>();
            }
        }

        public List<Order> GetDoneOrders()
        {
            using (var context = new SSWPFContext())
            {
                return context.Orders.Where(p => p.StateOrder == (StateOrder)1).OrderBy(p => p.OrderDBId).ToList<Order>();
            }
        }
    }
}
