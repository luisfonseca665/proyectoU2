using proyectoU2.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyectoU2.Frontend
{
    public partial class FrmServicios : Form
    {
        private Form factivo = null;
        public FrmServicios()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvServicios.CurrentRow != null)
            {
                string valorCelda = dgvServicios.CurrentRow.Cells["clave_servicio"].Value?.ToString();

                if (int.TryParse(valorCelda, out int idServicio))
                {
                    if (MessageBox.Show("¿Eliminar servicio #" + idServicio + "?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (ServiciosController.EliminarServicio(idServicio))
                        {
                            MessageBox.Show("Servicio eliminado.");
                            CargarTabla();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar (quizás ya está en uso).");
                        }
                    }
                }
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dgvServicios.CurrentRow != null)
            {
                string valorCelda = dgvServicios.CurrentRow.Cells["clave_servicio"].Value?.ToString();

                if (int.TryParse(valorCelda, out int idServicio))
                {
                    FrmServiciosadd frm = new FrmServiciosadd(idServicio);
                    frm.onGuardar = CargarTabla;

                    FormPanel(frm);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un servicio para editar.");
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            FrmServiciosadd frm = new FrmServiciosadd();
            frm.onGuardar = CargarTabla;

            FormPanel(frm);
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            btneditar_Click(sender, e);
        }

        private void FrmServicios_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void CargarTabla()
        {
            try
            {
                dgvServicios.DataSource = ServiciosController.ObtenerServicios();
                dgvServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvServicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvServicios.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message);
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
    }
}
