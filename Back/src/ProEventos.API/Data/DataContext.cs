using System;
using Microsoft.EntityFrameworkCore;
using ProEventos.API.Models;

namespace ProEventos.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {}

        public DbSet<Evento> Eventos { get; set; }
        
    
    protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.Entity<Evento>().HasData(
        new Evento()
        {
            EventoId = 1,
            Tema = "Angular 11 e .NET 5",
            Local = "Rio de Janeiro",
            Lote = "1o Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2),
            ImagemURL = "foto1.png"
        }
        ,
        new Evento()
        {
            EventoId = 2,
            Tema = "Angular 11 e .NET 5",
            Local = "São Paulo",
            Lote = "2o Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(3),
            ImagemURL = "foto2.png"
        }
    );
    
    }
}