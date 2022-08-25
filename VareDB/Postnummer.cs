using System.ComponentModel.DataAnnotations;

namespace VareDB
{
    public class Postnummer
    {
        [Key]
        public int postnummer { get; set; }
        public string hjemby { get; set; } = string.Empty;

    }
}
