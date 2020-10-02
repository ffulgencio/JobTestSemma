using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTestSemma.Models
{
    public class Patron : Persona
    {
        public int PatronId { get; set; }

        public virtual ICollection<Salida> Salidas { get; set; }

        public Patron()
        {
            this.Salidas = new HashSet<Salida>();
        }
    }
}
