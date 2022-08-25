using System.ComponentModel.DataAnnotations;

namespace VareDB
{
    public class Kunde
    {
        [Key]
        public int Kunde_id { get; set; }
        public string Navn { get; set; } = string.Empty;
        public string TelefonNummer { get; set; }
        public string Addresse { get; set; } = string.Empty;
        public int postnummer { get; set; }
 
    }
}
