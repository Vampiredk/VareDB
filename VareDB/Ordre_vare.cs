using System.ComponentModel.DataAnnotations;

namespace VareDB
{
    public class Ordre_vare
    {
        [Key]
        public int Ordre_id { get; set; }
        public int Vare_id { get; set; }
        public int Antal { get; set; }
        public string Pris { get; set; } = string.Empty;
    }
}
