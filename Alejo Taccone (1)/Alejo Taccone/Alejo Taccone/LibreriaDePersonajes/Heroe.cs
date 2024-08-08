using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDePersonajes
{
    public class Heroe : Personaje
    {
        protected string alianza;

        public Heroe(string nombreReal, string nombrePersonaje, string origen, string alianza)
            :base(nombreReal, nombrePersonaje, origen)
        {
            this.alianza = alianza;
        }

        public override string MostrarDescripcion()
        {
            return $"{nombrePersonaje} es un heroe de la alianza: {alianza}";
        }
    }
}
