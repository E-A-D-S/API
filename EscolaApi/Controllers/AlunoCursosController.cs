using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EscolaApi.Dados;
using EscolaApi.Models;

namespace EscolaApi.Controllers
{
    [Route("api/escola/AlunoCursos")]
    [ApiController]
    public class AlunoCursosController : ControllerBase
    {
        private readonly EscolaApiContext _context;

        public AlunoCursosController(EscolaApiContext context)
        {
            _context = context;
        }

        // GET: api/AlunoCursos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AlunoCurso>>> GetAlunosCursos()
        {
            return await _context.AlunosCursos.ToListAsync();
        }

        // GET: api/AlunoCursos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AlunoCurso>> GetAlunoCurso(int id)
        {
            var alunoCurso = await _context.AlunosCursos.FindAsync(id);

            if (alunoCurso == null)
            {
                return NotFound();
            }

            return alunoCurso;
        }

        // PUT: api/AlunoCursos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlunoCurso(int id, AlunoCurso alunoCurso)
        {
            if (id != alunoCurso.AlunoId)
            {
                return BadRequest();
            }

            _context.Entry(alunoCurso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlunoCursoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/AlunoCursos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AlunoCurso>> PostAlunoCurso(AlunoCurso alunoCurso)
        {
            _context.AlunosCursos.Add(alunoCurso);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AlunoCursoExists(alunoCurso.AlunoId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAlunoCurso", new { id = alunoCurso.AlunoId }, alunoCurso);
        }

        // DELETE: api/AlunoCursos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlunoCurso(int id)
        {
            var alunoCurso = await _context.AlunosCursos.FindAsync(id);
            if (alunoCurso == null)
            {
                return NotFound();
            }

            _context.AlunosCursos.Remove(alunoCurso);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AlunoCursoExists(int id)
        {
            return _context.AlunosCursos.Any(e => e.AlunoId == id);
        }
    }
}
