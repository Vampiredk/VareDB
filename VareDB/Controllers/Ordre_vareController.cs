using Microsoft.AspNetCore.Mvc;

namespace VareDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ordre_vareController : Controller
    {
        private readonly DataContext _context;

        public Ordre_vareController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Ordre_vare>>> Get()
        {
            return Ok(await _context.Ordre_vare.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<List<Kunde>>> addtype(Ordre_vare ordre_vare)
        {
            _context.Ordre_vare.Add(ordre_vare);
            await _context.SaveChangesAsync();

            return Ok(await _context.Ordre_vare.ToListAsync());
        }
    }
}
