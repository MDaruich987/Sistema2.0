namespace SistemadeAbogados
{
    partial class FormInicioSecretario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblvencimientosdeproveidos = new System.Windows.Forms.Label();
            this.gridvencimientosproveidos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diasrestantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idprocuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblcomentariosprocuraciones = new System.Windows.Forms.Label();
            this.gridcomentariosprocuraciones = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbregistrarprocuracion = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridvencimientosproveidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridcomentariosprocuraciones)).BeginInit();
            this.gbregistrarprocuracion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblvencimientosdeproveidos
            // 
            this.lblvencimientosdeproveidos.AutoSize = true;
            this.lblvencimientosdeproveidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvencimientosdeproveidos.ForeColor = System.Drawing.Color.White;
            this.lblvencimientosdeproveidos.Location = new System.Drawing.Point(22, 30);
            this.lblvencimientosdeproveidos.Name = "lblvencimientosdeproveidos";
            this.lblvencimientosdeproveidos.Size = new System.Drawing.Size(263, 20);
            this.lblvencimientosdeproveidos.TabIndex = 8;
            this.lblvencimientosdeproveidos.Text = "Próximos vencimientos de proveídos";
            this.lblvencimientosdeproveidos.Click += new System.EventHandler(this.label1_Click);
            // 
            // gridvencimientosproveidos
            // 
            this.gridvencimientosproveidos.AllowUserToAddRows = false;
            this.gridvencimientosproveidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridvencimientosproveidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridvencimientosproveidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.gridvencimientosproveidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridvencimientosproveidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.gridvencimientosproveidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridvencimientosproveidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridvencimientosproveidos.ColumnHeadersHeight = 30;
            this.gridvencimientosproveidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Diasrestantes,
            this.Column1,
            this.Idprocuracion,
            this.Column2,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridvencimientosproveidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridvencimientosproveidos.EnableHeadersVisualStyles = false;
            this.gridvencimientosproveidos.GridColor = System.Drawing.Color.SteelBlue;
            this.gridvencimientosproveidos.Location = new System.Drawing.Point(26, 53);
            this.gridvencimientosproveidos.Name = "gridvencimientosproveidos";
            this.gridvencimientosproveidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridvencimientosproveidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridvencimientosproveidos.Size = new System.Drawing.Size(690, 144);
            this.gridvencimientosproveidos.TabIndex = 9;
            this.gridvencimientosproveidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridvencimientosproveidos_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 44;
            // 
            // Diasrestantes
            // 
            this.Diasrestantes.HeaderText = "DÍAS RESTANTES";
            this.Diasrestantes.Name = "Diasrestantes";
            this.Diasrestantes.Width = 131;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "FECHA DE VENCIMIENTO";
            this.Column1.Name = "Column1";
            this.Column1.Width = 174;
            // 
            // Idprocuracion
            // 
            this.Idprocuracion.HeaderText = "PROCURACION";
            this.Idprocuracion.Name = "Idprocuracion";
            this.Idprocuracion.Width = 118;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ABOGADO";
            this.Column2.Name = "Column2";
            this.Column2.Width = 88;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "DOCUMENTACIÓN";
            this.Column4.Name = "Column4";
            this.Column4.Width = 136;
            // 
            // lblcomentariosprocuraciones
            // 
            this.lblcomentariosprocuraciones.AutoSize = true;
            this.lblcomentariosprocuraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomentariosprocuraciones.ForeColor = System.Drawing.Color.White;
            this.lblcomentariosprocuraciones.Location = new System.Drawing.Point(22, 229);
            this.lblcomentariosprocuraciones.Name = "lblcomentariosprocuraciones";
            this.lblcomentariosprocuraciones.Size = new System.Drawing.Size(279, 20);
            this.lblcomentariosprocuraciones.TabIndex = 10;
            this.lblcomentariosprocuraciones.Text = "Ultimos comentarios en procuraciones";
            this.lblcomentariosprocuraciones.Click += new System.EventHandler(this.label2_Click);
            // 
            // gridcomentariosprocuraciones
            // 
            this.gridcomentariosprocuraciones.AllowUserToAddRows = false;
            this.gridcomentariosprocuraciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridcomentariosprocuraciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridcomentariosprocuraciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.gridcomentariosprocuraciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridcomentariosprocuraciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridcomentariosprocuraciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridcomentariosprocuraciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridcomentariosprocuraciones.ColumnHeadersHeight = 30;
            this.gridcomentariosprocuraciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridcomentariosprocuraciones.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridcomentariosprocuraciones.EnableHeadersVisualStyles = false;
            this.gridcomentariosprocuraciones.GridColor = System.Drawing.Color.SteelBlue;
            this.gridcomentariosprocuraciones.Location = new System.Drawing.Point(26, 261);
            this.gridcomentariosprocuraciones.Name = "gridcomentariosprocuraciones";
            this.gridcomentariosprocuraciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridcomentariosprocuraciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridcomentariosprocuraciones.Size = new System.Drawing.Size(690, 177);
            this.gridcomentariosprocuraciones.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nº PROCURACIÓN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 134;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "FECHA ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 72;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "ABOGADO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 88;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "COMENTARIO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // gbregistrarprocuracion
            // 
            this.gbregistrarprocuracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(99)))));
            this.gbregistrarprocuracion.Controls.Add(this.lblcomentariosprocuraciones);
            this.gbregistrarprocuracion.Controls.Add(this.gridcomentariosprocuraciones);
            this.gbregistrarprocuracion.Controls.Add(this.gridvencimientosproveidos);
            this.gbregistrarprocuracion.Controls.Add(this.lblvencimientosdeproveidos);
            this.gbregistrarprocuracion.Location = new System.Drawing.Point(31, 31);
            this.gbregistrarprocuracion.Name = "gbregistrarprocuracion";
            this.gbregistrarprocuracion.Size = new System.Drawing.Size(765, 458);
            this.gbregistrarprocuracion.TabIndex = 18;
            this.gbregistrarprocuracion.TabStop = false;
            // 
            // FormInicioSecretario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(808, 520);
            this.Controls.Add(this.gbregistrarprocuracion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInicioSecretario";
            this.Text = "FormInicioSecretario";
            ((System.ComponentModel.ISupportInitialize)(this.gridvencimientosproveidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridcomentariosprocuraciones)).EndInit();
            this.gbregistrarprocuracion.ResumeLayout(false);
            this.gbregistrarprocuracion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblvencimientosdeproveidos;
        private System.Windows.Forms.DataGridView gridvencimientosproveidos;
        private System.Windows.Forms.Label lblcomentariosprocuraciones;
        private System.Windows.Forms.DataGridView gridcomentariosprocuraciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diasrestantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idprocuracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox gbregistrarprocuracion;
    }
}