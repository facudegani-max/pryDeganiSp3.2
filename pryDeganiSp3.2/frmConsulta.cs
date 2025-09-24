using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static pryDeganiSp3._2.frmMain;

namespace pryDeganiSp3._2
{
    public partial class frmConsulta : Form
    {
        
        private Repuesto[] repuestos;
        private int cantidad;

        // Constructor con parámetros
        public frmConsulta(Repuesto[] repuestosCargados, int cantidadCargados)
        {
            InitializeComponent();

            repuestos = repuestosCargados;
            cantidad = cantidadCargados;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            char marcaConsulta = cmbConsulta.Text.Length > 0 ? cmbConsulta.Text[0] : '\0';
            char origenConsulta = rdbNacional.Checked ? 'N' : 'I';

            // Validar marca seleccionada
            if (!(marcaConsulta == 'P' || marcaConsulta == 'F' || marcaConsulta == 'R'))
            {
                MessageBox.Show("Seleccione una marca válida (P, F o R).");
                return;
            }

            lstResultados.Items.Clear();

            for (int i = 0; i < cantidad; i++)
            {
                Repuesto r = repuestos[i];
                if (r.Marca == marcaConsulta && r.Origen == origenConsulta)
                {
                    string resultado = $"Nro: {r.Numero}, Desc: {r.Descripcion}, Precio: ${r.Precio:F2}";
                    lstResultados.Items.Add(resultado);
                }
            }

            if (lstResultados.Items.Count == 0)
            {
                lstResultados.Items.Add("No se encontraron repuestos.");
            }
        }
    }
}

        
    

