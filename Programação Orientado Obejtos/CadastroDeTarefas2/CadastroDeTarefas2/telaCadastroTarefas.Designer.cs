namespace CadastroDeTarefas2 {
    partial class telaCadastroTarefas {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CheckBox = new System.Windows.Forms.CheckBox();
            this.ComboBoxPrioridade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxTarefa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSize = true;
            this.CheckBox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.CheckBox.Location = new System.Drawing.Point(38, 328);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(104, 28);
            this.CheckBox.TabIndex = 12;
            this.CheckBox.Text = "Finalizado";
            this.CheckBox.UseVisualStyleBackColor = true;
            // 
            // ComboBoxPrioridade
            // 
            this.ComboBoxPrioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPrioridade.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.ComboBoxPrioridade.FormattingEnabled = true;
            this.ComboBoxPrioridade.Items.AddRange(new object[] {
            "Alto",
            "Médio",
            "Baixo"});
            this.ComboBoxPrioridade.Location = new System.Drawing.Point(38, 259);
            this.ComboBoxPrioridade.Name = "ComboBoxPrioridade";
            this.ComboBoxPrioridade.Size = new System.Drawing.Size(224, 32);
            this.ComboBoxPrioridade.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prioridade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tarefa";
            // 
            // TextBoxTarefa
            // 
            this.TextBoxTarefa.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.TextBoxTarefa.Location = new System.Drawing.Point(38, 55);
            this.TextBoxTarefa.Multiline = true;
            this.TextBoxTarefa.Name = "TextBoxTarefa";
            this.TextBoxTarefa.Size = new System.Drawing.Size(428, 107);
            this.TextBoxTarefa.TabIndex = 8;
            // 
            // telaCadastroTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CheckBox);
            this.Controls.Add(this.ComboBoxPrioridade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxTarefa);
            this.Name = "telaCadastroTarefas";
            this.Text = "telaCadastroTarefas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox CheckBox;
        private System.Windows.Forms.ComboBox ComboBoxPrioridade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxTarefa;
    }
}