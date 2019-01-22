﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SSWPF.Model
{
    abstract class CarCondition : INotifyPropertyChanged
    {
        public int _carBody;
        public int _carWheels;
        public int _carEngine;
        public int _carBrakes;
        public int _carUndercarriage;

        public CarCondition()
        {            
            _carBody = 100;
            _carWheels = 100;
            _carEngine = 100;
            _carBrakes = 100;
            _carUndercarriage = 100;           
        }

        public int CarBody
        {
            get { return _carBody; }
            set
            {
                _carBody = value;
                OnPropertyChanged("CarBody");
            }
        }

        public int CarWheels
        {
            get { return _carWheels; }
            set
            {
                _carWheels = value;
                OnPropertyChanged("CarWheels");
            }
        }

        public int CarEngine
        {
            get { return _carEngine; }
            set
            {
                _carEngine = value;
                OnPropertyChanged("CarEngine");
            }
        }

        public int CarBrakes
        {
            get { return _carBrakes; }
            set
            {
                _carBrakes = value;
                OnPropertyChanged("CarBrakes");
            }
        }

        public int CarUndercarriage
        {
            get { return _carUndercarriage; }
            set
            {
                _carUndercarriage = value;
                OnPropertyChanged("CarUndercarriage");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public abstract int GetTotalCondition();
    }
}
