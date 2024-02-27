using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AlunoAPI.Data;
using AlunoAPI.Models;
using AlunoAPI.Services;
using AlunoAPI.Interfaces;

namespace AlunoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalasController : ControllerBase
    {
        private readonly ISala _salasService;

        public SalasController(ISala salaService)
        {
            _salasService = salaService;
        }

        // GET: api/Salas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sala>>> GetSala()
        {
            return Ok(await _salasService.GetSalas());
        }

        // GET: api/Salas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sala>> GetSalaById(int id)
        {
            var sala = await _salasService.GetSalaById(id);

            if (sala == null)
            {
                return NotFound();
            }

            return sala;
        }

        // POST: api/Salas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sala>> PostSala(Sala sala)
        {
            await _salasService.PostSala(sala);

            return CreatedAtAction("GetSala", new { id = sala.SalaId }, sala);
        }

        // DELETE: api/Salas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSala(int id)
        {
            await _salasService.DeleteSala(id);

            return NoContent();
        }
    }
}
