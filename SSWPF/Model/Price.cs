using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SSWPF.Model
{    
    public class Price : INotifyPropertyChanged
    {        
        public int PriceId { get; set; }
        public DateTime _dataTimePrice;
        private decimal _carBody;
        private decimal _carWheels;
        private decimal _carEngine;
        private decimal _carBrakes;
        private decimal _carUndercarriage;
        private decimal _busSalon;
        private decimal _busHandsrails;
        private decimal _busUpholstery;
        private decimal _pasCarwheelBalancing;
        private decimal _truckHydraulics;

        public DateTime DataTimePrice
        {
            get { return _dataTimePrice; }
            set
            {
                _dataTimePrice = value;
                OnPropertyChanged("DataTimePrice");
            }
        }
        public decimal CarBody
        {
            get { return _carBody; }
            set
            {
                _carBody = value;
                OnPropertyChanged("CarBody");
            }
        }
        public decimal CarWheels
        {
            get { return _carWheels; }
            set
            {
                _carWheels = value;
                OnPropertyChanged("CarWheels");
            }
        }
        public decimal CarEngine
        {
            get { return _carEngine; }
            set
            {
                _carEngine = value;
                OnPropertyChanged("CarEngine");
            }
        }
        public decimal CarBrakes
        {
            get { return _carBrakes; }
            set
            {
                _carBrakes = value;
                OnPropertyChanged("CarBrakes");
            }
        }
        public decimal CarUndercarriage
        {
            get { return _carUndercarriage; }
            set
            {
                _carUndercarriage = value;
                OnPropertyChanged("CarUndercarriage");
            }
        }
        public decimal BusSalon
        {
            get { return _busSalon; }
            set
            {
                _busSalon = value;
                OnPropertyChanged("BusSalon");
            }
        }
        public decimal BusHandsrails
        {
            get { return _busHandsrails; }
            set
            {
                _busHandsrails = value;
                OnPropertyChanged("BusHandsrails");
            }
        }
        public decimal BusUpholstery
        {
            get { return _busUpholstery; }
            set
            {
                _busUpholstery = value;
                OnPropertyChanged("BusUpholstery");
            }
        }
        public decimal PasCarwheelBalancing
        {
            get { return _pasCarwheelBalancing; }
            set
            {
                _pasCarwheelBalancing = value;
                OnPropertyChanged("PasCarwheelBalancing");
            }
        }
        public decimal TruckHydraulics
        {
            get { return _truckHydraulics; }
            set
            {
                _truckHydraulics = value;
                OnPropertyChanged("TruckHydraulics");
            }
        } 

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public Price GetCurrentValuePrice()
        {
            using (var priceContext = new ApplicationContext())
            {
                Price p = new Price();
                p = priceContext.Prices.LastOrDefault();
                if (p == null)
                InitializationDataPrice(p);
                return p;
            }
        }

        static public void AddNewPrice(Price p)
        {
            using (var priceContext = new ApplicationContext()) 
            {
                priceContext.Prices.Add(p);
                priceContext.SaveChanges();
            }            
        }

        static public void InitializationDataPrice(Price p)
        {
            p.PriceId = 1;
            p.DataTimePrice = DateTime.Now;
            p.CarBody = 0;
            p.CarWheels = 0;
            p.CarEngine = 0;
            p.CarBrakes = 0;
            p.CarUndercarriage = 0;
            p.BusSalon = 0;
            p.BusHandsrails = 0;
            p.BusUpholstery = 0;
            p.PasCarwheelBalancing = 0;
            p.TruckHydraulics = 0;
        }
    }
}
