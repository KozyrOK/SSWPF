using System;
using System.ComponentModel;
using System.Data.Entity;
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

        public Price() 
        {
            _dataTimePrice = DateTime.Now;
            _carBody = 100;
            _carWheels = 100;
            _carEngine = 100;
            _carBrakes = 100;
            _carUndercarriage = 100;
            _busSalon = 100;
            _busHandsrails = 300;
            _busUpholstery = 100;
            _pasCarwheelBalancing = 100;
            _truckHydraulics = 100;
        }

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

        public void GetCurrentValuePrice()
        {
            using (SSWPFContext priceContext = new SSWPFContext())
            {
                priceContext.Prices.Load();
                var lp = priceContext.Prices.Local.Last();
                if (lp != null)
                CarBody = lp.CarBody;
                CarWheels = lp.CarWheels;
                CarEngine = lp.CarEngine;
                CarBrakes = lp.CarBrakes;
                CarUndercarriage = lp.CarUndercarriage;
                BusSalon = lp.BusSalon;
                BusHandsrails = lp.BusHandsrails;
                BusUpholstery = lp.BusHandsrails;
                PasCarwheelBalancing = lp.PasCarwheelBalancing;
                TruckHydraulics = lp.TruckHydraulics;
            }
        }
        

        public void AddNewPrice()
        {
            using (SSWPFContext priceContext = new SSWPFContext())
            {
                priceContext.Prices.Add(this);                
                priceContext.SaveChanges();
            }
        }               
    }
}

