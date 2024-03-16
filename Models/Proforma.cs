using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GrupoPrueba2.Models
{
    //CARRITO
    [Table ("t_proforma")]
    public class Proforma
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]

        public int Id { get; set; }

        public string UserID { get; set; }

        public Catalogo Producto { get; set; }

        public int Quantity { get; set; }

        public Decimal Price { get; set; }
        public String Status { get; set; } = "PENDIENTE";
    }
}