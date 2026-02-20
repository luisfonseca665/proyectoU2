namespace proyectoU2.Frontend
{
    partial class FrmServiciosadd
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
            btnGuardar = new Button();
            txtTiempo = new TextBox();
            txtCosto = new TextBox();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(128, 64, 0);
            btnGuardar.Image = Properties.Resources.icons8_save_100__1_;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(446, 269);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(404, 81);
            btnGuardar.TabIndex = 29;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(655, 95);
            txtTiempo.Margin = new Padding(4, 3, 4, 3);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(194, 34);
            txtTiempo.TabIndex = 27;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(536, 10);
            txtCosto.Margin = new Padding(4, 3, 4, 3);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(313, 34);
            txtCosto.TabIndex = 26;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(16, 149);
            txtDescripcion.Margin = new Padding(4, 3, 4, 3);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(403, 200);
            txtDescripcion.TabIndex = 24;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(130, 10);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(289, 34);
            txtNombre.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(446, 13);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(75, 28);
            label7.TabIndex = 21;
            label7.Text = "Costo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(446, 95);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(190, 28);
            label6.TabIndex = 20;
            label6.Text = "Tiempo estimado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 102);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 28);
            label3.TabIndex = 17;
            label3.Text = "Descripcion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 10);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 16;
            label2.Text = "Nombre:";
            // 
            // FrmServiciosadd
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(884, 380);
            Controls.Add(btnGuardar);
            Controls.Add(txtTiempo);
            Controls.Add(txtCosto);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmServiciosadd";
            Text = "FrmServiciosadd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private TextBox txtTiempo;
        private TextBox txtCosto;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label2;
    }
}