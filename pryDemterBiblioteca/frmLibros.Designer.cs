namespace pryDemterBiblioteca
{
    partial class frmLibros
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoDeLaEditorial = new System.Windows.Forms.Label();
            this.lblCodigoDelAutor = new System.Windows.Forms.Label();
            this.lblCodigoDelDistribuidor = new System.Windows.Forms.Label();
            this.cmdAnterior = new System.Windows.Forms.Button();
            this.cmdSiguiente = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.txtCodigoEditorial = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtDistribuidor = new System.Windows.Forms.TextBox();
            this.txtCodigoLibro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(49, 38);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(49, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCodigoDeLaEditorial
            // 
            this.lblCodigoDeLaEditorial.AutoSize = true;
            this.lblCodigoDeLaEditorial.Location = new System.Drawing.Point(49, 113);
            this.lblCodigoDeLaEditorial.Name = "lblCodigoDeLaEditorial";
            this.lblCodigoDeLaEditorial.Size = new System.Drawing.Size(112, 13);
            this.lblCodigoDeLaEditorial.TabIndex = 2;
            this.lblCodigoDeLaEditorial.Text = "Codigo De La Editorial";
            // 
            // lblCodigoDelAutor
            // 
            this.lblCodigoDelAutor.AutoSize = true;
            this.lblCodigoDelAutor.Location = new System.Drawing.Point(49, 157);
            this.lblCodigoDelAutor.Name = "lblCodigoDelAutor";
            this.lblCodigoDelAutor.Size = new System.Drawing.Size(84, 13);
            this.lblCodigoDelAutor.TabIndex = 3;
            this.lblCodigoDelAutor.Text = "Codigo del autor";
            // 
            // lblCodigoDelDistribuidor
            // 
            this.lblCodigoDelDistribuidor.AutoSize = true;
            this.lblCodigoDelDistribuidor.Location = new System.Drawing.Point(49, 200);
            this.lblCodigoDelDistribuidor.Name = "lblCodigoDelDistribuidor";
            this.lblCodigoDelDistribuidor.Size = new System.Drawing.Size(110, 13);
            this.lblCodigoDelDistribuidor.TabIndex = 4;
            this.lblCodigoDelDistribuidor.Text = "Codigo del distribuidor";
            // 
            // cmdAnterior
            // 
            this.cmdAnterior.Location = new System.Drawing.Point(67, 242);
            this.cmdAnterior.Name = "cmdAnterior";
            this.cmdAnterior.Size = new System.Drawing.Size(75, 23);
            this.cmdAnterior.TabIndex = 10;
            this.cmdAnterior.Text = "Anterior";
            this.cmdAnterior.UseVisualStyleBackColor = true;
            this.cmdAnterior.Click += new System.EventHandler(this.cmdAnterior_Click);
            // 
            // cmdSiguiente
            // 
            this.cmdSiguiente.Location = new System.Drawing.Point(277, 242);
            this.cmdSiguiente.Name = "cmdSiguiente";
            this.cmdSiguiente.Size = new System.Drawing.Size(75, 23);
            this.cmdSiguiente.TabIndex = 11;
            this.cmdSiguiente.Text = "Siguiente";
            this.cmdSiguiente.UseVisualStyleBackColor = true;
            this.cmdSiguiente.Click += new System.EventHandler(this.cmdSiguiente_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(176, 287);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 12;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.BackColor = System.Drawing.Color.SeaShell;
            this.txtNombreLibro.Enabled = false;
            this.txtNombreLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreLibro.Location = new System.Drawing.Point(194, 65);
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.ReadOnly = true;
            this.txtNombreLibro.Size = new System.Drawing.Size(189, 21);
            this.txtNombreLibro.TabIndex = 17;
            // 
            // txtCodigoEditorial
            // 
            this.txtCodigoEditorial.BackColor = System.Drawing.Color.SeaShell;
            this.txtCodigoEditorial.Enabled = false;
            this.txtCodigoEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoEditorial.Location = new System.Drawing.Point(194, 108);
            this.txtCodigoEditorial.Name = "txtCodigoEditorial";
            this.txtCodigoEditorial.ReadOnly = true;
            this.txtCodigoEditorial.Size = new System.Drawing.Size(189, 21);
            this.txtCodigoEditorial.TabIndex = 16;
            // 
            // txtAutor
            // 
            this.txtAutor.BackColor = System.Drawing.Color.SeaShell;
            this.txtAutor.Enabled = false;
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(194, 152);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.ReadOnly = true;
            this.txtAutor.Size = new System.Drawing.Size(189, 21);
            this.txtAutor.TabIndex = 15;
            // 
            // txtDistribuidor
            // 
            this.txtDistribuidor.BackColor = System.Drawing.Color.SeaShell;
            this.txtDistribuidor.Enabled = false;
            this.txtDistribuidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistribuidor.Location = new System.Drawing.Point(194, 192);
            this.txtDistribuidor.Name = "txtDistribuidor";
            this.txtDistribuidor.ReadOnly = true;
            this.txtDistribuidor.Size = new System.Drawing.Size(189, 21);
            this.txtDistribuidor.TabIndex = 14;
            // 
            // txtCodigoLibro
            // 
            this.txtCodigoLibro.BackColor = System.Drawing.Color.SeaShell;
            this.txtCodigoLibro.Enabled = false;
            this.txtCodigoLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoLibro.Location = new System.Drawing.Point(194, 30);
            this.txtCodigoLibro.Name = "txtCodigoLibro";
            this.txtCodigoLibro.ReadOnly = true;
            this.txtCodigoLibro.Size = new System.Drawing.Size(94, 21);
            this.txtCodigoLibro.TabIndex = 13;
            // 
            // frmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 335);
            this.Controls.Add(this.txtNombreLibro);
            this.Controls.Add(this.txtCodigoEditorial);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtDistribuidor);
            this.Controls.Add(this.txtCodigoLibro);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdSiguiente);
            this.Controls.Add(this.cmdAnterior);
            this.Controls.Add(this.lblCodigoDelDistribuidor);
            this.Controls.Add(this.lblCodigoDelAutor);
            this.Controls.Add(this.lblCodigoDeLaEditorial);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmLibros";
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.frmLibros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigoDeLaEditorial;
        private System.Windows.Forms.Label lblCodigoDelAutor;
        private System.Windows.Forms.Label lblCodigoDelDistribuidor;
        private System.Windows.Forms.Button cmdAnterior;
        private System.Windows.Forms.Button cmdSiguiente;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.TextBox txtCodigoEditorial;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtDistribuidor;
        private System.Windows.Forms.TextBox txtCodigoLibro;
    }
}