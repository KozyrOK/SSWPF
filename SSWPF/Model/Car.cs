namespace ServiceStation.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string TradeMarkCar { get; set; }
        public string ModelCar { get; set; }
        public string NumberCar { get; set; }        
        public byte CarBody { get; set; }
        public byte CarWheels { get; set; }
        public byte CarEngine { get; set; }
        public byte CarBrakes { get; set; }
        public byte CarUndercarriage { get; set; }        
        public byte BusSalon { get; set; }
        public byte BusHandsrails { get; set; }
        public byte PasCarwheelBalancing { get; set; }
        public byte TruckHydraulics { get; set; }
        
    }
}