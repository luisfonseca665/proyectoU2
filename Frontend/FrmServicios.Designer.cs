namespace proyectoU2.Frontend
{
    partial class FrmServicios
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
            pnleditaragregar = new Panel();
            btnVer = new Button();
            btnagregar = new Button();
            btneditar = new Button();
            btnEliminar = new Button();
            dgvServicios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            SuspendLayout();
            // 
            // pnleditaragregar
            // 
            pnleditaragregar.Location = new Point(714, 99);
            pnleditaragregar.Name = "pnleditaragregar";
            pnleditaragregar.Size = new Size(824, 368);
            pnleditaragregar.TabIndex = 11;
            // 
            // btnVer
            // 
            btnVer.Image = Properties.Resources.icons8_eye_50;
            btnVer.Location = new Point(576, 23);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(112, 56);
            btnVer.TabIndex = 10;
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // btnagregar
            // 
            btnagregar.Image = Properties.Resources.icons8_add_50;
            btnagregar.Location = new Point(398, 23);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(112, 56);
            btnagregar.TabIndex = 9;
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // btneditar
            // 
            btneditar.Image = Properties.Resources.icons8_update_50;
            btneditar.Location = new Point(207, 23);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(112, 56);
            btneditar.TabIndex = 8;
            btneditar.UseVisualStyleBackColor = true;
            btneditar.Click += btneditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = Properties.Resources.icons8_delete_60;
            btnEliminar.Location = new Point(12, 23);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 56);
            btnEliminar.TabIndex = 7;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvServicios
            // 
            dgvServicios.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Location = new Point(12, 99);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.RowHeadersVisible = false;
            dgvServicios.RowHeadersWidth = 62;
            dgvServicios.Size = new Size(676, 368);
            dgvServicios.TabIndex = 6;
            // 
            // FrmServicios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1602, 507);
            Controls.Add(pnleditaragregar);
            Controls.Add(btnVer);
            Controls.Add(btnagregar);
            Controls.Add(btneditar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvServicios);
            Name = "FrmServicios";
            Text = "FrmServicios";
            Load += FrmServicios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnleditaragregar;
        private Button btnVer;
        private Button btnagregar;
        private Button btneditar;
        private Button btnEliminar;
        private DataGridView dgvServicios;
    }
}