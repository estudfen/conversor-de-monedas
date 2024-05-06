namespace conversor_de_monedas
{
    partial class monedas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtResultadoLibras = new System.Windows.Forms.TextBox();
			this.txtValorCambioDolares = new System.Windows.Forms.TextBox();
			this.txtValorCambioLibras = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtResultadoDolares = new System.Windows.Forms.TextBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(59, 151);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Salir";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(59, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = " Precio C$";
			// 
			// txtResultadoLibras
			// 
			this.txtResultadoLibras.Location = new System.Drawing.Point(258, 128);
			this.txtResultadoLibras.Name = "txtResultadoLibras";
			this.txtResultadoLibras.Size = new System.Drawing.Size(73, 23);
			this.txtResultadoLibras.TabIndex = 2;
			this.txtResultadoLibras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtResultadoLibras.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// txtValorCambioDolares
			// 
			this.txtValorCambioDolares.Location = new System.Drawing.Point(152, 99);
			this.txtValorCambioDolares.Name = "txtValorCambioDolares";
			this.txtValorCambioDolares.Size = new System.Drawing.Size(73, 23);
			this.txtValorCambioDolares.TabIndex = 3;
			this.txtValorCambioDolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtValorCambioDolares.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// txtValorCambioLibras
			// 
			this.txtValorCambioLibras.Location = new System.Drawing.Point(152, 126);
			this.txtValorCambioLibras.Name = "txtValorCambioLibras";
			this.txtValorCambioLibras.Size = new System.Drawing.Size(73, 23);
			this.txtValorCambioLibras.TabIndex = 4;
			this.txtValorCambioLibras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtValorCambioLibras.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(59, 122);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Limpiar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(59, 93);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "Calcular";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(231, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(21, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "C$";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(231, 134);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(21, 15);
			this.label3.TabIndex = 8;
			this.label3.Text = "C$";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(337, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(13, 15);
			this.label4.TabIndex = 9;
			this.label4.Text = "€";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(337, 102);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(27, 15);
			this.label5.TabIndex = 10;
			this.label5.Text = "US$";
			// 
			// txtResultadoDolares
			// 
			this.txtResultadoDolares.Location = new System.Drawing.Point(258, 99);
			this.txtResultadoDolares.Name = "txtResultadoDolares";
			this.txtResultadoDolares.Size = new System.Drawing.Size(73, 23);
			this.txtResultadoDolares.TabIndex = 11;
			this.txtResultadoDolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtResultadoDolares.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(125, 33);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(73, 23);
			this.txtCantidad.TabIndex = 12;
			this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtCantidad.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			// 
			// monedas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(484, 261);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.txtResultadoDolares);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.txtValorCambioLibras);
			this.Controls.Add(this.txtValorCambioDolares);
			this.Controls.Add(this.txtResultadoLibras);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "monedas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Conversion Monedas";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox txtResultadoLibras;
        private TextBox txtValorCambioDolares;
        private TextBox txtValorCambioLibras;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtResultadoDolares;
        private TextBox txtCantidad;
    }
}