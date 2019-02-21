using System.Data.Entity;

namespace SSWPF.Model
{
    class ContextInitializer : DropCreateDatabaseIfModelChanges<SSWPFContext>
    {
        protected override void Seed(SSWPFContext db)
        {
            Price price = new Price
            {               
                CarBody = 100,
                CarWheels = 100,
                CarEngine = 100,
                CarBrakes = 100,
                CarUndercarriage = 100,
                BusSalon = 100,
                BusHandsrails = 100,
                BusUpholstery = 300,
                PasCarwheelBalancing = 100,
                TruckHydraulics = 100
            };           
            
            db.Prices.Add(price);            
            db.SaveChanges();
        }
    }
}
