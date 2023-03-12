namespace L8_Forms_PABM_1109623
{
    partial class Sumatoria
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
            this.label1 = new System.Windows.Forms.Label();
            this.Seleccion = new System.Windows.Forms.GroupBox();
            this.cmbsleccion = new System.Windows.Forms.ComboBox();
            this.btnseleccion = new System.Windows.Forms.Button();
            this.tabDatos1 = new System.Windows.Forms.TabControl();
            this.tabpage0 = new System.Windows.Forms.TabPage();
            this.lblReultadoTotal = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Seleccion.SuspendLayout();
            this.tabDatos1.SuspendLayout();
            this.tabpage0.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(261, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laboratorio 8";
            // 
            // Seleccion
            // 
            this.Seleccion.Controls.Add(this.cmbsleccion);
            this.Seleccion.Location = new System.Drawing.Point(12, 55);
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Size = new System.Drawing.Size(200, 100);
            this.Seleccion.TabIndex = 1;
            this.Seleccion.TabStop = false;
            this.Seleccion.Text = "Seleccionar";
            // 
            // cmbsleccion
            // 
            this.cmbsleccion.FormattingEnabled = true;
            this.cmbsleccion.Items.AddRange(new object[] {
            "Sumatoria",
            "Multiplicación",
            "Número perfecto "});
            this.cmbsleccion.Location = new System.Drawing.Point(6, 19);
            this.cmbsleccion.Name = "cmbsleccion";
            this.cmbsleccion.Size = new System.Drawing.Size(188, 21);
            this.cmbsleccion.TabIndex = 2;
            this.cmbsleccion.SelectedIndexChanged += new System.EventHandler(this.cmbsleccion_SelectedIndexChanged);
            // 
            // btnseleccion
            // 
            this.btnseleccion.Location = new System.Drawing.Point(68, 161);
            this.btnseleccion.Name = "btnseleccion";
            this.btnseleccion.Size = new System.Drawing.Size(75, 23);
            this.btnseleccion.TabIndex = 2;
            this.btnseleccion.Text = "seleccionar";
            this.btnseleccion.UseVisualStyleBackColor = true;
            this.btnseleccion.Click += new System.EventHandler(this.btnseleccion_Click);
            // 
            // tabDatos1
            // 
            this.tabDatos1.Controls.Add(this.tabpage0);
            this.tabDatos1.Controls.Add(this.tabPage2);
            this.tabDatos1.Controls.Add(this.tabPage1);
            this.tabDatos1.Location = new System.Drawing.Point(302, 55);
            this.tabDatos1.Name = "tabDatos1";
            this.tabDatos1.SelectedIndex = 0;
            this.tabDatos1.Size = new System.Drawing.Size(321, 279);
            this.tabDatos1.TabIndex = 3;
            // 
            // tabpage0
            // 
            this.tabpage0.Controls.Add(this.lblReultadoTotal);
            this.tabpage0.Controls.Add(this.txtNum);
            this.tabpage0.Controls.Add(this.lblResultado);
            this.tabpage0.Controls.Add(this.lblIngreso);
            this.tabpage0.Location = new System.Drawing.Point(4, 22);
            this.tabpage0.Name = "tabpage0";
            this.tabpage0.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage0.Size = new System.Drawing.Size(313, 253);
            this.tabpage0.TabIndex = 0;
            this.tabpage0.Text = "Sumatoria";
            this.tabpage0.UseVisualStyleBackColor = true;
            this.tabpage0.Click += new System.EventHandler(this.tabpage0_Click);
            // 
            // lblReultadoTotal
            // 
            this.lblReultadoTotal.AutoSize = true;
            this.lblReultadoTotal.Location = new System.Drawing.Point(94, 96);
            this.lblReultadoTotal.Name = "lblReultadoTotal";
            this.lblReultadoTotal.Size = new System.Drawing.Size(0, 13);
            this.lblReultadoTotal.TabIndex = 3;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(128, 38);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 2;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(31, 93);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(57, 16);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "Resultado";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.Location = new System.Drawing.Point(18, 42);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(104, 16);
            this.lblIngreso.TabIndex = 0;
            this.lblIngreso.Text = "Ingrese número N";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtNum2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(313, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Multiplicación";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(147, 49);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ingrese número N";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtNum3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(313, 253);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Número perfecto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 7;
            // 
            // txtNum3
            // 
            this.txtNum3.Location = new System.Drawing.Point(151, 58);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(100, 20);
            this.txtNum3.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Resultado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ingrese número N";
            // 
            // Sumatoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 362);
            this.Controls.Add(this.tabDatos1);
            this.Controls.Add(this.btnseleccion);
            this.Controls.Add(this.Seleccion);
            this.Controls.Add(this.label1);
            this.Name = "Sumatoria";
            this.Text = "L8_Forms_PABM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Seleccion.ResumeLayout(false);
            this.tabDatos1.ResumeLayout(false);
            this.tabpage0.ResumeLayout(false);
            this.tabpage0.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Seleccion;
        private System.Windows.Forms.ComboBox cmbsleccion;
        private System.Windows.Forms.Button btnseleccion;
        private System.Windows.Forms.TabControl tabDatos1;
        private System.Windows.Forms.TabPage tabpage0;
        private System.Windows.Forms.Label lblReultadoTotal;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

