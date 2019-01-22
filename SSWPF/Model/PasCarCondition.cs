﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SSWPF.Model
{
    class PasCarCondition : CarCondition, INotifyPropertyChanged
    {
        public int _pasCarwheelBalancing;

        public PasCarCondition()
        {            
            _pasCarwheelBalancing = 100;            
        }

        public int PasCarwheelBalancing
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

        public override int GetTotalCondition()
        {
            int total = 0;
            total =
            (CarBody +
            CarWheels +
            CarEngine +
            CarBrakes +
            CarUndercarriage) / 5;
            return total;
        }
    }
}
