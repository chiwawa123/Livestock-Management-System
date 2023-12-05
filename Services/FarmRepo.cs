using Dapper;
using LivestockMgmt.contexts;
using LivestockMgmt.Models;

namespace LivestockMgmt.Services
{
    public class FarmRepo :IFarmRepo
    {
        private readonly ApiDbContext _context;
        public FarmRepo(ApiDbContext apiDbContext) 
        {
            _context = apiDbContext;
        }

        public async Task<IEnumerable<Farm>> GetFarms(int farmer_id)
        {   
            var query = "SELECT farms.farm_id,farms.farm_name, farms.district,farmers.first_name, farms.province, farms.country, farms.farmer_id, farms.farm_description, farmers.first_name, farmers.surname, farmers.middle_name,farmers.contact_number, farmers.id_number, farmers.email, farmers.user_id FROM farms INNER JOIN farmers ON farms.farmer_id = farmers.farmer_id WHERE farms.farmer_id = @farmer_id";

            using (var conn = _context.CreateConnection())
            {
                var farms = await conn.QueryAsync<Farm>(query, new { farmer_id});

                return farms.ToList();
            }

            
        }

    
    }
}
