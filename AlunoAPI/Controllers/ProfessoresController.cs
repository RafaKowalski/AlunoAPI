using AlunoAPI.Data;
using AlunoAPI.Interfaces;
using AlunoAPI.Models;
using AlunoAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlunoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessoresController : ControllerBase
    {
        private readonly IProfessores _professoresService;

        public ProfessoresController(IProfessores professoresService)
        {
            _professoresService = professoresService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Professor>>> GetProfessor()
        {
            return Ok(await _professoresService.GetProfessor());
        }

        [HttpPost]
        public async Task<ActionResult<Professor>> PostProfessor(Professor professor)
        {
            await _professoresService.PostProfessor(professor);

            return Ok(professor);
        }
    }
}
