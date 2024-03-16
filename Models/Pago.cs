using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GrupoPrueba2.Models
{
    public class Pago
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        public DateTime PaymentDate { get; set; }
        public String NombreTarjeta { get; set; }
        public String NumeroTarjeta { get; set; }

        [NotMapped]
        public String DueDateYYMM { get; set; }
        [NotMapped]
        public String Cvv { get; set; }
        public Decimal MontoTotal{ get; set; }
        public String UserID{ get; set; }
    }
}