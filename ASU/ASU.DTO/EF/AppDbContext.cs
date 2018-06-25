using ASU.DTO.Actors;
using ASU.DTO.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASU.DTO.EF
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Declarant> Declarants { get; set; }
        public DbSet<VerificationDevice> VerificationDevices { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {

        }
    }
}
