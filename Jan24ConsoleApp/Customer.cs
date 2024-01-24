using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan24ConsoleApp
{
    public class Customer
    {
        [Key]
        public int Cid { get; set; }
        [Required]//not null
        [StringLength(20)]
        public string CName { get; set; }
        [Required]
        [StringLength(10)]
        public string City { get; set; }

    }
}
