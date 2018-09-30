using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_codefFirst.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext() : base("mydb") { }

        public DbSet<Person> People { get; set; }

        public DbSet<Credit> Credits { get; set; }
    }
}
