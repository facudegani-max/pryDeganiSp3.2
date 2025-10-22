namespace pryDeganiSp3._2
{
    partial class frmMain
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
            cmbMarca = new ComboBox();
            lblMarca = new Label();
            lblOrigen = new Label();
            cmbOrigen = new ComboBox();
            lblNumero = new Label();
            txtNumero = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            btnAgregar = new Button();
            btnConsultar = new Button();
            grpRegistro = new GroupBox();
            grpConsulta = new GroupBox();
            lstResultados = new ListBox();
            label1 = new Label();
            rdbInternacional = new RadioButton();
            rdbNacional = new RadioButton();
            cmbConsulta = new ComboBox();
            lblConsulta = new Label();
            btnSalir = new Button();
            grpRegistro.SuspendLayout();
            grpConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // cmbMarca
            // 
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "P (Peugeot)", "F (Fiat)", "R (Renault)" });
            cmbMarca.Location = new Point(154, 50);
            cmbMarca.Margin = new Padding(3, 4, 3, 4);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(138, 28);
            cmbMarca.TabIndex = 0;
            cmbMarca.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(61, 53);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(50, 20);
            lblMarca.TabIndex = 1;
            lblMarca.Text = "Marca";
            lblMarca.Click += lblMarca_Click;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(61, 102);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(54, 20);
            lblOrigen.TabIndex = 2;
            lblOrigen.Text = "Origen";
            lblOrigen.Click += label1_Click;
            // 
            // cmbOrigen
            // 
            cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Items.AddRange(new object[] { "N (Nacional)", "I (Importado)" });
            cmbOrigen.Location = new Point(154, 99);
            cmbOrigen.Margin = new Padding(3, 4, 3, 4);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(138, 28);
            cmbOrigen.TabIndex = 3;
            cmbOrigen.SelectedIndexChanged += cmbOrigen_SelectedIndexChanged;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(61, 151);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(63, 20);
            lblNumero.TabIndex = 4;
            lblNumero.Text = "Numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(154, 144);
            txtNumero.Margin = new Padding(3, 4, 3, 4);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(114, 27);
            txtNumero.TabIndex = 5;
            txtNumero.TextChanged += txtNumero_TextChanged;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(61, 200);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 6;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(154, 197);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(114, 27);
            txtDescripcion.TabIndex = 7;
            txtDescripcion.KeyPress += txtDescripcion_KeyPress;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(61, 249);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(154, 246);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(114, 27);
            txtPrecio.TabIndex = 9;
            txtPrecio.TextChanged += textBox1_TextChanged;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Tomato;
            btnAgregar.Location = new Point(164, 621);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(127, 62);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.Tomato;
            btnConsultar.Location = new Point(297, 621);
            btnConsultar.Margin = new Padding(3, 4, 3, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(127, 62);
            btnConsultar.TabIndex = 11;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // grpRegistro
            // 
            grpRegistro.BackColor = SystemColors.ScrollBar;
            grpRegistro.Controls.Add(cmbOrigen);
            grpRegistro.Controls.Add(lblMarca);
            grpRegistro.Controls.Add(cmbMarca);
            grpRegistro.Controls.Add(txtDescripcion);
            grpRegistro.Controls.Add(lblNumero);
            grpRegistro.Controls.Add(txtNumero);
            grpRegistro.Controls.Add(lblPrecio);
            grpRegistro.Controls.Add(txtPrecio);
            grpRegistro.Controls.Add(lblDescripcion);
            grpRegistro.Controls.Add(lblOrigen);
            grpRegistro.Location = new Point(12, 12);
            grpRegistro.Name = "grpRegistro";
            grpRegistro.Size = new Size(473, 304);
            grpRegistro.TabIndex = 12;
            grpRegistro.TabStop = false;
            grpRegistro.Text = "Registro ";
            // 
            // grpConsulta
            // 
            grpConsulta.BackColor = SystemColors.ScrollBar;
            grpConsulta.Controls.Add(lstResultados);
            grpConsulta.Controls.Add(label1);
            grpConsulta.Controls.Add(rdbInternacional);
            grpConsulta.Controls.Add(rdbNacional);
            grpConsulta.Controls.Add(cmbConsulta);
            grpConsulta.Controls.Add(lblConsulta);
            grpConsulta.Location = new Point(12, 322);
            grpConsulta.Name = "grpConsulta";
            grpConsulta.Size = new Size(473, 281);
            grpConsulta.TabIndex = 13;
            grpConsulta.TabStop = false;
            grpConsulta.Text = "Consulta de Repuestos";
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(6, 181);
            lstResultados.Margin = new Padding(3, 4, 3, 4);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(461, 84);
            lstResultados.TabIndex = 7;
            lstResultados.SelectedIndexChanged += lstResultados_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 109);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 6;
            label1.Text = "Origen";
            // 
            // rdbInternacional
            // 
            rdbInternacional.AutoSize = true;
            rdbInternacional.Location = new Point(141, 137);
            rdbInternacional.Margin = new Padding(3, 4, 3, 4);
            rdbInternacional.Name = "rdbInternacional";
            rdbInternacional.Size = new Size(116, 24);
            rdbInternacional.TabIndex = 5;
            rdbInternacional.TabStop = true;
            rdbInternacional.Text = "Internacional";
            rdbInternacional.UseVisualStyleBackColor = true;
            rdbInternacional.CheckedChanged += rdbInternacional_CheckedChanged;
            // 
            // rdbNacional
            // 
            rdbNacional.AutoSize = true;
            rdbNacional.Location = new Point(141, 109);
            rdbNacional.Margin = new Padding(3, 4, 3, 4);
            rdbNacional.Name = "rdbNacional";
            rdbNacional.Size = new Size(89, 24);
            rdbNacional.TabIndex = 4;
            rdbNacional.TabStop = true;
            rdbNacional.Text = "Nacional";
            rdbNacional.UseVisualStyleBackColor = true;
            rdbNacional.CheckedChanged += rdbNacional_CheckedChanged;
            // 
            // cmbConsulta
            // 
            cmbConsulta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConsulta.FormattingEnabled = true;
            cmbConsulta.Items.AddRange(new object[] { "P", "F", "R" });
            cmbConsulta.Location = new Point(141, 50);
            cmbConsulta.Margin = new Padding(3, 4, 3, 4);
            cmbConsulta.Name = "cmbConsulta";
            cmbConsulta.Size = new Size(138, 28);
            cmbConsulta.TabIndex = 2;
            cmbConsulta.SelectedIndexChanged += cmbConsulta_SelectedIndexChanged;
            // 
            // lblConsulta
            // 
            lblConsulta.AutoSize = true;
            lblConsulta.Location = new Point(61, 53);
            lblConsulta.Name = "lblConsulta";
            lblConsulta.Size = new Size(66, 20);
            lblConsulta.TabIndex = 1;
            lblConsulta.Text = "Consulta";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Tomato;
            btnSalir.Location = new Point(430, 621);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(127, 62);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 696);
            Controls.Add(btnSalir);
            Controls.Add(grpConsulta);
            Controls.Add(grpRegistro);
            Controls.Add(btnConsultar);
            Controls.Add(btnAgregar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Repuestos Ingresados";
            Load += frmMain_Load;
            grpRegistro.ResumeLayout(false);
            grpRegistro.PerformLayout();
            grpConsulta.ResumeLayout(false);
            grpConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbMarca;
        private Label lblMarca;
        private Label lblOrigen;
        private ComboBox cmbOrigen;
        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Button btnAgregar;
        private Button btnConsultar;
        private GroupBox grpRegistro;
        private GroupBox grpConsulta;
        private Label lblConsulta;
        private ComboBox cmbConsulta;
        private RadioButton rdbNacional;
        private RadioButton rdbInternacional;
        private Label label1;
        private ListBox lstResultados;
        private Button btnSalir;
    }
}
