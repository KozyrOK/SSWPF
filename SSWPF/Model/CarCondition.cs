

namespace SSWPF.Model
{
    class CarCondition : Car
    {
        public CarCondition()
        {            
            _carBody = 100;
            _carWheels = 100;
            _carEngine = 100;
            _carBrakes = 100;
            _carUndercarriage = 100;
            _busSalon = 100;
            _busHandsrails = 100;
            _busUpholstery = 100;
            _pasCarwheelBalancing = 100;
            _truckHydraulics = 100;
        }

        public int AverageCarCondition()
        {
            int condition =
                (CarBody +
                 CarWheels +
                 CarEngine +
                 CarBrakes +
                 CarUndercarriage +
                 BusSalon +
                 BusHandsrails +
                 BusUpholstery +
                 PasCarwheelBalancing +
                 TruckHydraulics) / 10;
            return condition;
        }
    }
}
