using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTestSemma.Models
{
    public class Socio : Persona
    {
        public int SocioId { get; set; }


        public virtual ICollection<Barco> Barcos { get; set; }

        public Socio()
        {
            this.Barcos = new HashSet<Barco>();
        }
    }
}
