using proyectoU2.Backend;
using System;
using System.Data;
using System.Windows.Forms;

namespace proyectoU2.Frontend
{
    public partial class FrmRefacciones : Form
    {
        private Form factivo = null;
        public FrmRefacciones()
        {
            InitializeComponent();
        }

        private void CargarTabla()
        {
            try
            {
                dgvRefacciones.DataSource = RefaccionesController.ObtenerRefacciones();

                dgvRefacciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvRefacciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvRefacciones.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormPanel(Form activo)
        {
            if (factivo != null)
            {
                factivo.Close();
                factivo.Dispose();
            }

            factivo = activo;

            activo.TopLevel = false;
            activo.FormBorderStyle = FormBorderStyle.None;
            activo.Dock = DockStyle.Fill;

            pnleditaragregar.Controls.Clear();
            pnleditaragregar.Controls.Add(activo);

            activo.BringToFront();
            activo.Show();
        }


        private void FrmRefacciones_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            FrmRefaccionesAdd frm = new FrmRefaccionesAdd();

            frm.onGuardar = CargarTabla;

            FormPanel(frm);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRefacciones.CurrentRow != null)
            {
                string codigo = dgvRefacciones.CurrentRow.Cells["codigo_refaccion"].Value?.ToString();

                if (!string.IsNullOrEmpty(codigo))
                {
                    DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar la refacción: {codigo}?",
                        "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        if (RefaccionesController.EliminarRefaccion(codigo))
                        {
                            MessageBox.Show("Registro eliminado con éxito.");
                            CargarTabla();
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error al intentar eliminar el registro.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila de la tabla para eliminar.");
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dgvRefacciones.CurrentRow != null)
            {
                string codigo = dgvRefacciones.CurrentRow.Cells["codigo_refaccion"].Value?.ToString();

                if (!string.IsNullOrEmpty(codigo))
                {
                    FrmRefaccionesAdd frm = new FrmRefaccionesAdd(codigo);

                    frm.onGuardar = CargarTabla;
                    FormPanel(frm);
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar.");
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            btneditar_Click(sender, e);
        }

        private void dgvRefacciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //FrmRefaccionesAdd frm = new FrmRefaccionesAdd();
            //FormPanel(frm);
        }

        private void btnVer_Click_1(object sender, EventArgs e)
        {
            btneditar_Click(sender, e);
        }
    }
}