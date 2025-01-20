using System.ComponentModel.DataAnnotations;

namespace GN3BackEnd.Models
{
    public class cat_payment_methods
    {
        [Key]
        public int PameId { get; set; }
        public string PameName { get; set; }
        public bool PameActive { get; set; }
    }
}
