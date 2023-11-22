using LivestockMgmt.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LivestockMgmt.contexts
{
    public class ApiDbContext : IdentityDbContext
    {

        public ApiDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Farm> Farmers { get; set; }
        public DbSet<Farm> Farms { get; set; }
        public DbSet<Livestock> Livestocks { get; set; }
        public DbSet<StockDosage> StockDosages { get; set; }
        public DbSet<StockType> StockTypes { get; set; }
        public DbSet<StockState> StockStates { get; set; }
        public DbSet<StockWeight> StockWeights { get; set; }
    }
 
}
