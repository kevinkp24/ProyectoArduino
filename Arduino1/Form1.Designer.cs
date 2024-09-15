namespace Arduino1
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
            this.txtAlgo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtContador = new System.Windows.Forms.TextBox();
            this.txtContador2 = new System.Windows.Forms.TextBox();
            this.txtContador10 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Bt_grafica = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAlgo
            // 
            this.txtAlgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlgo.Location = new System.Drawing.Point(54, 12);
            this.txtAlgo.Name = "txtAlgo";
            this.txtAlgo.Size = new System.Drawing.Size(596, 53);
            this.txtAlgo.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enviar Arduino";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Detener";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(167, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "verde";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(293, 293);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 33);
            this.button4.TabIndex = 4;
            this.button4.Text = "azul";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(421, 293);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 33);
            this.button5.TabIndex = 5;
            this.button5.Text = "rojo";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(228, 371);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(198, 40);
            this.button6.TabIndex = 6;
            this.button6.Text = "Apagar todo";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtContador
            // 
            this.txtContador.Location = new System.Drawing.Point(145, 138);
            this.txtContador.Name = "txtContador";
            this.txtContador.Size = new System.Drawing.Size(100, 22);
            this.txtContador.TabIndex = 7;
            // 
            // txtContador2
            // 
            this.txtContador2.Location = new System.Drawing.Point(303, 138);
            this.txtContador2.Name = "txtContador2";
            this.txtContador2.Size = new System.Drawing.Size(100, 22);
            this.txtContador2.TabIndex = 8;
            // 
            // txtContador10
            // 
            this.txtContador10.Location = new System.Drawing.Point(482, 138);
            this.txtContador10.Name = "txtContador10";
            this.txtContador10.Size = new System.Drawing.Size(100, 22);
            this.txtContador10.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Contador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contador 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Contador 10";
            // 
            // Bt_grafica
            // 
            this.Bt_grafica.Location = new System.Drawing.Point(667, 414);
            this.Bt_grafica.Name = "Bt_grafica";
            this.Bt_grafica.Size = new System.Drawing.Size(76, 43);
            this.Bt_grafica.TabIndex = 13;
            this.Bt_grafica.Text = "Grafica";
            this.Bt_grafica.UseVisualStyleBackColor = true;
            this.Bt_grafica.Click += new System.EventHandler(this.Bt_grafica_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(710, 8);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(32, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "x";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 469);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.Bt_grafica);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContador10);
            this.Controls.Add(this.txtContador2);
            this.Controls.Add(this.txtContador);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAlgo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAlgo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtContador;
        private System.Windows.Forms.TextBox txtContador2;
        private System.Windows.Forms.TextBox txtContador10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bt_grafica;
        private System.Windows.Forms.Button button7;
    }
}

