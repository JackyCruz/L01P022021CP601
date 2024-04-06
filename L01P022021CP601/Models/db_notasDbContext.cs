﻿using Microsoft.EntityFrameworkCore;

namespace L01P022021CP601.Models
{
        public class db_notasDbContext : DbContext
        {
            public db_notasDbContext(DbContextOptions options) : base(options)
            {
            }
            public DbSet<alumnos> alumnos { get; set; }
            public DbSet<departamentos> departamentos { get; set; }
            public DbSet<facultades> facultades { get; set; }
            public DbSet<materias> materias { get; set; }
        }
    
}
