﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H1Store.Catalogo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Microsoft.Extensions.Options;

namespace H1Store.Catalogo.Data.EntityFramework
{

    public class Contexto : DbContext
    {
        private readonly DatabaseSettings _databaseSettings;

        public Contexto(DbContextOptions<Contexto> options, IOptions<DatabaseSettings> databaseSettings) : base(options)
        {
            _databaseSettings = databaseSettings.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_databaseSettings.ConnectionString);
        }

        public DbSet<Crianca> Carta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CartaConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
