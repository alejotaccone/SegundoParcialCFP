using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDePersonajes
{
    public class Villano : Personaje
    {

        protected string planMalvado;

        public Villano(string nombreReal, string nombrePersonaje, string origen, string planMalvado)
            : base(nombreReal, nombrePersonaje, origen)
        {
            this.planMalvado = planMalvado;
        }

        public override string MostrarDescripcion()
        {
            return $"{nombrePersonaje} es un villano con un plan malvado de: {planMalvado}";
        }
    }
}
