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
            public char Marca { get; set; }       // P, F, R
            public char Origen { get; set; }      // N, I
            public int Numero { get; set; }       // Hasta 6 d�gitos
            public string Descripcion { get; set; } // M�x 50 caracteres
            public float Precio { get; set; }     // Precio float
        }

        // Arreglo para almacenar hasta 100 repuestos
        public Repuesto[] repuestos = new Repuesto[100];
        public int cantidadRepuestos = 0;

        private void AgregarRepuesto()
        {
            // Verificar l�mite
            if (cantidadRepuestos >= 100)
            {
                MessageBox.Show("No se pueden ingresar m�s de 100 repuestos.");
                return;
            }

            // Obtener valores de los controles
            char marca = cmbMarca.Text.Length > 0 ? cmbMarca.Text[0] : '\0';
            char origen = cmbOrigen.Text.Length > 0 ? cmbOrigen.Text[0] : '\0';
            string descripcion = txtDescripcion.Text.Trim();
            string numeroTexto = txtNumero.Text.Trim();
            string precioTexto = txtPrecio.Text.Trim();

            // Validaciones
            if (!(marca == 'P' || marca == 'F' || marca == 'R'))
            {
                MessageBox.Show("Seleccione una marca v�lida (P, F, R).");
                return;
            }

            if (!(origen == 'N' || origen == 'I'))
            {
                MessageBox.Show("Seleccione un origen v�lido (N, I).");
                return;
            }

            if (!int.TryParse(numeroTexto, out int numero) || numero < 0 || numero > 999999)
            {
                MessageBox.Show("N�mero inv�lido. Debe ser num�rico, positivo y hasta 6 d�gitos.");
                return;
            }

            if (descripcion.Length == 0 || descripcion.Length > 50)
            {
                MessageBox.Show("La descripci�n debe tener entre 1 y 50 caracteres.");
                return;
            }

            if (!float.TryParse(precioTexto, out float precio) || precio < 0)
            {
                MessageBox.Show("Precio inv�lido. Debe ser un n�mero positivo.");
                return;
            }

            // Verificar n�mero duplicado
            for (int i = 0; i < cantidadRepuestos; i++)
            {
                if (repuestos[i].Numero == numero)
                {
                    MessageBox.Show("Ya existe un repuesto con ese n�mero.");
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

            MessageBox.Show("Repuesto agregado correctamente.");
            LimpiarCampos(); // Opcional: m�todo para limpiar los inputs
        }

        private void LimpiarCampos()
        {
            cmbMarca.SelectedIndex = -1;
            cmbOrigen.SelectedIndex = -1;
            txtNumero.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarRepuesto();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsulta consultaForm = new frmConsulta(repuestos, cantidadRepuestos);
            consultaForm.ShowDialog();
        }
    }
}
