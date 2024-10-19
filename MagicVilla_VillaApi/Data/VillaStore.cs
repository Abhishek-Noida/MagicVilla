using MagicVilla_VillaApi.Dto;
using System.Xml.Linq;

namespace MagicVilla_VillaApi.Data
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList= new List<VillaDto>()
            {
                new VillaDto() { Id = 1, Name = "PoolVila" },
                new VillaDto() { Id = 2,Name = "GardenVilla" }
            };
    }
}
