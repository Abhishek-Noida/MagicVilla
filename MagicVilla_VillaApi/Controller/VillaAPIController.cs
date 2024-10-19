using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaApi.Controller
{
    [ApiController]
    public class VillaAPIController :ControllerBase
    {
        [HttpGet(Name ="GetVillas")]
        public IEnumerable<string> Get()
        {
            return new string[] { "one", "two" };
        }

    }
}
