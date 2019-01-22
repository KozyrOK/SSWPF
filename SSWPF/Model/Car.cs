using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SSWPF.Model
{
    public abstract class Car : INotifyPropertyChanged
    {        
        public string _modelCar;
        public string _numberCar;         
                
        public Car()
        {
            _modelCar = "Default";
            _numberCar = "Default";           
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

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }   
                
    }
}
