using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JobTestSemma.Models
{
    public class Barco
    {
        [Key]
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public int NumeroAmarre { get; set; }
        public double Cuota { get; set; }
        public int SocioId { get; set; }
        public virtual Socio Socio { get; set; }

    }
}