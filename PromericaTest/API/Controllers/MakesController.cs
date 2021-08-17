using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Repositories;
using API.Models;

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

        [HttpPost]
        public async Task<IActionResult> InsertMake([FromBody] Make make)
        {
            if (make == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var created = await _makeRepository.InsertMake(make);

            return Created("created", created);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMake([FromBody] Make make)
        {
            if (make == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _makeRepository.UpdateMake(make);

            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMake(int id)
        {

            await _makeRepository.DeleteMake(new Make() { Id = id });

            return NoContent();
        }



    }
}
