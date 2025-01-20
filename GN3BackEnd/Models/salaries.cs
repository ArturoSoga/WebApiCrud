using System.ComponentModel.DataAnnotations;

namespace GN3BackEnd.Models
{
    public class salaries
    {
        [Key]
        public int SalaId { get; set; }
        public int PameId { get; set; }
        private int EmplId { get; set; }
        public float SalaAmount { get; set; }
        public bool SalaActive { get; set; }

    }
}
