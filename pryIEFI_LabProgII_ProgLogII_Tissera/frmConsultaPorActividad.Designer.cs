namespace pryIEFI_LabProgII_ProgLogII_Tissera
{
    partial class frmConsultaPorActividad
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
            this.dgvActividad = new System.Windows.Forms.DataGridView();
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblResTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblResPromedio = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblResMenor = new System.Windows.Forms.Label();
            this.lblMenor = new System.Windows.Forms.Label();
            this.lblResMayor = new System.Windows.Forms.Label();
            this.lblMayor = new System.Windows.Forms.Label();
            this.cboActividad = new System.Windows.Forms.ComboBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.colDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividad)).BeginInit();
            this.gpbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvActividad
            // 
            this.dgvActividad.AllowUserToAddRows = false;
            this.dgvActividad.AllowUserToDeleteRows = false;
            this.dgvActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDNI,
            this.colNombre});
            this.dgvActividad.Location = new System.Drawing.Point(6, 63);
            this.dgvActividad.Name = "dgvActividad";
            this.dgvActividad.ReadOnly = true;
            this.dgvActividad.Size = new System.Drawing.Size(495, 231);
            this.dgvActividad.TabIndex = 0;
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.lblActividad);
            this.gpbDatos.Controls.Add(this.cboActividad);
            this.gpbDatos.Controls.Add(this.lblResMayor);
            this.gpbDatos.Controls.Add(this.lblMayor);
            this.gpbDatos.Controls.Add(this.lblResMenor);
            this.gpbDatos.Controls.Add(this.lblMenor);
            this.gpbDatos.Controls.Add(this.lblResPromedio);
            this.gpbDatos.Controls.Add(this.lblPromedio);
            this.gpbDatos.Controls.Add(this.lblResTotal);
            this.gpbDatos.Controls.Add(this.lblTotal);
            this.gpbDatos.Controls.Add(this.btnExportar);
            this.gpbDatos.Controls.Add(this.btnImprimir);
            this.gpbDatos.Controls.Add(this.btnListar);
            this.gpbDatos.Controls.Add(this.dgvActividad);
            this.gpbDatos.Location = new System.Drawing.Point(12, 12);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(511, 532);
            this.gpbDatos.TabIndex = 1;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Gestión de datos";
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExportar.Location = new System.Drawing.Point(388, 488);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(91, 29);
            this.btnExportar.TabIndex = 3;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnImprimir.Location = new System.Drawing.Point(214, 488);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(91, 29);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnListar.Location = new System.Drawing.Point(43, 488);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(91, 29);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblResTotal
            // 
            this.lblResTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResTotal.Location = new System.Drawing.Point(233, 435);
            this.lblResTotal.Name = "lblResTotal";
            this.lblResTotal.Size = new System.Drawing.Size(181, 31);
            this.lblResTotal.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotal.Location = new System.Drawing.Point(107, 436);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(120, 20);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total de saldos:";
            // 
            // lblResPromedio
            // 
            this.lblResPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResPromedio.Location = new System.Drawing.Point(233, 393);
            this.lblResPromedio.Name = "lblResPromedio";
            this.lblResPromedio.Size = new System.Drawing.Size(181, 31);
            this.lblResPromedio.TabIndex = 8;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPromedio.Location = new System.Drawing.Point(79, 394);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(152, 20);
            this.lblPromedio.TabIndex = 7;
            this.lblPromedio.Text = "Promedio de saldos:";
            // 
            // lblResMenor
            // 
            this.lblResMenor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResMenor.Location = new System.Drawing.Point(233, 351);
            this.lblResMenor.Name = "lblResMenor";
            this.lblResMenor.Size = new System.Drawing.Size(181, 31);
            this.lblResMenor.TabIndex = 10;
            // 
            // lblMenor
            // 
            this.lblMenor.AutoSize = true;
            this.lblMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMenor.Location = new System.Drawing.Point(127, 352);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(100, 20);
            this.lblMenor.TabIndex = 9;
            this.lblMenor.Text = "Menor saldo:";
            // 
            // lblResMayor
            // 
            this.lblResMayor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResMayor.Location = new System.Drawing.Point(233, 309);
            this.lblResMayor.Name = "lblResMayor";
            this.lblResMayor.Size = new System.Drawing.Size(181, 31);
            this.lblResMayor.TabIndex = 12;
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMayor.Location = new System.Drawing.Point(129, 310);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(98, 20);
            this.lblMayor.TabIndex = 11;
            this.lblMayor.Text = "Mayor saldo:";
            // 
            // cboActividad
            // 
            this.cboActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboActividad.FormattingEnabled = true;
            this.cboActividad.Items.AddRange(new object[] {
            "Musculación",
            "Crossfit",
            "Pilates",
            "Yoga",
            "Cardio",
            "Funcional"});
            this.cboActividad.Location = new System.Drawing.Point(202, 29);
            this.cboActividad.Name = "cboActividad";
            this.cboActividad.Size = new System.Drawing.Size(176, 28);
            this.cboActividad.TabIndex = 13;
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblActividad.Location = new System.Drawing.Point(119, 32);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(77, 20);
            this.lblActividad.TabIndex = 14;
            this.lblActividad.Text = "Actividad:";
            // 
            // colDNI
            // 
            this.colDNI.Frozen = true;
            this.colDNI.HeaderText = "DNI";
            this.colDNI.Name = "colDNI";
            this.colDNI.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.Frozen = true;
            this.colNombre.HeaderText = "Nombre completo";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 500;
            // 
            // frmConsultaPorActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 556);
            this.Controls.Add(this.gpbDatos);
            this.Name = "frmConsultaPorActividad";
            this.Text = "Consulta de socios por actividad";
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividad)).EndInit();
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActividad;
        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblResMayor;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Label lblResMenor;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Label lblResPromedio;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblResTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.ComboBox cboActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
    }
}