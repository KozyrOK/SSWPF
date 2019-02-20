﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SSWPF.Model
{
    public class Price : INotifyPropertyChanged
    {        
        protected DateTime _dataTimePrice;
        protected decimal _carBody;
        protected decimal _carWheels;
        protected decimal _carEngine;
        protected decimal _carBrakes;
        protected decimal _carUndercarriage;
        protected decimal _busSalon;
        protected decimal _busHandsrails;
        protected decimal _busUpholstery;
        protected decimal _pasCarwheelBalancing;
        protected decimal _truckHydraulics;    
        
        public Price()
        {
            _dataTimePrice = DateTime.Now;
            _carBody = 0;
            _carWheels = 0;
            _carEngine = 0;
            _carBrakes = 0;
            _carUndercarriage = 0;
            _busSalon = 0;
            _busHandsrails = 0;
            _busUpholstery = 0;
            _pasCarwheelBalancing = 0;
            _truckHydraulics = 0;
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
        
    }
}

