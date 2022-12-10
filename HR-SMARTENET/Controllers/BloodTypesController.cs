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
    public class BloodTypesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BloodTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BloodTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BloodType>>> GetGenders()
        {
            return await _context.bloodTypes.ToListAsync();
        }

        // GET: api/BloodTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BloodType>> GetBloodType(Guid id)
        {
            var bloodType = await _context.bloodTypes.FindAsync(id);

            if (bloodType == null)
            {
                return NotFound();
            }

            return bloodType;
        }

        // PUT: api/BloodTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBloodType(Guid id, BloodType bloodType)
        {
            if (id != bloodType.Id)
            {
                return BadRequest();
            }

            _context.Entry(bloodType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BloodTypeExists(id))
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

        // POST: api/BloodTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BloodType>> PostBloodType(BloodType bloodType)
        {
            _context.bloodTypes.Add(bloodType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBloodType", new { id = bloodType.Id }, bloodType);
        }

        // DELETE: api/BloodTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBloodType(Guid id)
        {
            var bloodType = await _context.bloodTypes.FindAsync(id);
            if (bloodType == null)
            {
                return NotFound();
            }

            _context.bloodTypes.Remove(bloodType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BloodTypeExists(Guid id)
        {
            return _context.bloodTypes.Any(e => e.Id == id);
        }
    }
}
