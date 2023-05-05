namespace Ejemplo1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Saludar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Saludar
            // 
            this.Saludar.BackColor = System.Drawing.Color.Silver;
            this.Saludar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Saludar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saludar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Saludar.Location = new System.Drawing.Point(288, 170);
            this.Saludar.Name = "Saludar";
            this.Saludar.Size = new System.Drawing.Size(177, 91);
            this.Saludar.TabIndex = 0;
            this.Saludar.Text = "Saludar";
            this.Saludar.UseVisualStyleBackColor = false;
            this.Saludar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(376, 125);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(285, 128);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Location = new System.Drawing.Point(376, 306);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(35, 13);
            this.lblSaludo.TabIndex = 4;
            this.lblSaludo.Text = "label1";
            this.lblSaludo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.Saludar);
            this.Name = "Form1";
            this.Text = "Practice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Saludar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSaludo;
    }
}

