using Microsoft.AspNetCore.Mvc;

namespace VareDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KundeController : Controller
    {
        private readonly DataContext _context;

        public KundeController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Kunde>>> Get()
        {
            return Ok(await _context.Kunde.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<List<Kunde>>> addtype(Kunde kunde)
        {
            _context.Kunde.Add(kunde);
            await _context.SaveChangesAsync();

            return Ok(await _context.Kunde.ToListAsync());
        }
    }
}
