namespace proyectoU2
{
    partial class FrmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlInicio = new Panel();
            button1 = new Button();
            button2 = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // pnlInicio
            // 
            pnlInicio.BackColor = Color.FromArgb(255, 224, 192);
            pnlInicio.Location = new Point(1, 109);
            pnlInicio.Name = "pnlInicio";
            pnlInicio.Size = new Size(1619, 586);
            pnlInicio.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 64, 0);
            button1.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.icons8_tools_100;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1, 0);
            button1.Name = "button1";
            button1.Size = new Size(497, 103);
            button1.TabIndex = 1;
            button1.Text = "Refaciones.";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 64, 0);
            button2.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.icons8_mechanic_96;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(504, 0);
            button2.Name = "button2";
            button2.Size = new Size(541, 103);
            button2.TabIndex = 2;
            button2.Text = "Servicios";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 224, 192);
            btnClose.Image = Properties.Resources.icons8_close_100;
            btnClose.Location = new Point(1440, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(180, 103);
            btnClose.TabIndex = 3;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += button3_Click;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1643, 720);
            Controls.Add(btnClose);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pnlInicio);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "p";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlInicio;
        private Button button1;
        private Button button2;
        private Button btnClose;
    }
}
