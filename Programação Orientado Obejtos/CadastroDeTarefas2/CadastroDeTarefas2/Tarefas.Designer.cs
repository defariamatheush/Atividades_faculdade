namespace CadastroDeTarefas2 {
    partial class Tarefas {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridTarefas = new System.Windows.Forms.DataGridView();
            this.Btn_CadastrarTarefa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTarefas)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridTarefas
            // 
            this.DataGridTarefas.AllowUserToAddRows = false;
            this.DataGridTarefas.AllowUserToDeleteRows = false;
            this.DataGridTarefas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridTarefas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridTarefas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridTarefas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridTarefas.Location = new System.Drawing.Point(12, 12);
            this.DataGridTarefas.Name = "DataGridTarefas";
            this.DataGridTarefas.ReadOnly = true;
            this.DataGridTarefas.RowHeadersVisible = false;
            this.DataGridTarefas.RowHeadersWidth = 51;
            this.DataGridTarefas.RowTemplate.Height = 24;
            this.DataGridTarefas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridTarefas.Size = new System.Drawing.Size(358, 340);
            this.DataGridTarefas.TabIndex = 0;
            this.DataGridTarefas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridTarefas_CellContentDoubleClick);
            // 
            // Btn_CadastrarTarefa
            // 
            this.Btn_CadastrarTarefa.Location = new System.Drawing.Point(12, 358);
            this.Btn_CadastrarTarefa.Name = "Btn_CadastrarTarefa";
            this.Btn_CadastrarTarefa.Size = new System.Drawing.Size(358, 80);
            this.Btn_CadastrarTarefa.TabIndex = 1;
            this.Btn_CadastrarTarefa.Text = "Cadastrar tarefa";
            this.Btn_CadastrarTarefa.UseVisualStyleBackColor = true;
            this.Btn_CadastrarTarefa.Click += new System.EventHandler(this.Btn_CadastrarTarefa_Click);
            // 
            // Tarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.Btn_CadastrarTarefa);
            this.Controls.Add(this.DataGridTarefas);
            this.Name = "Tarefas";
            this.Text = "Tarefas";
            this.Load += new System.EventHandler(this.Tarefas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTarefas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_CadastrarTarefa;
        private System.Windows.Forms.DataGridView DataGridTarefas;
    }
}

