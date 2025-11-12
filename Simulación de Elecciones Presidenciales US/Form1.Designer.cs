namespace Simulación_de_Elecciones_Presidenciales_US
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
            this.dgvrep = new System.Windows.Forms.DataGridView();
            this.dgvdem = new System.Windows.Forms.DataGridView();
            this.btnagregarrep = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbestados = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnelimrep = new System.Windows.Forms.Button();
            this.btnelimdem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnagregardem = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvrep
            // 
            this.dgvrep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrep.Location = new System.Drawing.Point(100, 91);
            this.dgvrep.Name = "dgvrep";
            this.dgvrep.RowHeadersWidth = 51;
            this.dgvrep.RowTemplate.Height = 24;
            this.dgvrep.Size = new System.Drawing.Size(279, 202);
            this.dgvrep.TabIndex = 0;
            // 
            // dgvdem
            // 
            this.dgvdem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdem.Location = new System.Drawing.Point(575, 91);
            this.dgvdem.Name = "dgvdem";
            this.dgvdem.RowHeadersWidth = 51;
            this.dgvdem.RowTemplate.Height = 24;
            this.dgvdem.Size = new System.Drawing.Size(279, 202);
            this.dgvdem.TabIndex = 1;
            // 
            // btnagregarrep
            // 
            this.btnagregarrep.Location = new System.Drawing.Point(152, 336);
            this.btnagregarrep.Name = "btnagregarrep";
            this.btnagregarrep.Size = new System.Drawing.Size(153, 37);
            this.btnagregarrep.TabIndex = 2;
            this.btnagregarrep.Text = "agregar";
            this.btnagregarrep.UseVisualStyleBackColor = true;
            this.btnagregarrep.Click += new System.EventHandler(this.btnagregarrep_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(407, 336);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(153, 54);
            this.btncalcular.TabIndex = 5;
            this.btncalcular.Text = "calcular ganador";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(143, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Republicanos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(638, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Demócratas";
            // 
            // cmbestados
            // 
            this.cmbestados.FormattingEnabled = true;
            this.cmbestados.Location = new System.Drawing.Point(407, 91);
            this.cmbestados.Name = "cmbestados";
            this.cmbestados.Size = new System.Drawing.Size(144, 24);
            this.cmbestados.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Estado a eliminar Rep:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(655, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Estado a eliminar Dem:";
            // 
            // btnelimrep
            // 
            this.btnelimrep.Location = new System.Drawing.Point(148, 445);
            this.btnelimrep.Name = "btnelimrep";
            this.btnelimrep.Size = new System.Drawing.Size(156, 44);
            this.btnelimrep.TabIndex = 13;
            this.btnelimrep.Text = "eliminar";
            this.btnelimrep.UseVisualStyleBackColor = true;
            this.btnelimrep.Click += new System.EventHandler(this.btnelimrep_Click);
            // 
            // btnelimdem
            // 
            this.btnelimdem.Location = new System.Drawing.Point(642, 445);
            this.btnelimdem.Name = "btnelimdem";
            this.btnelimdem.Size = new System.Drawing.Size(156, 44);
            this.btnelimdem.TabIndex = 14;
            this.btnelimdem.Text = "eliminar";
            this.btnelimdem.UseVisualStyleBackColor = true;
            this.btnelimdem.Click += new System.EventHandler(this.btnelimdem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Estado a agregar Rep:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(654, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Estado a agregar Dem:";
            // 
            // btnagregardem
            // 
            this.btnagregardem.Location = new System.Drawing.Point(645, 336);
            this.btnagregardem.Name = "btnagregardem";
            this.btnagregardem.Size = new System.Drawing.Size(153, 37);
            this.btnagregardem.TabIndex = 19;
            this.btnagregardem.Text = "agregar";
            this.btnagregardem.UseVisualStyleBackColor = true;
            this.btnagregardem.Click += new System.EventHandler(this.btnagregardem_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(407, 408);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(153, 54);
            this.btnlimpiar.TabIndex = 20;
            this.btnlimpiar.Text = "limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 539);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnagregardem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnelimdem);
            this.Controls.Add(this.btnelimrep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbestados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.btnagregarrep);
            this.Controls.Add(this.dgvdem);
            this.Controls.Add(this.dgvrep);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvrep;
        private System.Windows.Forms.DataGridView dgvdem;
        private System.Windows.Forms.Button btnagregarrep;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbestados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnelimrep;
        private System.Windows.Forms.Button btnelimdem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnagregardem;
        private System.Windows.Forms.Button btnlimpiar;
    }
}

