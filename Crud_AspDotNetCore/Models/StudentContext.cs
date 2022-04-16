using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_AspDotNetCore.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> option) : base(option)
        {

        }

        public DbSet<Student> tbl_Student { get; set; }
        public DbSet<Departments> tbl_Departments { get; set; }

    }
}
