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
        public async Task<ActionResult<List<Kunde>>> addtype(Kunde kunde, string dato)
        {
            //opretter Kunde
            _context.Kunde.Add(kunde);
            await _context.SaveChangesAsync();

            //opretter Ordre
            var ordreid = kunde.Kunde_id;
            Ordre ordre = new Ordre();
            ordre.Kunde_id = ordreid;
            ordre.Ordre_date = dato;
            _context.Ordre.Add(ordre);
            await _context.SaveChangesAsync();

            /*opretter Ordre_vare
            foreach (vare vare in Lvare)
            {

            }*/



            return Ok(await _context.Kunde.ToListAsync());
        }
    }
}
