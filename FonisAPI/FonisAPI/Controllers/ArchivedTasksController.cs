using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataAccessLayer.UnitiOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Domain;


namespace FonisAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArchivedTasksController : ControllerBase
    {
        private readonly FonisContext _context;
        private readonly IUnitOfWork unitOfWork;
        private IMapper mapper;

        public ArchivedTasksController(FonisContext context)
        {
            _context = context;
        }

        // GET: api/ArchivedTasks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArchivedTask>>> GetArchivedTasks()
        {
            return await _context.ArchivedTasks.ToListAsync();
        }

        // GET: api/ArchivedTasks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ArchivedTask>> GetArchivedTask(int id)
        {
            var archivedTask = await _context.ArchivedTasks.FindAsync(id);

            if (archivedTask == null)
            {
                return NotFound();
            }

            return archivedTask;
        }

        // PUT: api/ArchivedTasks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArchivedTask(int id, ArchivedTask archivedTask)
        {
            if (id != archivedTask.ArchivedTaskId)
            {
                return BadRequest();
            }

            _context.Entry(archivedTask).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArchivedTaskExists(id))
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

        // POST: api/ArchivedTasks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ArchivedTask>> PostArchivedTask(ArchivedTask archivedTask)
        {
            _context.ArchivedTasks.Add(archivedTask);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ArchivedTaskExists(archivedTask.ArchivedTaskId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetArchivedTask", new { id = archivedTask.ArchivedTaskId }, archivedTask);
        }

        // DELETE: api/ArchivedTasks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArchivedTask(int id)
        {
            var archivedTask = await _context.ArchivedTasks.FindAsync(id);
            if (archivedTask == null)
            {
                return NotFound();
            }

            _context.ArchivedTasks.Remove(archivedTask);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArchivedTaskExists(int id)
        {
            return _context.ArchivedTasks.Any(e => e.ArchivedTaskId == id);
        }
    }
}
