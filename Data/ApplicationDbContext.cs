using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GrupoPrueba2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GrupoPrueba2.Models.Catalogo> DataProducts { get; set; }
        public DbSet<GrupoPrueba2.Models.Contact> DataContactos { get; set; }
        public DbSet<GrupoPrueba2.Models.Proforma> DataProforma { get; set; }
        public DbSet<GrupoPrueba2.Models.Pago> DataPago { get; set; }
        public DbSet<GrupoPrueba2.Models.Pedido> DataPedido { get; set; }
        public DbSet<GrupoPrueba2.Models.DetallePedido> DataDetallePedido { get; set; }

    }
}
