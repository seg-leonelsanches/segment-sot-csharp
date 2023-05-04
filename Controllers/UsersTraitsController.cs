using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SegmentSoTCSharp.Models;

namespace SegmentSoTCSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersTraitsController : ControllerBase
    {
        private readonly SoTContext _context;

        public UsersTraitsController(SoTContext context)
        {
            _context = context;
        }

        // GET: api/UsersTraits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserTrait>>> GetUserTraits()
        {
          if (_context.UserTraits == null)
          {
              return NotFound();
          }
            return await _context.UserTraits.ToListAsync();
        }

        // GET: api/UsersTraits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserTrait>> GetUserTrait(Guid id)
        {
          if (_context.UserTraits == null)
          {
              return NotFound();
          }
            var userTrait = await _context.UserTraits.FindAsync(id);

            if (userTrait == null)
            {
                return NotFound();
            }

            return userTrait;
        }

        // PUT: api/UsersTraits/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserTrait(Guid id, UserTrait userTrait)
        {
            if (id != userTrait.UserTraitId)
            {
                return BadRequest();
            }

            _context.Entry(userTrait).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserTraitExists(id))
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

        // POST: api/UsersTraits
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserTrait>> PostUserTrait(UserTrait userTrait)
        {
          if (_context.UserTraits == null)
          {
              return Problem("Entity set 'SoTContext.UserTraits'  is null.");
          }
            _context.UserTraits.Add(userTrait);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserTrait", new { id = userTrait.UserTraitId }, userTrait);
        }

        // DELETE: api/UsersTraits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserTrait(Guid id)
        {
            if (_context.UserTraits == null)
            {
                return NotFound();
            }
            var userTrait = await _context.UserTraits.FindAsync(id);
            if (userTrait == null)
            {
                return NotFound();
            }

            _context.UserTraits.Remove(userTrait);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserTraitExists(Guid id)
        {
            return (_context.UserTraits?.Any(e => e.UserTraitId == id)).GetValueOrDefault();
        }
    }
}
