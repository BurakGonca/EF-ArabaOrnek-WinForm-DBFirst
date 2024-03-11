using _7mart2024.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _7mart2024
{
    public class ArabaDBContext : DbContext
    {
        public ArabaDBContext()
        {

        }

        public DbSet<Araba> Arabalar { get; set; } //arabalar tablosu olusturma
        public DbSet<Plaka> Plakalar { get; set; } //plakalar tablosu olusturma
        public DbSet<Muhendis> Muhendisler { get; set; } //muhendisler tablosu olusturma
        public DbSet<Kisi> Kisiler { get; set; } //kisiler tablosu olusturma


        //add-migration "ArabaDataBase"

        //update-database

        // package mager console için kodlar


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //optionsBuilder.UseSqlServer("Data Source=ANK-YZLMORT-01\\MSSQLSERVERANK16;Initial Catalog=ArabaDB;Integrated Security=true;Encrypt=False");

            optionsBuilder.UseSqlServer("Data Source=BURAK;Initial Catalog=ArabaDB;Integrated Security=true;Encrypt=False");

            


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Araba>().ToTable("Arabalar");



        }




    }
}
