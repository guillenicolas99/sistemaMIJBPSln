using CapaDominio.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaInfraestructura.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSet para cada entidad
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Red> Redes { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuraciones adicionales si es necesario (opcional)
            // Por ejemplo, para configurar la clave foránea manualmente o hacer reglas personalizadas

            // Relación uno a muchos entre Red y Persona
            modelBuilder.Entity<Persona>()
                .HasOne(p => p.Red)
                .WithMany(r => r.Personas)
                .HasForeignKey(p => p.RedID)
                .OnDelete(DeleteBehavior.Restrict);

            // Relación uno a muchos entre Persona y Ticket
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Persona)
                .WithMany(p => p.Tickets)
                .HasForeignKey(t => t.PersonaID)
                .OnDelete(DeleteBehavior.Restrict);

            // Relación uno a muchos entre Evento y Ticket
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Evento)
                .WithMany(e => e.Tickets)
                .HasForeignKey(t => t.EventoID)
                .OnDelete(DeleteBehavior.Restrict);

            // Relación uno a muchos entre Categoria y Ticket
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Categoria)
                .WithMany(c => c.Tickets)
                .HasForeignKey(t => t.CategoriaID)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }

    }
}
