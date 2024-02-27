using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AlunoAPI.Data;
using AlunoAPI.Models;
using AlunoAPI.Interfaces;

namespace AlunoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
        private readonly IAlunos _alunosService;

        public AlunosController(IAlunos alunosService)
        {
            _alunosService = alunosService;
        }

        // GET: api/Alunos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Aluno>>> GetAlunos()
        {
            return Ok(await _alunosService.GetAlunos());
        }

        // GET: api/Alunos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Aluno>> GetAluno(int id)
        {
            return Ok(await _alunosService.GetAlunoById(id));
        }

        //[HttpGet("Ordenado")]
        //public ActionResult<IEnumerable<Aluno>> GetAlunoOrdenado()
        //{
        //    var ordenado = _context.Alunos.OrderBy(n => n.Nome).ToList();

        //    return ordenado;
        //}

        // PUT: api/Alunos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAluno(int id, Aluno aluno)
        {
            if (id != aluno.AlunoId)
            {
                return BadRequest();
            }

            await _alunosService.PutAluno(id, aluno);

            return NoContent();
        }

        // POST: api/Alunos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Aluno>> PostAluno(Aluno aluno)
        {
            await _alunosService.PostAluno(aluno);

            return CreatedAtAction("GetAluno", new { id = aluno.AlunoId }, aluno);
        }

        // DELETE: api/Alunos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAluno(int id)
        {
            await _alunosService.DeleteAluno(id);

            return NoContent();
        }
    }
}
