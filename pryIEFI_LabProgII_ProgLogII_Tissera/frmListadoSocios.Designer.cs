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
            this.gpbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.btnSalir);
            this.gpbDatos.Controls.Add(this.btnListar);
            this.gpbDatos.Controls.Add(this.dgvSocios);
            this.gpbDatos.Location = new System.Drawing.Point(12, 12);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(655, 412);
            this.gpbDatos.TabIndex = 0;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Listado de Socios";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSalir.Location = new System.Drawing.Point(429, 363);
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
            this.btnListar.Location = new System.Drawing.Point(542, 363);
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
            // frmListadoSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 430);
            this.Controls.Add(this.gpbDatos);
            this.Name = "frmListadoSocios";
            this.Text = "Todos los socios";
            this.gpbDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.DataGridView dgvSocios;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnSalir;
    }
}