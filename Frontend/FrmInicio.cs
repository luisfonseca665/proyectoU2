using System;
using System.Windows.Forms;
using proyectoU2.Frontend;

namespace proyectoU2
{
    public partial class FrmInicio : Form
    {
        private Form factivo = null;

        public FrmInicio()
        {
            InitializeComponent();
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

            pnlInicio.Controls.Clear();
            pnlInicio.Controls.Add(activo);

            activo.BringToFront();
            activo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPanel(new FrmRefacciones());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPanel(new FrmServicios());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}