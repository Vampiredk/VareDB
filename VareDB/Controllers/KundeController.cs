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
            //opretter Kunde
            _context.Kunde.Add(kunde);
            await _context.SaveChangesAsync();

            //opretter Ordre
            DateOnly dato = new DateOnly();
            var ordre_kundeid = kunde.Kunde_id;
            Ordre ordre = new Ordre();
            ordre.Kunde_id = ordre_kundeid;
            ordre.Ordre_date = dato.ToString();
            _context.Ordre.Add(ordre);
            await _context.SaveChangesAsync();

            //opretter Ordre_vare
            /*var vare_ordreid = ordre.Ordre_id;
            foreach (vareOrdreModel vare in Lvare)
            {
                Ordre_vare ordre_Vare = new Ordre_vare();
                ordre_Vare.Ordre_id = vare_ordreid;
                ordre_Vare.Vare_id = vare.id;
                ordre_Vare.Antal = vare.antal;
                ordre_Vare.Pris = vare.pris;
                _context.Ordre_vare.Add(ordre_Vare);
                await _context.SaveChangesAsync();
            }*/

            return Ok(await _context.Kunde.ToListAsync());
        }
    }
}
