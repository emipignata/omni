using System;
using Microsoft.EntityFrameworkCore;
using Omnicanal.Models;

namespace Omnicanal.Database
{
    public class OmnicanalDbContext : DbContext
    {
        public OmnicanalDbContext(DbContextOptions<OmnicanalDbContext> opciones) : base(opciones)
        {
        }

        public DbSet<Admin> Admines { get; set; }
        public DbSet<Asesor> Asesores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Mensaje> Mensajes { get; set; }

    }
}