namespace pryIEFI_LabProgII_ProgLogII_Tissera
{
    partial class frmListadoSocios
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
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvSocios = new System.Windows.Forms.DataGridView();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblResCantidad = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblResTotal = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblResPromedio = new System.Windows.Forms.Label();
            this.gpbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.lblResPromedio);
            this.gpbDatos.Controls.Add(this.lblPromedio);
            this.gpbDatos.Controls.Add(this.lblResTotal);
            this.gpbDatos.Controls.Add(this.lblTotal);
            this.gpbDatos.Controls.Add(this.lblResCantidad);
            this.gpbDatos.Controls.Add(this.lblCantidad);
            this.gpbDatos.Controls.Add(this.btnSalir);
            this.gpbDatos.Controls.Add(this.btnListar);
            this.gpbDatos.Controls.Add(this.dgvSocios);
            this.gpbDatos.Location = new System.Drawing.Point(12, 12);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(655, 494);
            this.gpbDatos.TabIndex = 0;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Listado de Socios";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSalir.Location = new System.Drawing.Point(62, 440);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 41);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnListar.Location = new System.Drawing.Point(62, 377);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(107, 41);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvSocios
            // 
            this.dgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocios.Location = new System.Drawing.Point(6, 19);
            this.dgvSocios.Name = "dgvSocios";
            this.dgvSocios.Size = new System.Drawing.Size(643, 338);
            this.dgvSocios.TabIndex = 0;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCantidad.Location = new System.Drawing.Point(314, 377);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(148, 20);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad de socios:";
            // 
            // lblResCantidad
            // 
            this.lblResCantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResCantidad.Location = new System.Drawing.Point(468, 376);
            this.lblResCantidad.Name = "lblResCantidad";
            this.lblResCantidad.Size = new System.Drawing.Size(181, 31);
            this.lblResCantidad.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotal.Location = new System.Drawing.Point(342, 419);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(120, 20);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total de saldos:";
            // 
            // lblResTotal
            // 
            this.lblResTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblResTotal.Location = new System.Drawing.Point(468, 418);
            this.lblResTotal.Name = "lblResTotal";
            this.lblResTotal.Size = new System.Drawing.Size(181, 31);
            this.lblResTotal.TabIndex = 6;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPromedio.Location = new System.Drawing.Point(310, 461);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(152, 20);
            this.lblPromedio.TabIndex = 7;
            this.lblPromedio.Text = "Promedio de saldos:";
            // 
            // lblResPromedio
            // 
            this.lblResPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblResPromedio.Location = new System.Drawing.Point(468, 460);
            this.lblResPromedio.Name = "lblResPromedio";
            this.lblResPromedio.Size = new System.Drawing.Size(181, 31);
            this.lblResPromedio.TabIndex = 8;
            // 
            // frmListadoSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 518);
            this.Controls.Add(this.gpbDatos);
            this.Name = "frmListadoSocios";
            this.Text = "Todos los socios";
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.DataGridView dgvSocios;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblResPromedio;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblResTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblResCantidad;
        private System.Windows.Forms.Label lblCantidad;
    }
}