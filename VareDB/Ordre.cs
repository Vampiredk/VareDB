using System.ComponentModel.DataAnnotations;

namespace VareDB
{
    public class Ordre
    {
        [Key]
        public int Ordre_id { get; set; }
        public int Kunde_id { get; set; }
        public string Ordre_date { get; set; }
    }
}
