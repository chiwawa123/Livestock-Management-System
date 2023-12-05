using LivestockMgmt.Models;

namespace LivestockMgmt.Services
{
    public interface IFarmRepo
    {
        public Task<IEnumerable<Farm>>GetFarms(int farmer_id);


    }
}
