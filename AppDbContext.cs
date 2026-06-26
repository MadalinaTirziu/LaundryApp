using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProiectMSOA.Models;

namespace ProiectMSOA.Data
{
    public class AppDbContext :DbContext
    {
        public DbSet<Utilizator> Utilizatori { get; set; }
        public DbSet<Comanda> Comenzi { get; set; }
        public DbSet<Plata> Plati { get; set; }
        public DbSet<Serviciu> Servicii { get; set; }
        public DbSet<Notificare> Notificari { get; set; }
        public DbSet<Raport> Rapoarte { get; set; }
        public DbSet <SetareSistem> SetariSistem { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=Spalatorie.db");
        }
    }
}
