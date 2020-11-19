using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dropdown.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName ="varchar(20)")]
        [Required(ErrorMessage ="This field is required.")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        [Column(TypeName = "varchar(10)")]        
        [Required(ErrorMessage ="This field is required.")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage ="This field is required.")]
        public string Position { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage ="This field is required.")]
        public string Address { get; set; }

        [Column(TypeName = "varchar(10)")]     
        public string CityName{ get; set; }

        [Column(TypeName = "varchar(10)")]     
        public string StateName{ get; set; }

        public virtual State State { get; set; }
        public virtual City City { get; set; }
        
    }
}
