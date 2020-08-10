using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrustructor.Data.Context
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options)
        :base(options)
        {
             
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}
