using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TestTicket.Models;

namespace TestTicket.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TestTicket.Models.Users> Users { get; set; }
        public DbSet<LogInformation> LogInformation { get; set; }
        public DbSet<TestTicket.Models.Adresses> Adresses { get; set; }
    }
}
