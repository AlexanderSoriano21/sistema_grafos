namespace Desafio2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel2 = new Panel();
            btnProfundidad = new Button();
            btnAnchura = new Button();
            btnBuscar = new Button();
            cmbDepartamento = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            lblLaUnión = new Label();
            lblMorazán = new Label();
            lblSanMiguel = new Label();
            lblUsulután = new Label();
            lblLaPaz = new Label();
            lblSanVicente = new Label();
            lblCabañas = new Label();
            lblCuscatlán = new Label();
            lblChalatenango = new Label();
            lblSanSalvador = new Label();
            lblLaLibertad = new Label();
            lblSonsonate = new Label();
            lblAhuachapán = new Label();
            lblSantaAna = new Label();
            btnCerrar = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(btnProfundidad);
            panel2.Controls.Add(btnAnchura);
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(cmbDepartamento);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(836, 75);
            panel2.TabIndex = 15;
            // 
            // btnProfundidad
            // 
            btnProfundidad.Location = new Point(503, 30);
            btnProfundidad.Name = "btnProfundidad";
            btnProfundidad.Size = new Size(97, 28);
            btnProfundidad.TabIndex = 7;
            btnProfundidad.Text = "Profundidad";
            btnProfundidad.UseVisualStyleBackColor = true;
            btnProfundidad.Click += btnProfundidad_Click;
            // 
            // btnAnchura
            // 
            btnAnchura.Location = new Point(400, 30);
            btnAnchura.Name = "btnAnchura";
            btnAnchura.Size = new Size(97, 28);
            btnAnchura.TabIndex = 6;
            btnAnchura.Text = "Anchura";
            btnAnchura.UseVisualStyleBackColor = true;
            btnAnchura.Click += btnAnchura_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(616, 30);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(162, 28);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar Departamento";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Items.AddRange(new object[] { "Santa Ana", "Chalatenango", "Ahuachapán", "Sonsonate", "La Libertad", "Cuscatlán", "San Salvador", "Cabañas", "San Vicente", "La Paz", "San Miguel", "Usulután", "Morazán", "La Unión" });
            cmbDepartamento.Location = new Point(247, 33);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(137, 25);
            cmbDepartamento.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(5, 36);
            label2.Name = "label2";
            label2.Size = new Size(236, 17);
            label2.TabIndex = 1;
            label2.Text = "Departamento inicial del Recorrido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(5, 8);
            label1.Name = "label1";
            label1.Size = new Size(121, 24);
            label1.TabIndex = 0;
            label1.Text = "Recorridos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(lblLaUnión);
            panel1.Controls.Add(lblMorazán);
            panel1.Controls.Add(lblSanMiguel);
            panel1.Controls.Add(lblUsulután);
            panel1.Controls.Add(lblLaPaz);
            panel1.Controls.Add(lblSanVicente);
            panel1.Controls.Add(lblCabañas);
            panel1.Controls.Add(lblCuscatlán);
            panel1.Controls.Add(lblChalatenango);
            panel1.Controls.Add(lblSanSalvador);
            panel1.Controls.Add(lblLaLibertad);
            panel1.Controls.Add(lblSonsonate);
            panel1.Controls.Add(lblAhuachapán);
            panel1.Controls.Add(lblSantaAna);
            panel1.Location = new Point(-1, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(836, 482);
            panel1.TabIndex = 16;
            // 
            // lblLaUnión
            // 
            lblLaUnión.AutoSize = true;
            lblLaUnión.BackColor = Color.RoyalBlue;
            lblLaUnión.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLaUnión.ForeColor = Color.White;
            lblLaUnión.Location = new Point(708, 306);
            lblLaUnión.Name = "lblLaUnión";
            lblLaUnión.Size = new Size(70, 18);
            lblLaUnión.TabIndex = 43;
            lblLaUnión.Text = "La Unión";
            // 
            // lblMorazán
            // 
            lblMorazán.AutoSize = true;
            lblMorazán.BackColor = Color.RoyalBlue;
            lblMorazán.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMorazán.ForeColor = Color.White;
            lblMorazán.Location = new Point(647, 222);
            lblMorazán.Name = "lblMorazán";
            lblMorazán.Size = new Size(68, 18);
            lblMorazán.TabIndex = 42;
            lblMorazán.Text = "Morazán";
            // 
            // lblSanMiguel
            // 
            lblSanMiguel.AutoSize = true;
            lblSanMiguel.BackColor = Color.RoyalBlue;
            lblSanMiguel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSanMiguel.ForeColor = Color.White;
            lblSanMiguel.Location = new Point(582, 321);
            lblSanMiguel.Name = "lblSanMiguel";
            lblSanMiguel.Size = new Size(86, 18);
            lblSanMiguel.TabIndex = 41;
            lblSanMiguel.Text = "San Miguel";
            // 
            // lblUsulután
            // 
            lblUsulután.AutoSize = true;
            lblUsulután.BackColor = Color.RoyalBlue;
            lblUsulután.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsulután.ForeColor = Color.White;
            lblUsulután.Location = new Point(502, 374);
            lblUsulután.Name = "lblUsulután";
            lblUsulután.Size = new Size(67, 18);
            lblUsulután.TabIndex = 40;
            lblUsulután.Text = "Usulután";
            // 
            // lblLaPaz
            // 
            lblLaPaz.AutoSize = true;
            lblLaPaz.BackColor = Color.RoyalBlue;
            lblLaPaz.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLaPaz.ForeColor = Color.White;
            lblLaPaz.Location = new Point(363, 340);
            lblLaPaz.Name = "lblLaPaz";
            lblLaPaz.Size = new Size(57, 18);
            lblLaPaz.TabIndex = 39;
            lblLaPaz.Text = "La Paz";
            // 
            // lblSanVicente
            // 
            lblSanVicente.AutoSize = true;
            lblSanVicente.BackColor = Color.RoyalBlue;
            lblSanVicente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSanVicente.ForeColor = Color.White;
            lblSanVicente.Location = new Point(431, 275);
            lblSanVicente.Name = "lblSanVicente";
            lblSanVicente.Size = new Size(93, 18);
            lblSanVicente.TabIndex = 38;
            lblSanVicente.Text = "San Vicente";
            // 
            // lblCabañas
            // 
            lblCabañas.AutoSize = true;
            lblCabañas.BackColor = Color.RoyalBlue;
            lblCabañas.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCabañas.ForeColor = Color.White;
            lblCabañas.Location = new Point(452, 183);
            lblCabañas.Name = "lblCabañas";
            lblCabañas.Size = new Size(72, 18);
            lblCabañas.TabIndex = 37;
            lblCabañas.Text = "Cabañas";
            // 
            // lblCuscatlán
            // 
            lblCuscatlán.AutoSize = true;
            lblCuscatlán.BackColor = Color.RoyalBlue;
            lblCuscatlán.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCuscatlán.ForeColor = Color.White;
            lblCuscatlán.Location = new Point(343, 200);
            lblCuscatlán.Name = "lblCuscatlán";
            lblCuscatlán.Size = new Size(77, 18);
            lblCuscatlán.TabIndex = 36;
            lblCuscatlán.Text = "Cuscatlán";
            // 
            // lblChalatenango
            // 
            lblChalatenango.AutoSize = true;
            lblChalatenango.BackColor = Color.RoyalBlue;
            lblChalatenango.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChalatenango.ForeColor = Color.White;
            lblChalatenango.Location = new Point(302, 86);
            lblChalatenango.Name = "lblChalatenango";
            lblChalatenango.Size = new Size(105, 18);
            lblChalatenango.TabIndex = 35;
            lblChalatenango.Text = "Chalatenango";
            // 
            // lblSanSalvador
            // 
            lblSanSalvador.AutoSize = true;
            lblSanSalvador.BackColor = Color.RoyalBlue;
            lblSanSalvador.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSanSalvador.ForeColor = Color.White;
            lblSanSalvador.Location = new Point(282, 234);
            lblSanSalvador.Name = "lblSanSalvador";
            lblSanSalvador.Size = new Size(102, 18);
            lblSanSalvador.TabIndex = 34;
            lblSanSalvador.Text = "San Salvador";
            // 
            // lblLaLibertad
            // 
            lblLaLibertad.AutoSize = true;
            lblLaLibertad.BackColor = Color.RoyalBlue;
            lblLaLibertad.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLaLibertad.ForeColor = Color.White;
            lblLaLibertad.Location = new Point(224, 275);
            lblLaLibertad.Name = "lblLaLibertad";
            lblLaLibertad.Size = new Size(88, 18);
            lblLaLibertad.TabIndex = 33;
            lblLaLibertad.Text = "La Libertad";
            // 
            // lblSonsonate
            // 
            lblSonsonate.AutoSize = true;
            lblSonsonate.BackColor = Color.RoyalBlue;
            lblSonsonate.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSonsonate.ForeColor = Color.White;
            lblSonsonate.Location = new Point(126, 265);
            lblSonsonate.Name = "lblSonsonate";
            lblSonsonate.Size = new Size(83, 18);
            lblSonsonate.TabIndex = 32;
            lblSonsonate.Text = "Sonsonate";
            // 
            // lblAhuachapán
            // 
            lblAhuachapán.AutoSize = true;
            lblAhuachapán.BackColor = Color.RoyalBlue;
            lblAhuachapán.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAhuachapán.ForeColor = Color.White;
            lblAhuachapán.Location = new Point(45, 211);
            lblAhuachapán.Name = "lblAhuachapán";
            lblAhuachapán.Size = new Size(95, 18);
            lblAhuachapán.TabIndex = 31;
            lblAhuachapán.Text = "Ahuachapán";
            // 
            // lblSantaAna
            // 
            lblSantaAna.AutoSize = true;
            lblSantaAna.BackColor = Color.RoyalBlue;
            lblSantaAna.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSantaAna.ForeColor = Color.White;
            lblSantaAna.Location = new Point(179, 97);
            lblSantaAna.Name = "lblSantaAna";
            lblSantaAna.Size = new Size(80, 18);
            lblSantaAna.TabIndex = 30;
            lblSantaAna.Text = "Santa Ana";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Red;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = SystemColors.ControlLightLight;
            btnCerrar.Location = new Point(784, 7);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(38, 25);
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(833, 585);
            Controls.Add(panel1);
            Controls.Add(panel2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label2;
        private Label label1;
        private ComboBox cmbDepartamento;
        private Button btnBuscar;
        private Panel panel1;
        private Label lblLaUnión;
        private Label lblMorazán;
        private Label lblSanMiguel;
        private Label lblUsulután;
        private Label lblLaPaz;
        private Label lblSanVicente;
        private Label lblCabañas;
        private Label lblCuscatlán;
        private Label lblChalatenango;
        private Label lblSanSalvador;
        private Label lblLaLibertad;
        private Label lblSonsonate;
        private Label lblAhuachapán;
        private Label lblSantaAna;
        private Button btnProfundidad;
        private Button btnAnchura;
        private Button btnCerrar;
    }
}
