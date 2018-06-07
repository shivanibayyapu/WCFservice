using entityframework.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entityframework.Data
{
    public class StudentContext:DbContext
    {
        public DbSet<Studententity> TableStudent { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SBAYYAPU01;Database=TableStudent;Trusted_Connection=True;MultipleActiveResultSet=True;");
            base.OnConfiguring(optionsBuilder);

        }

    }
}
