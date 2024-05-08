using MembershipManagement.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MembershipManagement.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Sealing> Sealings { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Sealing>().HasData(

                new Sealing
                {
                    SealingId = 1,
                    SealingDate = DateTime.Parse("2024-05-01"),
                    AppliedByDate = DateTime.Now,
                    SealingType = "Regular",
                    Status = "Submitted",
                    BranchId = 3,
                    Id = "a3d8ae1e-1e15-4ae7-b6cd-cd37cca74269",

                },
                new Sealing
                {
                    SealingId = 2,
                    SealingDate = DateTime.Parse("2024-05-01"),
                    AppliedByDate = DateTime.Now,
                    SealingType = "Regular",
                    Status = "Submitted",
                    BranchId = 3,
                    Id = "c994283e-7d07-4c8a-a11f-b7c4c616d4f9"

                },
                new Sealing
                {
                    SealingId = 3,
                    SealingDate = DateTime.Parse("2024-05-10"),
                    AppliedByDate = DateTime.Now,
                    SealingType = "Regular",
                    Status = "Submitted",
                    BranchId = 3,
                    Id = "50eeab50-dc3a-4cdf-89d6-251efcdd50f3",

                },
                new Sealing
                {
                    SealingId = 4,
                    SealingDate = DateTime.Parse("2024-05-21"),
                    AppliedByDate = DateTime.Now,
                    SealingType = "Regular",
                    Status = "Submitted",
                    BranchId = 3,
                    Id = "07f809e0-322f-4fcc-8570-1fc669f57ee7"
                }

                );
        }
    }
}
