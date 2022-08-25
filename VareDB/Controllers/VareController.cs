using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VareDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VareController : ControllerBase
    {
        private static List<vare> _vares = new List<vare>
            {
                new vare
                {
                    Vare_id = 1,
                    Navn = "Æble",
                    Pris = 2,
                    Beskrivelse = "Sund Frugt",
                    Lager = 42,
                    Type = "Frugt"
                },
                new vare
                {
                    Vare_id = 2,
                    Navn = "Pære",
                    Pris = 3,
                    Beskrivelse = "Mærkelig Frugt",
                    Lager = 42,
                    Type = "Frugt"
                }
            };
        private readonly DataContext _context;

        public VareController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<vare>>> Get()
        {
            return Ok(await _context.vare.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<vare>>> Get(int id)
        {
            var vare = await _context.vare.FindAsync(id);
            return Ok(vare);
        }

        [HttpPost]
        public async Task<ActionResult<List<vare>>> addVare(vare vare)
        {
            _context.vare.Add(vare);
            await _context.SaveChangesAsync();

            return Ok(await _context.vare.ToListAsync());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<vare>>> UpdateVare(int id, [FromBody] vare vareRequest)
        {
            var dbvare = await _context.vare.FindAsync(id);
            if (dbvare == null)
                return BadRequest("Vare ikke fundet");

            dbvare.Navn = vareRequest.Navn;
            dbvare.Pris = vareRequest.Pris;
            dbvare.Beskrivelse = vareRequest.Beskrivelse;
            dbvare.Lager = vareRequest.Lager;
            dbvare.Type = vareRequest.Type;

            await _context.SaveChangesAsync();

            return Ok(await _context.vare.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<vare>>> Delete(int id)
        {
            var dbvare = await _context.vare.FindAsync(id);

            _context.vare.Remove(dbvare);
            await _context.SaveChangesAsync();
            return Ok(await _context.vare.ToListAsync());
        }
        [HttpGet("type/{type}")]
        public async Task<ActionResult<List<vare>>> GetType(string type)
        {
            var dbvare = await _context.vare.ToListAsync();
            var result = dbvare.Where(p => p.Type == type);
            return Ok(result);
        }
    }
}
