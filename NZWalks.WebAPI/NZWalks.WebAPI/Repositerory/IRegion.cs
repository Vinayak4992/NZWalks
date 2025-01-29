using NZWalks.WebAPI.Models.Domain;

namespace NZWalks.WebAPI.Repositerory
{
    public interface IRegion
    {
        public Task <IEnumerable<Region>> GetAllRegionsAsync();
    }
}
