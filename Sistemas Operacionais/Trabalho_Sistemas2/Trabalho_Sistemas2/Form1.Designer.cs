namespace Trabalho_Sistemas2 {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.RB_Prioridade = new System.Windows.Forms.RadioButton();
            this.RB_Sfj = new System.Windows.Forms.RadioButton();
            this.RB_Fifo = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Valores = new System.Windows.Forms.DataGridView();
            this.processoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numProcessoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Valores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Grafico
            // 
            this.Grafico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "Grafico";
            this.Grafico.ChartAreas.Add(chartArea1);
            this.Grafico.Location = new System.Drawing.Point(12, 392);
            this.Grafico.Name = "Grafico";
            series1.ChartArea = "Grafico";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.Grafico.Series.Add(series1);
            this.Grafico.Size = new System.Drawing.Size(676, 274);
            this.Grafico.TabIndex = 0;
            this.Grafico.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.RB_Prioridade);
            this.groupBox2.Controls.Add(this.RB_Sfj);
            this.groupBox2.Controls.Add(this.RB_Fifo);
            this.groupBox2.Location = new System.Drawing.Point(458, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 178);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipos de escalonamento";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(16, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Gerar gráfico";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RB_Prioridade
            // 
            this.RB_Prioridade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RB_Prioridade.AutoSize = true;
            this.RB_Prioridade.Location = new System.Drawing.Point(66, 95);
            this.RB_Prioridade.Name = "RB_Prioridade";
            this.RB_Prioridade.Size = new System.Drawing.Size(91, 20);
            this.RB_Prioridade.TabIndex = 2;
            this.RB_Prioridade.TabStop = true;
            this.RB_Prioridade.Text = "Prioridade";
            this.RB_Prioridade.UseVisualStyleBackColor = true;
            // 
            // RB_Sfj
            // 
            this.RB_Sfj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RB_Sfj.AutoSize = true;
            this.RB_Sfj.Location = new System.Drawing.Point(66, 69);
            this.RB_Sfj.Name = "RB_Sfj";
            this.RB_Sfj.Size = new System.Drawing.Size(52, 20);
            this.RB_Sfj.TabIndex = 1;
            this.RB_Sfj.TabStop = true;
            this.RB_Sfj.Text = "SFJ";
            this.RB_Sfj.UseVisualStyleBackColor = true;
            // 
            // RB_Fifo
            // 
            this.RB_Fifo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RB_Fifo.AutoSize = true;
            this.RB_Fifo.Location = new System.Drawing.Point(66, 43);
            this.RB_Fifo.Name = "RB_Fifo";
            this.RB_Fifo.Size = new System.Drawing.Size(50, 20);
            this.RB_Fifo.TabIndex = 0;
            this.RB_Fifo.TabStop = true;
            this.RB_Fifo.Text = "Fifo";
            this.RB_Fifo.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(458, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 191);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alunos";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "UNIVILLE";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Engenharia de Software";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vinicius Braga Lovatto";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(56, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matheus Magno";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matheus Henrique de Faria";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Valores);
            this.groupBox1.Location = new System.Drawing.Point(17, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 375);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Processos";
            // 
            // Valores
            // 
            this.Valores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Valores.AutoGenerateColumns = false;
            this.Valores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Valores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numProcessoDataGridViewTextBoxColumn,
            this.tempoDataGridViewTextBoxColumn});
            this.Valores.DataSource = this.processoBindingSource;
            this.Valores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Valores.Location = new System.Drawing.Point(6, 21);
            this.Valores.Name = "Valores";
            this.Valores.RowHeadersWidth = 51;
            this.Valores.RowTemplate.Height = 24;
            this.Valores.Size = new System.Drawing.Size(405, 339);
            this.Valores.TabIndex = 0;
            // 
            // processoBindingSource
            // 
            this.processoBindingSource.DataSource = typeof(Trabalho_Sistemas2.Processo);
            // 
            // numProcessoDataGridViewTextBoxColumn
            // 
            this.numProcessoDataGridViewTextBoxColumn.DataPropertyName = "NumProcesso";
            this.numProcessoDataGridViewTextBoxColumn.HeaderText = "NumProcesso";
            this.numProcessoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numProcessoDataGridViewTextBoxColumn.Name = "numProcessoDataGridViewTextBoxColumn";
            this.numProcessoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tempoDataGridViewTextBoxColumn
            // 
            this.tempoDataGridViewTextBoxColumn.DataPropertyName = "Tempo";
            this.tempoDataGridViewTextBoxColumn.HeaderText = "Tempo";
            this.tempoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tempoDataGridViewTextBoxColumn.Name = "tempoDataGridViewTextBoxColumn";
            this.tempoDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 678);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Grafico);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabalho - Sistemas operacionais";
            ((System.ComponentModel.ISupportInitialize)(this.Grafico)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Valores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Grafico;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RB_Prioridade;
        private System.Windows.Forms.RadioButton RB_Sfj;
        private System.Windows.Forms.RadioButton RB_Fifo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Valores;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource processoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numProcessoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempoDataGridViewTextBoxColumn;
    }
}

