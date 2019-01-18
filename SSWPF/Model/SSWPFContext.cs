using System.Data.Entity;

namespace SSWPF.Model
{
    class SSWPFContext : DbContext
    {        
        public DbSet<Order> Orders { get; set; }
        public DbSet<Price> Prices { get; set; }
    }
}
