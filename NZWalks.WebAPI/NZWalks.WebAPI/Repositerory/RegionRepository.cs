using Microsoft.EntityFrameworkCore;
using NZWalks.WebAPI.Data;
using NZWalks.WebAPI.Models.Domain;

namespace NZWalks.WebAPI.Repositerory
{
    public class RegionRepository : IRegion
    {
        private readonly NZDbContext nZDbContext;

        public RegionRepository(NZDbContext nZDbContext)
        {
            this.nZDbContext = nZDbContext;
        }

        public async Task <IEnumerable<Region>> GetAllRegionsAsync()
        {
            return await nZDbContext.Regions.ToListAsync();
        }
    }
}
