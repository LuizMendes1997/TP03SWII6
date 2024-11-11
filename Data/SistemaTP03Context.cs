using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaTP03.Models;

namespace SistemaTP03.Data
{
    public class SistemaTP03Context : DbContext
    {
        public SistemaTP03Context (DbContextOptions<SistemaTP03Context> options)
            : base(options)
        {
        }

        public DbSet<SistemaTP03.Models.Produto> Produto { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Produto>()
                .Property(p => p.Preco)
                .HasPrecision(18, 2);

            base.OnModelCreating(modelBuilder);
        }

    }
}
