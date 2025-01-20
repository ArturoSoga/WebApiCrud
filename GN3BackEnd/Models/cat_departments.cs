using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GN3BackEnd.Models
{
    public class DepartmentInfo
    {
        //[Required]
        public string DepaDescripcion { get; set; }
        [Required]
        public bool DepaActive { set; get; }
    }
    public class cat_departments: DepartmentInfo
    {
        [Key]
        public int DepaId { get; set; }

    }

}
