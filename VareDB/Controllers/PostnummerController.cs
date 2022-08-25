using Microsoft.AspNetCore.Mvc;

namespace VareDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostnummerController : Controller
    {
        private readonly DataContext _context;

        public PostnummerController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Postnummer>>> Get()
        {
            return Ok(await _context.Postnummer.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<List<Postnummer>>> addtype(Postnummer postnummer)
        {
            _context.Postnummer.Add(postnummer);
            await _context.SaveChangesAsync();

            return Ok(await _context.Postnummer.ToListAsync());
        }
    }
}
