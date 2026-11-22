using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Reto11
{
    public class AgendaContext : DbContext
    {
        public DbSet<Contactos> Contacto => Set<Contactos>();

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=agenda.db");
    }
}
