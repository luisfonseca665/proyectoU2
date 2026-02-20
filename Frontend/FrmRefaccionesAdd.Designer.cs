namespace proyectoU2.Frontend
{
    partial class FrmRefaccionesAdd
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtMarca = new TextBox();
            txtPrecio = new TextBox();
            txtStockActual = new TextBox();
            txtStockMinimo = new TextBox();
            txtProveedor = new TextBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 28);
            label1.TabIndex = 0;
            label1.Text = "Codigo Refaccion.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 99);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 188);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 28);
            label3.TabIndex = 2;
            label3.Text = "Marca:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 288);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 28);
            label4.TabIndex = 3;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(465, 188);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(122, 28);
            label5.TabIndex = 4;
            label5.Text = "Proveedor:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(465, 99);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(155, 28);
            label6.TabIndex = 5;
            label6.Text = "Stock Minimo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(465, 10);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(141, 28);
            label7.TabIndex = 6;
            label7.Text = "Stock Actual:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(225, 7);
            txtCodigo.Margin = new Padding(4, 3, 4, 3);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(194, 34);
            txtCodigo.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(130, 95);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(289, 34);
            txtNombre.TabIndex = 8;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(107, 188);
            txtMarca.Margin = new Padding(4, 3, 4, 3);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(312, 34);
            txtMarca.TabIndex = 9;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(107, 284);
            txtPrecio.Margin = new Padding(4, 3, 4, 3);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(194, 34);
            txtPrecio.TabIndex = 10;
            // 
            // txtStockActual
            // 
            txtStockActual.Location = new Point(620, 10);
            txtStockActual.Margin = new Padding(4, 3, 4, 3);
            txtStockActual.Name = "txtStockActual";
            txtStockActual.Size = new Size(248, 34);
            txtStockActual.TabIndex = 11;
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Location = new Point(636, 99);
            txtStockMinimo.Margin = new Padding(4, 3, 4, 3);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(233, 34);
            txtStockMinimo.TabIndex = 12;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(601, 188);
            txtProveedor.Margin = new Padding(4, 3, 4, 3);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(268, 34);
            txtProveedor.TabIndex = 13;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(128, 64, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = Properties.Resources.icons8_save_100__1_;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(465, 245);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(404, 86);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // FrmRefaccionesAdd
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(897, 367);
            Controls.Add(btnGuardar);
            Controls.Add(txtProveedor);
            Controls.Add(txtStockMinimo);
            Controls.Add(txtStockActual);
            Controls.Add(txtPrecio);
            Controls.Add(txtMarca);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmRefaccionesAdd";
            Text = "FrmRefaccionesAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtMarca;
        private TextBox txtPrecio;
        private TextBox txtStockActual;
        private TextBox txtStockMinimo;
        private TextBox txtProveedor;
        private Button btnGuardar;
    }
}