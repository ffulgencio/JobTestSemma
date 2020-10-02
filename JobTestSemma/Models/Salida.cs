using Microsoft.VisualBasic;

namespace JobTestSemma.Models
{
    public class Salida
    {
        public int SalidaId { get; set; }
        public string Matricula { get; set; }
        public virtual Barco Barco { get; set; }
        public string Destino { get; set; }
        public DateAndTime FechaSalida { get; set; }
        public int PatronId { get; set; }
        public virtual Patron Patron { get; set; }
    }
}