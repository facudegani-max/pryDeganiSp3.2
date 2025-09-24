namespace pryDeganiSp3._2
{
    partial class frmConsulta
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
            lblConsulta = new Label();
            cmbConsulta = new ComboBox();
            lblOrigen = new Label();
            rdbNacional = new RadioButton();
            rdbInternacional = new RadioButton();
            lstResultados = new ListBox();
            SuspendLayout();
            // 
            // lblConsulta
            // 
            lblConsulta.AutoSize = true;
            lblConsulta.Location = new Point(61, 46);
            lblConsulta.Name = "lblConsulta";
            lblConsulta.Size = new Size(54, 15);
            lblConsulta.TabIndex = 0;
            lblConsulta.Text = "Consulta";
            // 
            // cmbConsulta
            // 
            cmbConsulta.FormattingEnabled = true;
            cmbConsulta.Items.AddRange(new object[] { "P", "F", "R" });
            cmbConsulta.Location = new Point(61, 73);
            cmbConsulta.Name = "cmbConsulta";
            cmbConsulta.Size = new Size(121, 23);
            cmbConsulta.TabIndex = 1;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(61, 120);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(43, 15);
            lblOrigen.TabIndex = 2;
            lblOrigen.Text = "Origen";
            // 
            // rdbNacional
            // 
            rdbNacional.AutoSize = true;
            rdbNacional.Location = new Point(61, 138);
            rdbNacional.Name = "rdbNacional";
            rdbNacional.Size = new Size(72, 19);
            rdbNacional.TabIndex = 3;
            rdbNacional.TabStop = true;
            rdbNacional.Text = "Nacional";
            rdbNacional.UseVisualStyleBackColor = true;
            // 
            // rdbInternacional
            // 
            rdbInternacional.AutoSize = true;
            rdbInternacional.Location = new Point(61, 163);
            rdbInternacional.Name = "rdbInternacional";
            rdbInternacional.Size = new Size(94, 19);
            rdbInternacional.TabIndex = 4;
            rdbInternacional.TabStop = true;
            rdbInternacional.Text = "Internacional";
            rdbInternacional.UseVisualStyleBackColor = true;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.ItemHeight = 15;
            lstResultados.Location = new Point(12, 202);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(243, 64);
            lstResultados.TabIndex = 6;
            // 
            // frmConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 286);
            Controls.Add(lstResultados);
            Controls.Add(rdbInternacional);
            Controls.Add(rdbNacional);
            Controls.Add(lblOrigen);
            Controls.Add(cmbConsulta);
            Controls.Add(lblConsulta);
            Name = "frmConsulta";
            Text = "Consulta de Repuestos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConsulta;
        private ComboBox cmbConsulta;
        private Label lblOrigen;
        private RadioButton rdbNacional;
        private RadioButton rdbInternacional;
        private ListBox lstResultados;
    }
}