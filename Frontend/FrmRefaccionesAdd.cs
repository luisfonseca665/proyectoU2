using System;
using System.Windows.Forms;
using proyectoU2.Backend;

namespace proyectoU2.Frontend
{
    public partial class FrmRefaccionesAdd : Form
    {
        private bool _esEdicion = false;
        public Action onGuardar;

        public FrmRefaccionesAdd()
        {
            InitializeComponent();
            _esEdicion = false;
        }

        public FrmRefaccionesAdd(string codigo)
        {
            InitializeComponent();
            _esEdicion = true;
            txtCodigo.Enabled = false;

            CargarDatos(codigo);
        }

        private void CargarDatos(string codigo)
        {
            Refacciones r = RefaccionesController.ObtenerPorCodigo(codigo);

            if (r != null)
            {
                txtCodigo.Text = r.codigo_refaccion;
                txtNombre.Text = r.nombre;
                txtMarca.Text = r.marca;
                txtPrecio.Text = r.precio_unitario.ToString();
                txtStockActual.Text = r.stock_actual.ToString();
                txtStockMinimo.Text = r.stock_minimo.ToString();
                txtProveedor.Text = r.proveedor;
            }
            else
            {
                MessageBox.Show("Error: No se encontró la refacción en la base de datos.");
                this.Close();
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El Código y el Nombre son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal precio = 0;
            int stock = 0;
            int stockMin = 0;

            if (!decimal.TryParse(txtPrecio.Text, out precio)) precio = 0;
            if (!int.TryParse(txtStockActual.Text, out stock)) stock = 0;
            if (!int.TryParse(txtStockMinimo.Text, out stockMin)) stockMin = 0;

            bool exito = false;
            if (_esEdicion)
            {
                exito = RefaccionesController.EditarRefaccion(
                    txtCodigo.Text,
                    txtNombre.Text,
                    txtMarca.Text,
                    precio,
                    stock,
                    stockMin,
                    txtProveedor.Text
                );
            }
            else
            {
                exito = RefaccionesController.AgregarRefaccion(
                    txtCodigo.Text,
                    txtNombre.Text,
                    txtMarca.Text,
                    precio,
                    stock,
                    stockMin,
                    txtProveedor.Text
                );
            }

            if (exito)
            {
                MessageBox.Show("Guardado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (onGuardar != null)
                {
                    onGuardar.Invoke();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Error al guardar. Verifica que el código no esté repetido o la conexión a la BD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}