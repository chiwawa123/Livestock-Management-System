using LivestockMgmt.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using System.Collections.Generic;
using System.Data;

namespace LivestockMgmt.contexts
{
    public class ApiDbContext : IdentityDbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public ApiDbContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {

            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DevConnection");
           
        }
        public DbSet<Farmer> Farmers { get; set; }
        public DbSet<Farm> Farms { get; set; }
        public DbSet<Livestock> Livestocks { get; set; }
        public DbSet<StockDosage> StockDosages { get; set; }
        public DbSet<StockType> StockTypes { get; set; }
        public DbSet<StockState> StockStates { get; set; }
        public DbSet<StockWeight> StockWeights { get; set; }

        public IDbConnection CreateConnection() => new MySqlConnection(_connectionString);

    
    }
 
}
