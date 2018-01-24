using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace thoughtless_eels.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId {get; set;}

        [Required]
        public string Name {get; set;}

        [Required]
        public int Budget {get; set;}
            
    }
}