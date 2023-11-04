using CatsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CatsAPI.Controllers
{
    [Route("api/cats")]
    [ApiController]
    public class CatsController : ControllerBase
    {
        private readonly CatDatabaseContext _context;

        public CatsController(CatDatabaseContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetCats()
        {
            return Ok(await _context.Cats.Include(a=>a.FunFacts).Include(a=>a.HealthIssues).Include(a=>a.BreedType).ToListAsync());
        }
        [HttpGet]
        [Route("{breedType}")]
        public async Task<IActionResult> GetBreed(string breedType)
        {
            return Ok(await _context.Cats.Include(a => a.FunFacts).Include(a => a.HealthIssues).Include(a => a.BreedType).Where(a => a.BreedType.BreedTypeName.Replace(" ", "-").ToLower() == breedType.ToLower()).ToListAsync());
        }
        [HttpGet]
        [Route("{breedType}/{breedName}")]
        public async Task<IActionResult> GetBreed(string breedType, string breedName)
        {
            return Ok(await _context.Cats.Include(a => a.FunFacts).Include(a => a.HealthIssues).Include(a => a.BreedType).Where(a => a.BreedType.BreedTypeName.Replace(" ", "-") == breedType).Where(a=>a.BreedName.Replace(" ", "-").ToLower() == breedName.ToLower()).ToListAsync());
        }
    }
}
