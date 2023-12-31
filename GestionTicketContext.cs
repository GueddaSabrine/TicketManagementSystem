using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GestionTicket
{
    class GestionTicketContext : DbContext
    {
        public GestionTicketContext(): base()
        {
        }

        public DbSet<Spectacle> Spectacles { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Billet> Billets { get; set; }

        ///protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        ///{
            // base de données (SQL Server) et la chaîne de connexion
            ///optionsBuilder.UseSqlServer("Server=LAPTOP-9O1QJMQ6;Database=ticket;User=root;Password=;");
        ///}
    }
}
