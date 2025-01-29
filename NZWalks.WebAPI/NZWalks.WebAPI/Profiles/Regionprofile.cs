using AutoMapper;

namespace NZWalks.WebAPI.Profiles
{
    public class Regionprofile:Profile
    {
        public Regionprofile()
        {
                CreateMap<Models.Domain.Region,Models.DTO.RegionDTO>().ReverseMap(); 
        }
    }
}
