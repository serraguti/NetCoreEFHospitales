using Microsoft.EntityFrameworkCore;
using NetCoreEFHospitales.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreEFHospitales.Data
{
    public class HospitalContext:DbContext
    {
        public HospitalContext
            (DbContextOptions<HospitalContext> options) : base(options) { }

        public DbSet<Hospital> Hospitales { get; set; }
    }
}
