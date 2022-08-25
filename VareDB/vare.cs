using System.ComponentModel.DataAnnotations;

namespace VareDB
{
    public class vare
    {
        [Key]
        public int Vare_id { get; set; }
        public string Navn { get; set; } = string.Empty;
        public int Pris { get; set; }
        public string Beskrivelse { get; set; } = string.Empty;
        public int Lager { get; set; }
        public string Type { get; set; } = string.Empty; 
    }
}
