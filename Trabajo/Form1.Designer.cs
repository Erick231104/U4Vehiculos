namespace Trabajo
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
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtCapacidadCarga = new System.Windows.Forms.TextBox();
            this.txtCapacidadBateria = new System.Windows.Forms.TextBox();
            this.lstVehiculo = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMover = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnDetner = new System.Windows.Forms.Button();
            this.btnCargarBateria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(351, 63);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoVehiculo.TabIndex = 0;
            this.cmbTipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoVehiculo_SelectedIndexChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(271, 139);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 1;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(271, 190);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 2;
            // 
            // txtCapacidadCarga
            // 
            this.txtCapacidadCarga.Location = new System.Drawing.Point(271, 239);
            this.txtCapacidadCarga.Name = "txtCapacidadCarga";
            this.txtCapacidadCarga.Size = new System.Drawing.Size(100, 20);
            this.txtCapacidadCarga.TabIndex = 3;
            // 
            // txtCapacidadBateria
            // 
            this.txtCapacidadBateria.Location = new System.Drawing.Point(271, 288);
            this.txtCapacidadBateria.Name = "txtCapacidadBateria";
            this.txtCapacidadBateria.Size = new System.Drawing.Size(100, 20);
            this.txtCapacidadBateria.TabIndex = 4;
            // 
            // lstVehiculo
            // 
            this.lstVehiculo.FormattingEnabled = true;
            this.lstVehiculo.Location = new System.Drawing.Point(452, 128);
            this.lstVehiculo.Name = "lstVehiculo";
            this.lstVehiculo.Size = new System.Drawing.Size(314, 212);
            this.lstVehiculo.TabIndex = 5;
            this.lstVehiculo.SelectedIndexChanged += new System.EventHandler(this.lstVehiculo_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(134, 389);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMover
            // 
            this.btnMover.Location = new System.Drawing.Point(271, 389);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(75, 23);
            this.btnMover.TabIndex = 7;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(420, 389);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 8;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnDetner
            // 
            this.btnDetner.Location = new System.Drawing.Point(564, 389);
            this.btnDetner.Name = "btnDetner";
            this.btnDetner.Size = new System.Drawing.Size(75, 23);
            this.btnDetner.TabIndex = 9;
            this.btnDetner.Text = "Detener";
            this.btnDetner.UseVisualStyleBackColor = true;
            this.btnDetner.Click += new System.EventHandler(this.btnDetner_Click);
            // 
            // btnCargarBateria
            // 
            this.btnCargarBateria.Location = new System.Drawing.Point(680, 389);
            this.btnCargarBateria.Name = "btnCargarBateria";
            this.btnCargarBateria.Size = new System.Drawing.Size(75, 23);
            this.btnCargarBateria.TabIndex = 10;
            this.btnCargarBateria.Text = "Cargar Bateria";
            this.btnCargarBateria.UseVisualStyleBackColor = true;
            this.btnCargarBateria.Click += new System.EventHandler(this.btnCargarBateria_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCargarBateria);
            this.Controls.Add(this.btnDetner);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstVehiculo);
            this.Controls.Add(this.txtCapacidadBateria);
            this.Controls.Add(this.txtCapacidadCarga);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.cmbTipoVehiculo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtCapacidadCarga;
        private System.Windows.Forms.TextBox txtCapacidadBateria;
        private System.Windows.Forms.ListBox lstVehiculo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnDetner;
        private System.Windows.Forms.Button btnCargarBateria;
    }
}

