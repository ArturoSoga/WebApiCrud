using System;
using System.ComponentModel.DataAnnotations;

namespace GN3BackEnd.Models
{
    public class employees
    {
        [Key]
        public int EmplId { get; set; }
        public string EmplName { get; set; }
        public string EmplSecondName { get; set; }
        public string EmplLastName { get; set; }
        public DateTime EmplHireDate { get; set; }
        public DateTime EmplBirthDate { get; set; }
        public int? DepaId { get; set; }
        public bool EmplActive { get; set; }

    }
}
