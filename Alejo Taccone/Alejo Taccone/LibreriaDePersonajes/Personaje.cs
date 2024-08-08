using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace LibreriaDePersonajes
{
    public abstract class Personaje
    {
        protected string nombreReal;
        protected string nombrePersonaje;
        protected string origen;
        protected List<string> habilidades;       

        public string NombreReal { get => nombreReal; }
        public string NombrePersonaje { get => nombrePersonaje; }
        public string Origen { get => origen; }

        public string Descripcion { get => MostrarDescripcion(); }

        public string Habilidades { get {
                string almacenar = string.Empty;
                foreach (string item in habilidades)
                {
                    almacenar += item;
                }
                return almacenar;
            }  }

        private Personaje()
        {
            this.habilidades = new List<string>();
        }

        public Personaje(string nombreReal, string nombrePersonaje, string origen)
            :this()
        {
            this.nombreReal = nombreReal;
            this.nombrePersonaje = nombrePersonaje;
            this.origen = origen;
        }


        public void SetHabilidad(string habilidad)
        {
            
            this.habilidades.Add(habilidad);
        }
        public abstract string MostrarDescripcion();

    }
}
