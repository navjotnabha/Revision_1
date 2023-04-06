using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.dto;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaAPIController:ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return VillaStore.villaList;
        }
        [HttpGet("{id:int}")]
        public VillaDTO GetVilla(int id)                                            //not public IEnumerable<VillaDTO> GetVilla(int id) because we are returning single villa not list
        {
            return VillaStore.villaList.FirstOrDefault(temp => temp.Id == id);
        }

    }
}
