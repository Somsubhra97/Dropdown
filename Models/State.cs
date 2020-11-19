using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dropdown.Models
{
public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Employee")]
		public int EmployeeId{get;set;}
		
        public vitual List<City> Cities { get; set; }
    }
}