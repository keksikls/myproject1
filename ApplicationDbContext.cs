using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyProject.Models;

namespace MyProject.Data
{
    public class ApplicationDbConext : DbContext
    {
        public ApplicationDbConext(DbContextOptions<ApplicationDbConext> options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }
        public DbSet<ApplicationType> ApplicationType { get; set; }
    }
}
