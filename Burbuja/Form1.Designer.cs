using System;

namespace Burbuja
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarDatos = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.txtn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTiempoGenerar = new System.Windows.Forms.Label();
            this.lblTiempoOrdenar = new System.Windows.Forms.Label();
            this.btnOrdenar2 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbComparaciones = new System.Windows.Forms.Label();
            this.lblntercambios = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPasadas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "N:\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGenerarDatos
            // 
            this.btnGenerarDatos.Location = new System.Drawing.Point(59, 91);
            this.btnGenerarDatos.Name = "btnGenerarDatos";
            this.btnGenerarDatos.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarDatos.TabIndex = 3;
            this.btnGenerarDatos.Text = "GENERAR\r\n";
            this.btnGenerarDatos.UseVisualStyleBackColor = true;
            this.btnGenerarDatos.Click += new System.EventHandler(this.BtnGenerarDatos_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(59, 135);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(100, 27);
            this.btnOrdenar.TabIndex = 4;
            this.btnOrdenar.Text = "ASCENDENTE\r\n";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(225, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(88, 238);
            this.listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(319, 39);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(111, 238);
            this.listBox2.TabIndex = 6;
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(59, 39);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(100, 20);
            this.txtn.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tiempo de ejecuccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Generar Datos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ordenar:";
            // 
            // lblTiempoGenerar
            // 
            this.lblTiempoGenerar.AutoSize = true;
            this.lblTiempoGenerar.Location = new System.Drawing.Point(164, 267);
            this.lblTiempoGenerar.Name = "lblTiempoGenerar";
            this.lblTiempoGenerar.Size = new System.Drawing.Size(22, 13);
            this.lblTiempoGenerar.TabIndex = 10;
            this.lblTiempoGenerar.Text = "0:0";
            // 
            // lblTiempoOrdenar
            // 
            this.lblTiempoOrdenar.AutoSize = true;
            this.lblTiempoOrdenar.Location = new System.Drawing.Point(164, 313);
            this.lblTiempoOrdenar.Name = "lblTiempoOrdenar";
            this.lblTiempoOrdenar.Size = new System.Drawing.Size(22, 13);
            this.lblTiempoOrdenar.TabIndex = 11;
            this.lblTiempoOrdenar.Text = "0:0";
            // 
            // btnOrdenar2
            // 
            this.btnOrdenar2.Location = new System.Drawing.Point(59, 168);
            this.btnOrdenar2.Name = "btnOrdenar2";
            this.btnOrdenar2.Size = new System.Drawing.Size(100, 27);
            this.btnOrdenar2.TabIndex = 12;
            this.btnOrdenar2.Text = "DESCENDENTE";
            this.btnOrdenar2.UseVisualStyleBackColor = true;
            this.btnOrdenar2.Click += new System.EventHandler(this.btnOrdenar2_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(452, 39);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(111, 238);
            this.listBox3.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "0:0";
            // 
            // tbComparaciones
            // 
            this.tbComparaciones.AutoSize = true;
            this.tbComparaciones.Location = new System.Drawing.Point(424, 344);
            this.tbComparaciones.Name = "tbComparaciones";
            this.tbComparaciones.Size = new System.Drawing.Size(13, 13);
            this.tbComparaciones.TabIndex = 22;
            this.tbComparaciones.Text = "0";
            // 
            // lblntercambios
            // 
            this.lblntercambios.AutoSize = true;
            this.lblntercambios.Location = new System.Drawing.Point(424, 298);
            this.lblntercambios.Name = "lblntercambios";
            this.lblntercambios.Size = new System.Drawing.Size(13, 13);
            this.lblntercambios.TabIndex = 21;
            this.lblntercambios.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Comparaciones:";
            // 
            // lblPasadas
            // 
            this.lblPasadas.AutoSize = true;
            this.lblPasadas.Location = new System.Drawing.Point(316, 298);
            this.lblPasadas.Name = "lblPasadas";
            this.lblPasadas.Size = new System.Drawing.Size(51, 13);
            this.lblPasadas.TabIndex = 19;
            this.lblPasadas.Text = "Pasadas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(628, 369);
            this.Controls.Add(this.tbComparaciones);
            this.Controls.Add(this.lblntercambios);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPasadas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.btnOrdenar2);
            this.Controls.Add(this.lblTiempoOrdenar);
            this.Controls.Add(this.lblTiempoGenerar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnGenerarDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarDatos;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTiempoGenerar;
        private System.Windows.Forms.Label lblTiempoOrdenar;
        private System.Windows.Forms.Button btnOrdenar2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tbComparaciones;
        private System.Windows.Forms.Label lblntercambios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPasadas;

        public EventHandler GenerarDatos_Click { get; private set; }
    }
}

