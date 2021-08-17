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

        /// <summary>
        /// Retorna la lista completa de marcas de autos.
        /// </summary>
        /// <returns>Lista de marcas de autos.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllMakes()
        {
            return Ok(await _makeRepository.GetAllMakes());
        }

        /// <summary>
        /// Retorna un objeto de tipo Marca de autos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMake(int id)
        {
            return Ok(await _makeRepository.GetMake(id));
        }

        /// <summary>
        /// Crea un nuevo objeto tipo marca de autos
        /// </summary>
        /// <param name="make"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Actualiza un objeto tipo marca de autos.
        /// </summary>
        /// <param name="make"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Borra un objeto de tipo marca de autos.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMake(int id)
        {

            await _makeRepository.DeleteMake(new Make() { Id = id });

            return NoContent();
        }



    }
}
