using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SSWPF.Model
{    
    public class Price : INotifyPropertyChanged
    {        
        public int PriceId { get; set; }
        private decimal carBody;
        private decimal carWheels;
        private decimal carEngine;
        private decimal carBrakes;
        private decimal carUndercarriage;
        private decimal busSalon;
        private decimal busHandsrails;
        private decimal busUpholstery;
        private decimal pasCarwheelBalancing;
        private decimal truckHydraulics; 

        public decimal СarBody
        {
            get { return carBody; }
            set
            {
                carBody = value;
                OnPropertyChanged("CarBody");
            }
        }
        public decimal CarWheels
        {
            get { return carWheels; }
            set
            {
                carWheels = value;
                OnPropertyChanged("CarWheels");
            }
        }
        public decimal CarEngine
        {
            get { return carEngine; }
            set
            {
                carEngine = value;
                OnPropertyChanged("CarEngine");
            }
        }
        public decimal CarBrakes
        {
            get { return carBrakes; }
            set
            {
                carBrakes = value;
                OnPropertyChanged("CarBrakes");
            }
        }
        public decimal CarUndercarriage
        {
            get { return carUndercarriage; }
            set
            {
                carUndercarriage = value;
                OnPropertyChanged("CarUndercarriage");
            }
        }
        public decimal BusSalon
        {
            get { return busSalon; }
            set
            {
                busSalon = value;
                OnPropertyChanged("BusSalon");
            }
        }
        public decimal BusHandsrails
        {
            get { return busHandsrails; }
            set
            {
                busHandsrails = value;
                OnPropertyChanged("BusHandsrails");
            }
        }
        public decimal BusUpholstery
        {
            get { return busUpholstery; }
            set
            {
                busUpholstery = value;
                OnPropertyChanged("BusUpholstery");
            }
        }
        public decimal PasCarwheelBalancing
        {
            get { return pasCarwheelBalancing; }
            set
            {
                pasCarwheelBalancing = value;
                OnPropertyChanged("PasCarwheelBalancing");
            }
        }
        public decimal TruckHydraulics
        {
            get { return truckHydraulics; }
            set
            {
                truckHydraulics = value;
                OnPropertyChanged("TruckHydraulics");
            }
        } 

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}