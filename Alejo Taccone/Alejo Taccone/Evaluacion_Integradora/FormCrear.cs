using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using LibreriaDePersonajes;

namespace Evaluacion_Integradora
{
    public partial class FormCrear : Form
    {
        Personaje nuevoPersonaje;
       
        public FormCrear()
        {
            InitializeComponent();
        }
        private void FormCrear_Load(object sender, EventArgs e)
        {
            #region NO MODIFICAR
            cmb_tipoPersonaje.DataSource = new List<string>() { "Heroe", "Villano" };
            this.lst_lugarOrigen.DataSource = new List<string>() { "Asgard", "Midgard", "Xandar", "Hala", "Skrullos", "Titan", "Tierra-616" };
            #endregion


        }
        #region NO MODIFICAR
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_tipoPersonaje.SelectedItem!.ToString() == "Heroe")
            {
                grp_alianza.Enabled = true;
                grp_planMalvado.Enabled = false;
            }
            else if (cmb_tipoPersonaje.SelectedItem.ToString() == "Villano")
            {
                grp_alianza.Enabled = false;
                grp_planMalvado.Enabled = true;
            }
        }
        #endregion


        private void btn_Crear_Click(object sender, EventArgs e)
        {
            string nombreReal = txtBoxNombreReal.Text;
            string nombrePersonaje = txtBoxPersonaje.Text;
            string origen = lst_lugarOrigen.SelectedItem.ToString();       

            if (cmb_tipoPersonaje.SelectedItem!.ToString() == "Heroe")
            {
                string alianza = string.Empty;
                foreach (RadioButton rB in grp_alianza.Controls)
                {
                    if (rB.Checked == true)
                    {
                        alianza = rB.Text;
                    }
                }
                Personaje nuevoPersonaje = new Heroe(nombreReal, nombrePersonaje, origen, alianza);
                foreach (CheckBox ckB in grp_habilidades.Controls)
                {
                    if (ckB.Checked == true)
                    {
                        nuevoPersonaje.SetHabilidad(ckB.Text);
                    }
                }
                this.nuevoPersonaje = nuevoPersonaje;
                DialogResult = DialogResult.OK;
            }
            else if (cmb_tipoPersonaje.SelectedItem.ToString() == "Villano")
            {
                string planMalvado = rtx_planMalvado.SelectedText.ToString();
                Personaje nuevoPersonaje = new Villano(nombreReal, nombrePersonaje, origen, planMalvado);
                foreach (CheckBox ckB in grp_habilidades.Controls)
                {
                    if (ckB.Checked == true)
                    {
                        nuevoPersonaje.SetHabilidad(ckB.Text);
                    }
                }
                this.nuevoPersonaje = nuevoPersonaje;
                DialogResult = DialogResult.OK;
            }


        }

        public Personaje NuevoPersonaje { get => nuevoPersonaje; }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
