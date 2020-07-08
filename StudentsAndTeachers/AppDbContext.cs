using Microsoft.EntityFrameworkCore;
using StudentsAndTeachers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsAndTeachers
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<ClassCourse> Classes { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<StreamMessage> StreamMessages { get; set; }

    }
}
