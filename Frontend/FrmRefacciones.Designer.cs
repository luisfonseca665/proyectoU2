namespace proyectoU2.Frontend
{
    partial class FrmRefacciones
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
            dgvRefacciones = new DataGridView();
            btnEliminar = new Button();
            btneditar = new Button();
            btnagregar = new Button();
            pnleditaragregar = new Panel();
            btnVer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRefacciones).BeginInit();
            SuspendLayout();
            // 
            // dgvRefacciones
            // 
            dgvRefacciones.BackgroundColor = Color.White;
            dgvRefacciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRefacciones.Location = new Point(40, 126);
            dgvRefacciones.Name = "dgvRefacciones";
            dgvRefacciones.RowHeadersVisible = false;
            dgvRefacciones.RowHeadersWidth = 62;
            dgvRefacciones.Size = new Size(676, 399);
            dgvRefacciones.TabIndex = 0;
            dgvRefacciones.CellContentClick += dgvRefacciones_CellContentClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = Properties.Resources.icons8_delete_60;
            btnEliminar.Location = new Point(40, 49);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 59);
            btnEliminar.TabIndex = 1;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btneditar
            // 
            btneditar.Image = Properties.Resources.icons8_update_50;
            btneditar.Location = new Point(242, 49);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(112, 59);
            btneditar.TabIndex = 2;
            btneditar.UseVisualStyleBackColor = true;
            btneditar.Click += btneditar_Click;
            // 
            // btnagregar
            // 
            btnagregar.Image = Properties.Resources.icons8_add_50;
            btnagregar.Location = new Point(426, 49);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(112, 59);
            btnagregar.TabIndex = 3;
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // pnleditaragregar
            // 
            pnleditaragregar.Location = new Point(742, 126);
            pnleditaragregar.Name = "pnleditaragregar";
            pnleditaragregar.Size = new Size(851, 399);
            pnleditaragregar.TabIndex = 5;
            // 
            // btnVer
            // 
            btnVer.Image = Properties.Resources.icons8_eye_501;
            btnVer.Location = new Point(604, 49);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(112, 59);
            btnVer.TabIndex = 6;
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click_1;
            // 
            // FrmRefacciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1619, 573);
            Controls.Add(btnVer);
            Controls.Add(pnleditaragregar);
            Controls.Add(btnagregar);
            Controls.Add(btneditar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvRefacciones);
            Name = "FrmRefacciones";
            Text = "FrmRefacciones";
            Load += FrmRefacciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRefacciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRefacciones;
        private Button btnEliminar;
        private Button btneditar;
        private Button btnagregar;
        private Panel pnleditaragregar;
        private Button btnVer;
    }
}