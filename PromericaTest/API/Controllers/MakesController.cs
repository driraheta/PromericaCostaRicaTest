using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Repositories;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakesController : ControllerBase
    {
        private readonly IMakeRepository _makeRepository;

        public MakesController(IMakeRepository makeRepository)
        {
            _makeRepository = makeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMakes()
        {
            return Ok(await _makeRepository.GetAllMakes());
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetMake(int id)
        {
            return Ok(await _makeRepository.GetMake(id));
        }



    }
}
