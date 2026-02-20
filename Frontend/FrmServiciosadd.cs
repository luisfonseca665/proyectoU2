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
    public partial class FrmServiciosadd : Form
    {
        public Action onGuardar;

        private bool _esEdicion = false;
        private int _idServicio = 0;
        public FrmServiciosadd()
        {
            InitializeComponent();
            _esEdicion = false;
        }

        private void CargarDatos(int id)
        {
            Servicios s = ServiciosController.ObtenerPorClave(id);
            if (s != null)
            {
                txtNombre.Text = s.nombre_servicio;
                txtDescripcion.Text = s.descripcion;
                txtCosto.Text = s.costo_base.ToString();
                txtTiempo.Text = s.tiempo_estimado.ToString();
            }
            else
            {
                MessageBox.Show("No se encontró el servicio.");
                this.Close();
            }
        }

        public FrmServiciosadd(int idServicio)
        {
            InitializeComponent();
            _esEdicion = true;
            _idServicio = idServicio;

            CargarDatos(idServicio);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                return;
            }

            decimal costo = 0;
            int tiempo = 0;
            decimal.TryParse(txtCosto.Text, out costo);
            int.TryParse(txtTiempo.Text, out tiempo);

            bool exito = false;

            if (_esEdicion)
            {
                exito = ServiciosController.EditarServicio(_idServicio, txtNombre.Text, txtDescripcion.Text, costo, tiempo);
            }
            else
            {
                exito = ServiciosController.AgregarServicio(txtNombre.Text, txtDescripcion.Text, costo, tiempo);
            }

            if (exito)
            {
                MessageBox.Show("Guardado con éxito.");
                if (onGuardar != null) onGuardar.Invoke();

                this.Close();
            }
            else
            {
                MessageBox.Show("Error al guardar.");
            }
        }
    }
}
