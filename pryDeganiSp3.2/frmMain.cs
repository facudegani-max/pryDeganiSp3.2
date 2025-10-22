using System;
using System.Globalization;
using System.Windows.Forms;

namespace pryDeganiSp3._2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Clase que representa un repuesto
        public class Repuesto
        {
            public char Marca { get; set; }          // P, F, R
            public char Origen { get; set; }         // N, I
            public int Numero { get; set; }          // Hasta 6 dígitos
            public string Descripcion { get; set; }  // Máx 50 caracteres
            public float Precio { get; set; }        // Precio float
        }

        // Arreglo para almacenar hasta 100 repuestos
        public Repuesto[] repuestos = new Repuesto[100];
        public int cantidadRepuestos = 0;

        // --------- INICIALIZACIÓN ----------
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Combos superiores (carga)
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;

            if (cmbMarca.Items.Count == 0)
            {
                cmbMarca.Items.AddRange(new string[]
                {
                    "P - Peugeot",
                    "F - Fiat",
                    "R - Renault"
                });
            }

            if (cmbOrigen.Items.Count == 0)
            {
                cmbOrigen.Items.AddRange(new string[]
                {
                    "N - Nacional",
                    "I - Importado"
                });
            }

            // Controles de límites
            txtNumero.MaxLength = 6;
            txtDescripcion.MaxLength = 50;

            // Controles de consulta (abajo)
            cmbConsulta.DropDownStyle = ComboBoxStyle.DropDownList;
            if (cmbConsulta.Items.Count == 0)
            {
                cmbConsulta.Items.AddRange(new string[]
                {
                    "P - Peugeot",
                    "F - Fiat",
                    "R - Renault"
                });
            }

            // ListBox resultados
            lstResultados.Items.Clear();
        }

        // --------- CARGA ----------
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarRepuesto();
        }

        private void AgregarRepuesto()
        {
            // Verificar límite
            if (cantidadRepuestos >= 100)
            {
                MessageBox.Show("No se pueden ingresar más de 100 repuestos.", "Capacidad completa",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener valores de los controles
            char marca = cmbMarca.Text.Length > 0 ? cmbMarca.Text[0] : '\0';
            char origen = cmbOrigen.Text.Length > 0 ? cmbOrigen.Text[0] : '\0';
            string descripcion = (txtDescripcion.Text ?? "").Trim();
            string numeroTexto = (txtNumero.Text ?? "").Trim();
            string precioTexto = (txtPrecio.Text ?? "").Trim();

            // Validaciones
            if (!(marca == 'P' || marca == 'F' || marca == 'R'))
            {
                MessageBox.Show("Seleccione una marca válida (P, F, R).");
                cmbMarca.DroppedDown = true;
                return;
            }

            if (!(origen == 'N' || origen == 'I'))
            {
                MessageBox.Show("Seleccione un origen válido (N, I).");
                cmbOrigen.DroppedDown = true;
                return;
            }

            if (!int.TryParse(numeroTexto, out int numero) || numero < 0 || numero > 999999)
            {
                MessageBox.Show("Número inválido. Debe ser numérico, positivo y hasta 6 dígitos.");
                txtNumero.Focus();
                return;
            }

            if (descripcion.Length == 0 || descripcion.Length > 50)
            {
                MessageBox.Show("La descripción debe tener entre 1 y 50 caracteres.");
                txtDescripcion.Focus();
                return;
            }

            // Permitir separador decimal , o .
            // Normalizamos a punto para parsear invariante:
            string precioNormalizado = precioTexto.Replace(',', '.');
            if (!float.TryParse(precioNormalizado, NumberStyles.Float, CultureInfo.InvariantCulture, out float precio) || precio < 0)
            {
                MessageBox.Show("Precio inválido. Debe ser un número positivo (use . o , como separador decimal).");
                txtPrecio.Focus();
                return;
            }

            // Verificar número duplicado
            for (int i = 0; i < cantidadRepuestos; i++)
            {
                if (repuestos[i] != null && repuestos[i].Numero == numero)
                {
                    MessageBox.Show("Ya existe un repuesto con ese número.");
                    txtNumero.Focus();
                    return;
                }
            }

            // Agregar al arreglo
            repuestos[cantidadRepuestos] = new Repuesto
            {
                Marca = marca,
                Origen = origen,
                Numero = numero,
                Descripcion = descripcion,
                Precio = precio
            };

            cantidadRepuestos++;

            MessageBox.Show("Repuesto agregado correctamente.", "OK",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();

            if (cantidadRepuestos == 100)
            {
                MessageBox.Show("Se completó la carga de 100 repuestos. No se permiten más ingresos.",
                    "Capacidad completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LimpiarCampos()
        {
            cmbMarca.SelectedIndex = -1;
            cmbOrigen.SelectedIndex = -1;
            txtNumero.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            cmbMarca.Focus();
        }

        // --------- CONSULTA ----------
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();

            if (cantidadRepuestos == 0)
            {
                MessageBox.Show("No hay repuestos cargados para consultar.", "Consulta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Marca seleccionada en combo inferior
            if (cmbConsulta.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una marca para consultar (P, F o R).");
                cmbConsulta.DroppedDown = true;
                return;
            }
            char marcaFiltro = cmbConsulta.Text[0];

            // Origen por radio button
            char origenFiltro;
            if (rdbNacional.Checked)
                origenFiltro = 'N';
            else if (rdbInternacional.Checked)
                origenFiltro = 'I';
            else
            {
                MessageBox.Show("Seleccione el origen (Nacional o Importado).");
                return;
            }

            // Filtrar y listar
            int encontrados = 0;
            for (int i = 0; i < cantidadRepuestos; i++)
            {
                var r = repuestos[i];
                if (r != null && r.Marca == marcaFiltro && r.Origen == origenFiltro)
                {
                    // Formato: Numero - Descripción - Precio
                    // Mostramos precio con 2 decimales
                    string linea = $"{r.Numero:000000} - {r.Descripcion} - ${r.Precio.ToString("0.00", CultureInfo.InvariantCulture)}";
                    lstResultados.Items.Add(linea);
                    encontrados++;
                }
            }

            if (encontrados == 0)
            {
                lstResultados.Items.Add("Sin resultados para esa marca y origen.");
            }
        }

        // --------- EVENTOS DE ENTRADA ----------
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y tecla de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

            // Limitar a 6 caracteres
            TextBox textBox = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && textBox.Text.Length >= 6)
                e.Handled = true;
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Limitar a 50 caracteres
            TextBox textBox = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && textBox.Text.Length >= 50)
                e.Handled = true;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir dígitos, backspace y un solo separador decimal (coma o punto)
            TextBox tb = sender as TextBox;
            char ch = e.KeyChar;

            if (char.IsControl(ch))
                return;

            if (char.IsDigit(ch))
                return;

            if (ch == '.' || ch == ',')
            {
                if (tb.Text.Contains(".") || tb.Text.Contains(","))
                    e.Handled = true; // ya hay separador
                return;
            }

            // cualquier otro caracter no permitido
            e.Handled = true;
        }

        // --------- OTROS HANDLERS (opcionales/limpios) ----------
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lblMarca_Click(object sender, EventArgs e) { }
        private void cmbConsulta_SelectedIndexChanged(object sender, EventArgs e) { }
        private void rdbNacional_CheckedChanged(object sender, EventArgs e) { }
        private void rdbInternacional_CheckedChanged(object sender, EventArgs e) { }
        private void lstResultados_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtNumero_TextChanged(object sender, EventArgs e) { }
    }
}

