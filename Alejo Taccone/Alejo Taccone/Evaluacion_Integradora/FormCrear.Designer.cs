namespace Evaluacion_Integradora
{
    partial class FormCrear
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrear));
            cmb_tipoPersonaje = new ComboBox();
            btn_cancelar = new Button();
            btn_Crear = new Button();
            grp_habilidades = new GroupBox();
            checkBox10 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            grp_alianza = new GroupBox();
            radioButton9 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton1 = new RadioButton();
            rtx_planMalvado = new RichTextBox();
            grp_planMalvado = new GroupBox();
            lbl_tipo = new Label();
            txtBoxPersonaje = new TextBox();
            txtBoxNombreReal = new TextBox();
            lst_lugarOrigen = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            grp_habilidades.SuspendLayout();
            grp_alianza.SuspendLayout();
            grp_planMalvado.SuspendLayout();
            SuspendLayout();
            // 
            // cmb_tipoPersonaje
            // 
            cmb_tipoPersonaje.BackColor = Color.FromArgb(192, 255, 255);
            cmb_tipoPersonaje.FormattingEnabled = true;
            cmb_tipoPersonaje.Location = new Point(166, 50);
            cmb_tipoPersonaje.Margin = new Padding(4);
            cmb_tipoPersonaje.Name = "cmb_tipoPersonaje";
            cmb_tipoPersonaje.Size = new Size(423, 33);
            cmb_tipoPersonaje.TabIndex = 0;
            cmb_tipoPersonaje.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.LemonChiffon;
            btn_cancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btn_cancelar.Location = new Point(394, 652);
            btn_cancelar.Margin = new Padding(4);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(228, 65);
            btn_cancelar.TabIndex = 1;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_Crear
            // 
            btn_Crear.BackColor = Color.LemonChiffon;
            btn_Crear.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btn_Crear.Location = new Point(748, 652);
            btn_Crear.Margin = new Padding(4);
            btn_Crear.Name = "btn_Crear";
            btn_Crear.Size = new Size(228, 65);
            btn_Crear.TabIndex = 2;
            btn_Crear.Text = "Crear";
            btn_Crear.UseVisualStyleBackColor = false;
            btn_Crear.Click += btn_Crear_Click;
            // 
            // grp_habilidades
            // 
            grp_habilidades.BackColor = Color.FromArgb(192, 255, 255);
            grp_habilidades.Controls.Add(checkBox10);
            grp_habilidades.Controls.Add(checkBox9);
            grp_habilidades.Controls.Add(checkBox8);
            grp_habilidades.Controls.Add(checkBox7);
            grp_habilidades.Controls.Add(checkBox6);
            grp_habilidades.Controls.Add(checkBox5);
            grp_habilidades.Controls.Add(checkBox4);
            grp_habilidades.Controls.Add(checkBox3);
            grp_habilidades.Controls.Add(checkBox2);
            grp_habilidades.Controls.Add(checkBox1);
            grp_habilidades.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grp_habilidades.ForeColor = Color.Black;
            grp_habilidades.Location = new Point(629, 38);
            grp_habilidades.Margin = new Padding(4);
            grp_habilidades.Name = "grp_habilidades";
            grp_habilidades.Padding = new Padding(4);
            grp_habilidades.Size = new Size(669, 276);
            grp_habilidades.TabIndex = 3;
            grp_habilidades.TabStop = false;
            grp_habilidades.Text = "Habilidades";
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.BackColor = Color.Transparent;
            checkBox10.Location = new Point(342, 225);
            checkBox10.Margin = new Padding(4);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(192, 29);
            checkBox10.TabIndex = 9;
            checkBox10.Text = "Cambio de Tamaño";
            checkBox10.UseVisualStyleBackColor = false;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.BackColor = Color.Transparent;
            checkBox9.Location = new Point(49, 225);
            checkBox9.Margin = new Padding(4);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(144, 29);
            checkBox9.TabIndex = 8;
            checkBox9.Text = "Regeneración";
            checkBox9.UseVisualStyleBackColor = false;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.BackColor = Color.Transparent;
            checkBox8.Location = new Point(49, 188);
            checkBox8.Margin = new Padding(4);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(131, 29);
            checkBox8.TabIndex = 7;
            checkBox8.Text = "Telequinesis";
            checkBox8.UseVisualStyleBackColor = false;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.BackColor = Color.Transparent;
            checkBox7.Location = new Point(342, 188);
            checkBox7.Margin = new Padding(4);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(121, 29);
            checkBox7.TabIndex = 6;
            checkBox7.Text = "Elasticidad";
            checkBox7.UseVisualStyleBackColor = false;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.BackColor = Color.Transparent;
            checkBox6.Location = new Point(49, 150);
            checkBox6.Margin = new Padding(4);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(106, 29);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "Telepatía";
            checkBox6.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.BackColor = Color.Transparent;
            checkBox5.Location = new Point(342, 150);
            checkBox5.Margin = new Padding(4);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(232, 29);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Manipulación de Energía";
            checkBox5.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.BackColor = Color.Transparent;
            checkBox4.Location = new Point(49, 112);
            checkBox4.Margin = new Padding(4);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(83, 29);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Vuelo";
            checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = Color.Transparent;
            checkBox3.Location = new Point(342, 112);
            checkBox3.Margin = new Padding(4);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(132, 29);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Invisibilidad";
            checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.Transparent;
            checkBox2.Location = new Point(49, 75);
            checkBox2.Margin = new Padding(4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(205, 29);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Fuerza Sobrehumana";
            checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Location = new Point(342, 75);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(175, 29);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Control del Clima";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // grp_alianza
            // 
            grp_alianza.BackColor = Color.FromArgb(192, 255, 255);
            grp_alianza.Controls.Add(radioButton9);
            grp_alianza.Controls.Add(radioButton7);
            grp_alianza.Controls.Add(radioButton5);
            grp_alianza.Controls.Add(radioButton3);
            grp_alianza.Controls.Add(radioButton1);
            grp_alianza.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grp_alianza.ForeColor = Color.Black;
            grp_alianza.Location = new Point(629, 371);
            grp_alianza.Margin = new Padding(4);
            grp_alianza.Name = "grp_alianza";
            grp_alianza.Padding = new Padding(4);
            grp_alianza.Size = new Size(272, 226);
            grp_alianza.TabIndex = 0;
            grp_alianza.TabStop = false;
            grp_alianza.Text = "Alianza";
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.BackColor = Color.Transparent;
            radioButton9.Location = new Point(14, 189);
            radioButton9.Margin = new Padding(4);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(102, 29);
            radioButton9.TabIndex = 8;
            radioButton9.TabStop = true;
            radioButton9.Text = "Solitario";
            radioButton9.UseVisualStyleBackColor = false;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.BackColor = Color.Transparent;
            radioButton7.Location = new Point(14, 150);
            radioButton7.Margin = new Padding(4);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(227, 29);
            radioButton7.TabIndex = 6;
            radioButton7.TabStop = true;
            radioButton7.Text = "Guardianes de la galaxia";
            radioButton7.UseVisualStyleBackColor = false;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.BackColor = Color.Transparent;
            radioButton5.Location = new Point(14, 112);
            radioButton5.Margin = new Padding(4);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(122, 29);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.Text = "Los X-Men";
            radioButton5.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.Transparent;
            radioButton3.Location = new Point(14, 75);
            radioButton3.Margin = new Padding(4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(169, 29);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Los 4 fantasticos";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Location = new Point(14, 38);
            radioButton1.Margin = new Padding(4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(162, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Los vengadores";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // rtx_planMalvado
            // 
            rtx_planMalvado.BackColor = Color.FromArgb(192, 255, 255);
            rtx_planMalvado.Location = new Point(22, 55);
            rtx_planMalvado.Margin = new Padding(4);
            rtx_planMalvado.Name = "rtx_planMalvado";
            rtx_planMalvado.Size = new Size(339, 185);
            rtx_planMalvado.TabIndex = 10;
            rtx_planMalvado.Text = "";
            // 
            // grp_planMalvado
            // 
            grp_planMalvado.BackColor = Color.Transparent;
            grp_planMalvado.Controls.Add(rtx_planMalvado);
            grp_planMalvado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grp_planMalvado.ForeColor = Color.Black;
            grp_planMalvado.Location = new Point(909, 325);
            grp_planMalvado.Margin = new Padding(4);
            grp_planMalvado.Name = "grp_planMalvado";
            grp_planMalvado.Padding = new Padding(4);
            grp_planMalvado.Size = new Size(389, 276);
            grp_planMalvado.TabIndex = 10;
            grp_planMalvado.TabStop = false;
            grp_planMalvado.Text = "Plan Malvado";
            // 
            // lbl_tipo
            // 
            lbl_tipo.BackColor = Color.LemonChiffon;
            lbl_tipo.Location = new Point(15, 50);
            lbl_tipo.Margin = new Padding(4, 0, 4, 0);
            lbl_tipo.Name = "lbl_tipo";
            lbl_tipo.Size = new Size(105, 31);
            lbl_tipo.TabIndex = 11;
            lbl_tipo.Text = "Elegir tipo:";
            // 
            // txtBoxPersonaje
            // 
            txtBoxPersonaje.BackColor = Color.FromArgb(192, 255, 255);
            txtBoxPersonaje.Location = new Point(208, 248);
            txtBoxPersonaje.Margin = new Padding(4);
            txtBoxPersonaje.Name = "txtBoxPersonaje";
            txtBoxPersonaje.Size = new Size(382, 31);
            txtBoxPersonaje.TabIndex = 12;
            // 
            // txtBoxNombreReal
            // 
            txtBoxNombreReal.BackColor = Color.FromArgb(192, 255, 255);
            txtBoxNombreReal.Location = new Point(208, 172);
            txtBoxNombreReal.Margin = new Padding(4);
            txtBoxNombreReal.Name = "txtBoxNombreReal";
            txtBoxNombreReal.Size = new Size(382, 31);
            txtBoxNombreReal.TabIndex = 13;
            // 
            // lst_lugarOrigen
            // 
            lst_lugarOrigen.BackColor = Color.FromArgb(192, 255, 255);
            lst_lugarOrigen.FormattingEnabled = true;
            lst_lugarOrigen.ItemHeight = 25;
            lst_lugarOrigen.Location = new Point(40, 396);
            lst_lugarOrigen.Margin = new Padding(4);
            lst_lugarOrigen.Name = "lst_lugarOrigen";
            lst_lugarOrigen.Size = new Size(549, 204);
            lst_lugarOrigen.TabIndex = 14;
            // 
            // label1
            // 
            label1.BackColor = Color.LemonChiffon;
            label1.Location = new Point(29, 249);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 31);
            label1.TabIndex = 15;
            label1.Text = "Personaje:";
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.BackColor = Color.LemonChiffon;
            label2.Location = new Point(29, 171);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 31);
            label2.TabIndex = 16;
            label2.Text = "Nombre Real:";
            // 
            // label3
            // 
            label3.BackColor = Color.LemonChiffon;
            label3.Location = new Point(164, 342);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(280, 31);
            label3.TabIndex = 17;
            label3.Text = "Seleccione el lugar de origen";
            // 
            // FormCrear
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1326, 732);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lst_lugarOrigen);
            Controls.Add(txtBoxNombreReal);
            Controls.Add(txtBoxPersonaje);
            Controls.Add(lbl_tipo);
            Controls.Add(grp_planMalvado);
            Controls.Add(grp_alianza);
            Controls.Add(grp_habilidades);
            Controls.Add(btn_Crear);
            Controls.Add(btn_cancelar);
            Controls.Add(cmb_tipoPersonaje);
            Margin = new Padding(4);
            Name = "FormCrear";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear";
            Load += FormCrear_Load;
            grp_habilidades.ResumeLayout(false);
            grp_habilidades.PerformLayout();
            grp_alianza.ResumeLayout(false);
            grp_alianza.PerformLayout();
            grp_planMalvado.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_tipoPersonaje;
        private Button btn_cancelar;
        private Button btn_Crear;
        private GroupBox grp_habilidades;
        private CheckBox checkBox10;
        private CheckBox checkBox9;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox grp_alianza;
        private RadioButton radioButton9;
        private RadioButton radioButton7;
        private RadioButton radioButton5;
        private RadioButton radioButton3;
        private RadioButton radioButton1;
        private RichTextBox rtx_planMalvado;
        private GroupBox grp_planMalvado;
        private Label lbl_tipo;
        private TextBox txtBoxPersonaje;
        private TextBox txtBoxNombreReal;
        private ListBox lst_lugarOrigen;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}