using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SSWPF.Model
{
    class TruckCarCondition : CarCondition, INotifyPropertyChanged
    {
        public int _truckHydraulics;

        public TruckCarCondition()
        {
            _truckHydraulics = 100;
        }

        public int TruckHydraulics
        {
            get { return _truckHydraulics; }
            set
            {
                _truckHydraulics = value;
                OnPropertyChanged("TruckHydraulics");
            }
        }       

        public event PropertyChangedEventHandler PropertyChanged;
        public new void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public override int GetTotalCondition()
        {
            int total = 0;
            total =
            (CarBody +
            CarWheels +
            CarEngine +
            CarBrakes +
            CarUndercarriage +
            TruckHydraulics) / 6;
            return total;
        }


    }
}
