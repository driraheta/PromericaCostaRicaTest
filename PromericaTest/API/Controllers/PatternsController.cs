using API.Models;
using API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatternsController : ControllerBase
    {
        private readonly IPatternRepository _patternRepository;
        public PatternsController(IPatternRepository patternRepository)
        {
            _patternRepository = patternRepository;
        }

        /// <summary>
        /// Retorna un listado de modelos de autos.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllPatterns()
        {
            return Ok(await _patternRepository.GetAllPatterns());
        }

        /// <summary>
        /// Retorna un listado de modelos
        /// </summary>
        /// <returns></returns>
        [HttpGet("{makeId}")]
        public async Task<IActionResult> GetPatterns(int makeId)
        {
            return Ok(await _patternRepository.GetPatterns(makeId));
        }

        /// <summary>
        /// Retorna un objeto de tipo modelo autos.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("find/{id}")]
        public async Task<IActionResult> GetPattern(int id)
        {
            return Ok(await _patternRepository.GetPattern(id));
        }

        /// <summary>
        /// Elimina un objeto de tipo modelo de autos.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePattern(int id)
        {
            await _patternRepository.DeletePattern(new Pattern() { Id = id });
            return NoContent();
        }

    }
}
