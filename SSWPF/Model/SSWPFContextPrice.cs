using System.Data.Entity;

namespace SSWPF.Model
{
    class SSWPFContextPrice : DbContext
    {      
    public DbSet<Price> Prices { get; set; }           
    }
}
