namespace Conversor_temperatura {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.de_K = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.de_F = new System.Windows.Forms.RadioButton();
            this.de_C = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Para_C = new System.Windows.Forms.RadioButton();
            this.Para_F = new System.Windows.Forms.RadioButton();
            this.Para_K = new System.Windows.Forms.RadioButton();
            this.valor = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // de_K
            // 
            this.de_K.AutoSize = true;
            this.de_K.Location = new System.Drawing.Point(39, 31);
            this.de_K.Name = "de_K";
            this.de_K.Size = new System.Drawing.Size(64, 20);
            this.de_K.TabIndex = 0;
            this.de_K.TabStop = true;
            this.de_K.Text = "Kelvin";
            this.de_K.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.valor);
            this.groupBox1.Controls.Add(this.de_C);
            this.groupBox1.Controls.Add(this.de_F);
            this.groupBox1.Controls.Add(this.de_K);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 175);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "De";
            // 
            // de_F
            // 
            this.de_F.AutoSize = true;
            this.de_F.Location = new System.Drawing.Point(39, 67);
            this.de_F.Name = "de_F";
            this.de_F.Size = new System.Drawing.Size(86, 20);
            this.de_F.TabIndex = 1;
            this.de_F.TabStop = true;
            this.de_F.Text = "fahrenheit";
            this.de_F.UseVisualStyleBackColor = true;
            // 
            // de_C
            // 
            this.de_C.AutoSize = true;
            this.de_C.Location = new System.Drawing.Point(39, 104);
            this.de_C.Name = "de_C";
            this.de_C.Size = new System.Drawing.Size(72, 20);
            this.de_C.TabIndex = 2;
            this.de_C.TabStop = true;
            this.de_C.Text = "Celsius";
            this.de_C.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultado);
            this.groupBox2.Controls.Add(this.Para_C);
            this.groupBox2.Controls.Add(this.Para_F);
            this.groupBox2.Controls.Add(this.Para_K);
            this.groupBox2.Location = new System.Drawing.Point(242, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 175);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Para";
            // 
            // Para_C
            // 
            this.Para_C.AutoSize = true;
            this.Para_C.Location = new System.Drawing.Point(39, 104);
            this.Para_C.Name = "Para_C";
            this.Para_C.Size = new System.Drawing.Size(72, 20);
            this.Para_C.TabIndex = 2;
            this.Para_C.TabStop = true;
            this.Para_C.Text = "Celsius";
            this.Para_C.UseVisualStyleBackColor = true;
            // 
            // Para_F
            // 
            this.Para_F.AutoSize = true;
            this.Para_F.Location = new System.Drawing.Point(39, 67);
            this.Para_F.Name = "Para_F";
            this.Para_F.Size = new System.Drawing.Size(86, 20);
            this.Para_F.TabIndex = 1;
            this.Para_F.TabStop = true;
            this.Para_F.Text = "fahrenheit";
            this.Para_F.UseVisualStyleBackColor = true;
            // 
            // Para_K
            // 
            this.Para_K.AutoSize = true;
            this.Para_K.Location = new System.Drawing.Point(39, 31);
            this.Para_K.Name = "Para_K";
            this.Para_K.Size = new System.Drawing.Size(64, 20);
            this.Para_K.TabIndex = 0;
            this.Para_K.TabStop = true;
            this.Para_K.Text = "Kelvin";
            this.Para_K.UseVisualStyleBackColor = true;
            // 
            // valor
            // 
            this.valor.Location = new System.Drawing.Point(6, 143);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(188, 22);
            this.valor.TabIndex = 4;
            // 
            // resultado
            // 
            this.resultado.Enabled = false;
            this.resultado.Location = new System.Drawing.Point(6, 143);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(188, 22);
            this.resultado.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(430, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Converter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 251);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton de_K;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.RadioButton de_C;
        private System.Windows.Forms.RadioButton de_F;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.RadioButton Para_C;
        private System.Windows.Forms.RadioButton Para_F;
        private System.Windows.Forms.RadioButton Para_K;
        private System.Windows.Forms.Button button1;
    }
}

