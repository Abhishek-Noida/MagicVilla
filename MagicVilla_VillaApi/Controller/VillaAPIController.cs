using MagicVilla_VillaApi.Data;
using MagicVilla_VillaApi.Models;
using MagicVilla_VillaApi.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaApi.Controller
{
    [Route("api/VillaAPI/[action]")]
    [ApiController]
    public class VillaAPIController :ControllerBase
    {
        [HttpGet]
        [ActionName("GetString")]
        public IEnumerable<string> Get()
        {
            return new string[] { "one", "two" };
        }

        [HttpGet]
        [ActionName("GetVillas")]
        public IEnumerable<VillaDto> GetVillas()
        {
           return VillaStore.villaList;
        }




    }
}
