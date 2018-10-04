namespace SistemadeAbogados
{
    partial class RegistrarProcuracionSecretario
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
            this.lblregistrarnuevaprocuracion = new System.Windows.Forms.Label();
            this.lblnroexpediente = new System.Windows.Forms.Label();
            this.tbnumerodeexpendiente = new System.Windows.Forms.TextBox();
            this.lbljuzgado = new System.Windows.Forms.Label();
            this.tbactor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbregistrarprocuracion = new System.Windows.Forms.GroupBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbdemandado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbregistrarprocuracion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblregistrarnuevaprocuracion
            // 
            this.lblregistrarnuevaprocuracion.AutoSize = true;
            this.lblregistrarnuevaprocuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistrarnuevaprocuracion.ForeColor = System.Drawing.Color.White;
            this.lblregistrarnuevaprocuracion.Location = new System.Drawing.Point(220, 16);
            this.lblregistrarnuevaprocuracion.Name = "lblregistrarnuevaprocuracion";
            this.lblregistrarnuevaprocuracion.Size = new System.Drawing.Size(208, 20);
            this.lblregistrarnuevaprocuracion.TabIndex = 9;
            this.lblregistrarnuevaprocuracion.Text = "Registrar nueva procuración";
            this.lblregistrarnuevaprocuracion.Click += new System.EventHandler(this.lblvencimientosdeproveidos_Click);
            // 
            // lblnroexpediente
            // 
            this.lblnroexpediente.AutoSize = true;
            this.lblnroexpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnroexpediente.ForeColor = System.Drawing.Color.White;
            this.lblnroexpediente.Location = new System.Drawing.Point(26, 90);
            this.lblnroexpediente.Name = "lblnroexpediente";
            this.lblnroexpediente.Size = new System.Drawing.Size(136, 20);
            this.lblnroexpediente.TabIndex = 10;
            this.lblnroexpediente.Text = "Nº de Expediente:";
            // 
            // tbnumerodeexpendiente
            // 
            this.tbnumerodeexpendiente.Location = new System.Drawing.Point(168, 90);
            this.tbnumerodeexpendiente.Name = "tbnumerodeexpendiente";
            this.tbnumerodeexpendiente.Size = new System.Drawing.Size(141, 20);
            this.tbnumerodeexpendiente.TabIndex = 11;
            // 
            // lbljuzgado
            // 
            this.lbljuzgado.AutoSize = true;
            this.lbljuzgado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljuzgado.ForeColor = System.Drawing.Color.White;
            this.lbljuzgado.Location = new System.Drawing.Point(354, 88);
            this.lbljuzgado.Name = "lbljuzgado";
            this.lbljuzgado.Size = new System.Drawing.Size(74, 20);
            this.lbljuzgado.TabIndex = 12;
            this.lbljuzgado.Text = "Juzgado:";
            // 
            // tbactor
            // 
            this.tbactor.Location = new System.Drawing.Point(168, 139);
            this.tbactor.Name = "tbactor";
            this.tbactor.Size = new System.Drawing.Size(141, 20);
            this.tbactor.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Actor:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbregistrarprocuracion
            // 
            this.gbregistrarprocuracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(99)))));
            this.gbregistrarprocuracion.Controls.Add(this.lblregistrarnuevaprocuracion);
            this.gbregistrarprocuracion.Controls.Add(this.btncancelar);
            this.gbregistrarprocuracion.Controls.Add(this.button2);
            this.gbregistrarprocuracion.Controls.Add(this.tbactor);
            this.gbregistrarprocuracion.Controls.Add(this.tbdemandado);
            this.gbregistrarprocuracion.Controls.Add(this.label1);
            this.gbregistrarprocuracion.Controls.Add(this.label2);
            this.gbregistrarprocuracion.Controls.Add(this.tbnumerodeexpendiente);
            this.gbregistrarprocuracion.Controls.Add(this.lblnroexpediente);
            this.gbregistrarprocuracion.Controls.Add(this.textBox1);
            this.gbregistrarprocuracion.Controls.Add(this.lbljuzgado);
            this.gbregistrarprocuracion.Location = new System.Drawing.Point(33, 30);
            this.gbregistrarprocuracion.Name = "gbregistrarprocuracion";
            this.gbregistrarprocuracion.Size = new System.Drawing.Size(646, 268);
            this.gbregistrarprocuracion.TabIndex = 16;
            this.gbregistrarprocuracion.TabStop = false;
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Silver;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btncancelar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(374, 209);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(126, 36);
            this.btncancelar.TabIndex = 20;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(183, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 36);
            this.button2.TabIndex = 17;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // tbdemandado
            // 
            this.tbdemandado.Location = new System.Drawing.Point(470, 139);
            this.tbdemandado.Name = "tbdemandado";
            this.tbdemandado.Size = new System.Drawing.Size(141, 20);
            this.tbdemandado.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(354, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Demandado:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(470, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 17;
            // 
            // RegistrarProcuracionSecretario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(742, 520);
            this.Controls.Add(this.gbregistrarprocuracion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarProcuracionSecretario";
            this.Text = "RegistrarProcuracionSecretario";
            this.Load += new System.EventHandler(this.RegistrarProcuracionSecretario_Load);
            this.gbregistrarprocuracion.ResumeLayout(false);
            this.gbregistrarprocuracion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblregistrarnuevaprocuracion;
        private System.Windows.Forms.Label lblnroexpediente;
        private System.Windows.Forms.TextBox tbnumerodeexpendiente;
        private System.Windows.Forms.Label lbljuzgado;
        private System.Windows.Forms.TextBox tbactor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbregistrarprocuracion;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbdemandado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}