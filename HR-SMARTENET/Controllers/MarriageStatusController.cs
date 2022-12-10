using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HR_SMARTENET.Data;
using HR_SMARTENET.Models.EmploeeDetails;

namespace HR_SMARTENET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarriageStatusController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MarriageStatusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MarriageStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MarriageStatus>>> GetMarriageStatuses()
        {
            return await _context.MarriageStatuses.ToListAsync();
        }

        // GET: api/MarriageStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MarriageStatus>> GetMarriageStatus(int id)
        {
            var marriageStatus = await _context.MarriageStatuses.FindAsync(id);

            if (marriageStatus == null)
            {
                return NotFound();
            }

            return marriageStatus;
        }

        // PUT: api/MarriageStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMarriageStatus(int id, MarriageStatus marriageStatus)
        {
            if (id != marriageStatus.Id)
            {
                return BadRequest();
            }

            _context.Entry(marriageStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MarriageStatusExists(id))
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

        // POST: api/MarriageStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MarriageStatus>> PostMarriageStatus(MarriageStatus marriageStatus)
        {
            _context.MarriageStatuses.Add(marriageStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMarriageStatus", new { id = marriageStatus.Id }, marriageStatus);
        }

        // DELETE: api/MarriageStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMarriageStatus(int id)
        {
            var marriageStatus = await _context.MarriageStatuses.FindAsync(id);
            if (marriageStatus == null)
            {
                return NotFound();
            }

            _context.MarriageStatuses.Remove(marriageStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MarriageStatusExists(int id)
        {
            return _context.MarriageStatuses.Any(e => e.Id == id);
        }
    }
}
