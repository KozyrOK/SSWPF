﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SSWPF.Model
{
    class BusCarCondition : CarCondition, INotifyPropertyChanged
    {
        public int _busSalon;
        public int _busHandsrails;
        public int _busUpholstery;

        public BusCarCondition()
        {
            _busSalon = 100;
            _busHandsrails = 100;
            _busUpholstery = 100;
        }

        public int BusSalon
        {
            get { return _busSalon; }
            set
            {
                _busSalon = value;
                OnPropertyChanged("BusSalon");
            }
        }

        public int BusHandsrails
        {
            get { return _busHandsrails; }
            set
            {
                _busHandsrails = value;
                OnPropertyChanged("BusHandsrails");
            }
        }
        public int BusUpholstery
        {
            get { return _busUpholstery; }
            set
            {
                _busUpholstery = value;
                OnPropertyChanged("BusUpholstery");
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
            BusSalon +
            BusHandsrails) / 7;            
            return total;
        }
    }
}
