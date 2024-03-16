using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GrupoPrueba2.Models
{
    
    [Table("t_order")]
    public class Pedido
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID {get; set;}

        public String UserID{ get; set; }

        public Decimal Total { get; set; }

        public Pago pago { get; set; }

        public String Status { get; set; }

    }
}
