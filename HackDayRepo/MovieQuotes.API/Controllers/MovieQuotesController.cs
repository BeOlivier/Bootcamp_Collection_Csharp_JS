using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieQuotes.API;

namespace MovieQuotes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieQuotesController : ControllerBase
    {
        private readonly MovieQuotesContext _context;

        public MovieQuotesController(MovieQuotesContext context)
        {
            _context = context;
        }

        // GET: api/MovieQuotes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieQuotes>>> GetMovieQuotes()
        {
          if (_context.MovieQuotes == null)
          {
              return NotFound();
          }
            return await _context.MovieQuotes.ToListAsync();
        }

        // GET: api/MovieQuotes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MovieQuotes>> GetMovieQuotes(int id)
        {
          if (_context.MovieQuotes == null)
          {
              return NotFound();
          }
            var movieQuotes = await _context.MovieQuotes.FindAsync(id);

            if (movieQuotes == null)
            {
                return NotFound();
            }

            return movieQuotes;
        }

        // PUT: api/MovieQuotes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovieQuotes(int id, MovieQuotes movieQuotes)
        {
            if (id != movieQuotes.QuoteId)
            {
                return BadRequest();
            }

            _context.Entry(movieQuotes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieQuotesExists(id))
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

        // POST: api/MovieQuotes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MovieQuotes>> PostMovieQuotes(MovieQuotes movieQuotes)
        {
          if (_context.MovieQuotes == null)
          {
              return Problem("Entity set 'MovieQuotesContext.MovieQuotes'  is null.");
          }
            _context.MovieQuotes.Add(movieQuotes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovieQuotes", new { id = movieQuotes.QuoteId }, movieQuotes);
        }

        // DELETE: api/MovieQuotes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovieQuotes(int id)
        {
            if (_context.MovieQuotes == null)
            {
                return NotFound();
            }
            var movieQuotes = await _context.MovieQuotes.FindAsync(id);
            if (movieQuotes == null)
            {
                return NotFound();
            }

            _context.MovieQuotes.Remove(movieQuotes);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MovieQuotesExists(int id)
        {
            return (_context.MovieQuotes?.Any(e => e.QuoteId == id)).GetValueOrDefault();
        }
    }
}
