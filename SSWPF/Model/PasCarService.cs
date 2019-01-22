using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SSWPF.Model
{
    class PasCarService : CarService, INotifyPropertyChanged
    {
        private bool _pasCarwheelBalancing;

        public PasCarService()
        {
            _pasCarwheelBalancing = false;           
        }

        public bool PasCarwheelBalancing
        {
            get { return _pasCarwheelBalancing; }
            set
            {
                _pasCarwheelBalancing = value;
                OnPropertyChanged("PasCarwheelBalancing");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public new void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
