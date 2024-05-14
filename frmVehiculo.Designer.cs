namespace pryEtapa4
{
    partial class frmVehiculo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnAvion = new System.Windows.Forms.Button();
            this.btnBarco = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.pctVehiculo = new System.Windows.Forms.PictureBox();
            this.lstVehiculos = new System.Windows.Forms.ListView();
            this.lblNombreVehiculo = new System.Windows.Forms.Label();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEtapa4.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(272, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.BackColor = System.Drawing.Color.Transparent;
            this.lblInstruccion.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccion.Location = new System.Drawing.Point(92, 104);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(506, 42);
            this.lblInstruccion.TabIndex = 1;
            this.lblInstruccion.Text = "Por favor, selecciona la opción del vehículo que desees crear \r\no la opción Lista" +
    "r para mostrar todos los vehículos por su nombre";
            this.lblInstruccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAuto
            // 
            this.btnAuto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAuto.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuto.Location = new System.Drawing.Point(96, 158);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(120, 29);
            this.btnAuto.TabIndex = 2;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnAvion
            // 
            this.btnAvion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAvion.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvion.Location = new System.Drawing.Point(222, 158);
            this.btnAvion.Name = "btnAvion";
            this.btnAvion.Size = new System.Drawing.Size(120, 29);
            this.btnAvion.TabIndex = 3;
            this.btnAvion.Text = "Avión";
            this.btnAvion.UseVisualStyleBackColor = true;
            this.btnAvion.Click += new System.EventHandler(this.btnAvion_Click);
            // 
            // btnBarco
            // 
            this.btnBarco.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBarco.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarco.Location = new System.Drawing.Point(348, 158);
            this.btnBarco.Name = "btnBarco";
            this.btnBarco.Size = new System.Drawing.Size(120, 29);
            this.btnBarco.TabIndex = 4;
            this.btnBarco.Text = "Barco";
            this.btnBarco.UseVisualStyleBackColor = true;
            this.btnBarco.Click += new System.EventHandler(this.btnBarco_Click);
            // 
            // btnListar
            // 
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnListar.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(474, 158);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(120, 29);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // pctVehiculo
            // 
            this.pctVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.pctVehiculo.Location = new System.Drawing.Point(196, 349);
            this.pctVehiculo.Name = "pctVehiculo";
            this.pctVehiculo.Size = new System.Drawing.Size(300, 300);
            this.pctVehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctVehiculo.TabIndex = 6;
            this.pctVehiculo.TabStop = false;
            // 
            // lstVehiculos
            // 
            this.lstVehiculos.HideSelection = false;
            this.lstVehiculos.Location = new System.Drawing.Point(96, 193);
            this.lstVehiculos.Name = "lstVehiculos";
            this.lstVehiculos.Size = new System.Drawing.Size(498, 141);
            this.lstVehiculos.TabIndex = 7;
            this.lstVehiculos.UseCompatibleStateImageBehavior = false;
            // 
            // lblNombreVehiculo
            // 
            this.lblNombreVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreVehiculo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVehiculo.Location = new System.Drawing.Point(502, 349);
            this.lblNombreVehiculo.Name = "lblNombreVehiculo";
            this.lblNombreVehiculo.Size = new System.Drawing.Size(150, 23);
            this.lblNombreVehiculo.TabIndex = 8;
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculo.Location = new System.Drawing.Point(503, 372);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(149, 23);
            this.lblTipoVehiculo.TabIndex = 9;
            // 
            // frmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryEtapa4.Properties.Resources.frmInicio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.lblNombreVehiculo);
            this.Controls.Add(this.lstVehiculos);
            this.Controls.Add(this.pctVehiculo);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnBarco);
            this.Controls.Add(this.btnAvion);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "frmVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear vehículos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnAvion;
        private System.Windows.Forms.Button btnBarco;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.PictureBox pctVehiculo;
        private System.Windows.Forms.ListView lstVehiculos;
        private System.Windows.Forms.Label lblNombreVehiculo;
        private System.Windows.Forms.Label lblTipoVehiculo;
    }
}

