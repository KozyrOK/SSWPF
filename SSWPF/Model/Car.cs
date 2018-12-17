using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SSWPF.Model
{
    public class Car : INotifyPropertyChanged
    {        
        public string modelCar;
        public string numberCar;         
        public byte carBody;
        public byte carWheels;
        public byte carEngine; 
        public byte carBrakes;
        public byte carUndercarriage;         
        public byte busSalon; 
        public byte busHandsrails; 
        public byte busUpholstery; 
        public byte pasCarwheelBalancing;
        public byte truckHydraulics; 

        public string ModelCar
        {
            get { return modelCar; }
            set
            {
                modelCar = value;
                OnPropertyChanged("ModelCar");
            }
        }
        public string NumberCar
        {
            get { return numberCar; }
            set
            {
                numberCar = value;
                OnPropertyChanged("NumberCar");
            }
        }
        public byte CarBody
        {
            get { return carBody; }
            set
            {
                carBody = value;
                OnPropertyChanged("CarBody");
            }
        }
        public byte CarWheels
        {
            get { return carWheels; }
            set
            {
                carWheels = value;
                OnPropertyChanged("CarWheels");
            }
        }
        public byte CarEngine
        {
            get { return carEngine; }
            set
            {
                carEngine = value;
                OnPropertyChanged("CarEngine");
            }
        }
        public byte CarBrakes
        {
            get { return carBrakes; }
            set
            {
                carBrakes = value;
                OnPropertyChanged("CarBrakes");
            }
        }
        public byte CarUndercarriage
        {
            get { return carUndercarriage; }
            set
            {
                carUndercarriage = value;
                OnPropertyChanged("CarUndercarriage");
            }
        }
        public byte BusSalon
        {
            get { return busSalon; }
            set
            {
                busSalon = value;
                OnPropertyChanged("BusSalon");
            }
        }
        public byte BusHandsrails
        {
            get { return busHandsrails; }
            set
            {
                busHandsrails = value;
                OnPropertyChanged("BusHandsrails");
            }
        }
        public byte BusUpholstery
        {
            get { return busUpholstery; }
            set
            {
                busUpholstery = value;
                OnPropertyChanged("BusUpholstery");
            }
        }
        public byte PasCarwheelBalancing
        {
            get { return pasCarwheelBalancing; }
            set
            {
                pasCarwheelBalancing = value;
                OnPropertyChanged("PasCarwheelBalancing");
            }
        }
        public byte TruckHydraulics
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
