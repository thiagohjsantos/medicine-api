using MedicineApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
           
        }

        public DbSet<Medicine> Medicines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Medicine>()
                .Property(p => p.Name)
                .HasMaxLength(80);

            modelBuilder.Entity<Medicine>()
                .Property(p => p.Category)
                .HasMaxLength(80);

            modelBuilder.Entity<Medicine>()
                .Property(p => p.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Medicine>()
                .HasData(
                new Medicine { Id = 1, Name = "Aspirin", Category = "Analgesic", Quantity = 30, Price = 10.25m, ExpDate = "02/02/2023"},
                new Medicine { Id = 2, Name = "Penicillin", Category = "Antibiotic", Quantity = 5, Price = 25.45m, ExpDate = "12/08/2022"},
                new Medicine { Id = 3, Name = "Paracetamol", Category = "Analgesic", Quantity = 10, Price = 7.95m, ExpDate = "21/07/2022"}
                );
        }
    }
}
