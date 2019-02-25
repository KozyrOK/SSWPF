using System.Data.Entity;

namespace SSWPF.Model
{
    public class SSWPFContext : DbContext
    {
        static SSWPFContext() { Database.SetInitializer(new ContextInitializer()); }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Price> Prices { get; set; }
    }
}
