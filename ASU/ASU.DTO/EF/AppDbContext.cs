﻿using ASU.DTO.Actors;
using ASU.DTO.Documents;
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
        public DbSet<Verificator> Verificators { get; set; }
        public DbSet<TestEquipment> TestEquipments { get; set; }
        public DbSet<MeasurementType> MeasurementTypes { get; set; }
        public DbSet<MeasureDeviceType> MeasureDeviceTypes { get; set; }
        public DbSet<MeasureDevice> MeasureDevices { get; set; }
        public DbSet<StampType> StampTypes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {

        }
    }
}
