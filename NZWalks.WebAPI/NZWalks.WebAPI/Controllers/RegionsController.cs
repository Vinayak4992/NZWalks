using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalks.WebAPI.Models.Domain;
using NZWalks.WebAPI.Models.DTO;
using NZWalks.WebAPI.Repositerory;

namespace NZWalks.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
       
        private readonly IRegion regionRepo;
        private readonly IMapper autoMapper;

        public RegionsController(IRegion regionRepo,IMapper autoMapper)
        {
            
            this.regionRepo = regionRepo;
            this.autoMapper = autoMapper;
        }
        [HttpGet]
        public async Task< IActionResult> GetAll()
        {
            var region = await regionRepo.GetAllRegionsAsync();
            var regionDTO = autoMapper.Map<List<Models.DTO.RegionDTO>>(region);

            return Ok(regionDTO);
        }
    }
}
