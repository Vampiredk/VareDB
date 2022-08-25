using Microsoft.AspNetCore.Mvc;

namespace VareDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdreController : Controller
    {
        private readonly DataContext _context;

        public OrdreController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Ordre>>> Get()
        {
            return Ok(await _context.Ordre.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<List<Ordre>>> addtype(Ordre ordre)
        {
            _context.Ordre.Add(ordre);
            await _context.SaveChangesAsync();

            return Ok(await _context.Ordre.ToListAsync());
        }
    }
}
