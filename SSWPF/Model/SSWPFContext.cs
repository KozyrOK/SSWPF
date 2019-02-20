using System.Data.Entity;

namespace SSWPF.Model
{
    class SSWPFContext : DbContext
    {
        static SSWPFContext() { Database.SetInitializer<SSWPFContext>(new ContextInitializer()); }

        public DbSet<OrderDB> Orders { get; set; }
        public DbSet<PriceDB> Prices { get; set; }
    }
}
