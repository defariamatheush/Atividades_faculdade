using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Sistemas2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            Grafico.DataSource = new List<Processo>();
        }

        private void button2_Click(object sender, EventArgs e) {
            if(RB_Fifo.Checked != true && RB_Prioridade.Checked != true && RB_Sfj.Checked != true) {
                MessageBox.Show("Selecione o tipo de escalonamento");
            } else {
                GerarGrafico();
            }
        }
        private void GerarGrafico() {
            Grafico.Series.Clear();
            //random color
            Random random = new Random();
            //loop rows to draw multi line chart c#
            foreach (Processo t in processoBindingSource.DataSource as List<Processo>) {
                Grafico.Series.Add(t.NumProcesso);
                Grafico.Series[t.NumProcesso].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                Grafico.Series[t.NumProcesso].Legend = "Legend1";
                Grafico.Series[t.NumProcesso].ChartArea = "ChartArea1";
                Grafico.Series[t.NumProcesso].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //adding data
                for (int i = 1; i <= Valores.RowCount; i++)
                    Grafico.Series[t.NumProcesso].Points.AddXY(i, Convert.ToInt32(t[$"M{i}"]));
            }
        }        
    }
}
