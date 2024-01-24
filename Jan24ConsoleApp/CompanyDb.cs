using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan24ConsoleApp
{
    public class CompayDb : DbContext
    {
        public CompayDb() : base("con_str")
        {

        }
        public DbSet<Customer> customers { get; set; }
    }

}
