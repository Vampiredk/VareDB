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
        public async Task<ActionResult<List<ordremodel>>> addtype(List<ordremodel> ordre_vare)
        {
            /*_context.Ordre_vare.Add(ordre_vare);
            await _context.SaveChangesAsync();*/

            foreach (ordremodel vare in ordre_vare)
            {
                Ordre_vare ordre_Vare = new Ordre_vare();
                ordre_Vare.Ordre_id = 5;
                ordre_Vare.Vare_id = vare.id;
                ordre_Vare.Antal = vare.antal;
                int totalpris = vare.antal * vare.pris;
                ordre_Vare.Pris = totalpris.ToString();
                _context.Ordre_vare.Add(ordre_Vare);
                await _context.SaveChangesAsync();
            }

            return Ok(await _context.Ordre_vare.ToListAsync());
        }
    }
}
