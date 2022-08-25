using Microsoft.AspNetCore.Mvc;

namespace VareDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class vare_typeController : Controller
    {

        private readonly DataContext _context;

        public vare_typeController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<vare_type>>> Get()
        {
            return Ok(await _context.vare_Type.ToListAsync());
        }

        [HttpGet("{type}")]
        public async Task<ActionResult<List<vare_type>>> getType(string type)
        {
            var vare = await _context.vare_Type.FindAsync(type);
            if (vare == null)
            {
                return Ok(0);
            } else {
                return Ok(type);
            }
        }
        [HttpPost]
        public async Task<ActionResult<List<vare_type>>> addtype(vare_type type)
        {
            _context.vare_Type.Add(type);
            await _context.SaveChangesAsync();

            return Ok(await _context.vare_Type.ToListAsync());
        }

    }
}
