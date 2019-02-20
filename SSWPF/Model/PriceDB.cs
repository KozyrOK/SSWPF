using System.ComponentModel;
using System.Linq;

namespace SSWPF.Model
{
    public class PriceDB : Price, INotifyPropertyChanged
    {
        static readonly object locker = new object();
        public int? PriceDBId { get; set; }

        public PriceDB() : base () { }

        public PriceDB(int id)
        {
            using (SSWPFContext priceContext = new SSWPFContext())
            {
                var lp = priceContext.Prices.Find(id);
                if (lp != null)
                {
                    _carBody = lp.CarBody;
                    _carWheels = lp.CarWheels;
                    _carEngine = lp.CarEngine;
                    _carBrakes = lp.CarBrakes;
                    _carUndercarriage = lp.CarUndercarriage;
                    _busSalon = lp.BusSalon;
                    _busHandsrails = lp.BusHandsrails;
                    _busUpholstery = lp.BusUpholstery;
                    _pasCarwheelBalancing = lp.PasCarwheelBalancing;
                    _truckHydraulics = lp.TruckHydraulics;
                }
            }
        }
        
        public void CurrentPrice()
        {            
            int id = LastPriceId();
            if (id > 0)
            {
                PriceDB currentPrice = new PriceDB(id);
                CarBody = currentPrice.CarBody;
                CarWheels = currentPrice.CarWheels;
                CarEngine = currentPrice.CarEngine;
                CarBrakes = currentPrice.CarBrakes;
                CarUndercarriage = currentPrice.CarUndercarriage;
                BusSalon = currentPrice.BusSalon;
                BusHandsrails = currentPrice.BusHandsrails;
                BusUpholstery = currentPrice.BusUpholstery;
                PasCarwheelBalancing = currentPrice.PasCarwheelBalancing;
                TruckHydraulics = currentPrice.TruckHydraulics;
            }            
        }

        public int LastPriceId()
        {
            //lock (locker)
            //{
                using (SSWPFContext priceContext = new SSWPFContext())
                {
                    int id = priceContext.Prices.Count();
                    return id;
                }
            //}
        }

        public void AddNewPriceDB()
        {        

            using (SSWPFContext priceContext = new SSWPFContext())
            {
                PriceDB price = new PriceDB()
                {
                    DataTimePrice = DataTimePrice,
                    CarBody = CarBody,
                    CarWheels = CarWheels,
                    CarEngine = CarEngine,
                    CarBrakes = CarBrakes,
                    CarUndercarriage = CarUndercarriage,
                    BusSalon = BusSalon,
                    BusHandsrails = BusHandsrails,
                    BusUpholstery = BusUpholstery,
                    PasCarwheelBalancing = PasCarwheelBalancing,
                    TruckHydraulics = TruckHydraulics
                };

                priceContext.Prices.Add(price);
                priceContext.SaveChanges();
            }            
        }
    }
}
