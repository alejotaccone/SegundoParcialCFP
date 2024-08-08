
using LibreriaDePersonajes;
using static System.Windows.Forms.DataFormats;
namespace Evaluacion_Integradora
{
    public partial class FormPrincipal : Form
    {
        List<Personaje> personajes = new List<Personaje>();
        
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.personajes = new List<Personaje>();
            CargarDatos();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FormCrear formCrear = new FormCrear(); 
            formCrear.ShowDialog();
            if (formCrear.DialogResult == DialogResult.OK && formCrear.NuevoPersonaje is not null)
            {
                personajes.Add(formCrear.NuevoPersonaje);
                CargarDatos();
            }

        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = personajes;
        }

        
    }
}
