using System.Data.Entity;

namespace SSWPF.Model
{
    class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("SswpfConnection")
        {
        }
        
    public DbSet<Price> Prices { get; set; }
    public DbSet<Order> Orders { get; set; }
    }
}
