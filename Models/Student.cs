using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP.netMay23.Models
{
    public partial class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [DisplayName("Roll Number")]
        public string? RollNumber { get; set; }
        [MaxLength(10)]
        public string? Class { get; set; }
    }
}
