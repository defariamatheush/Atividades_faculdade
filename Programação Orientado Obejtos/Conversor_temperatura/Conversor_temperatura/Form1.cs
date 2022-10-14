using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_temperatura {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            double resultadoConversao;
            if(de_C.Checked == true && Para_F.Checked == true) {
                resultadoConversao = double.Parse(valor.Text) * 1.8 + 32;
                resultado.Text = resultadoConversao.ToString() + " F"; 
            }if(de_C.Checked == true && Para_K.Checked == true) {
                resultadoConversao = double.Parse(valor.Text) + 273.15;
                resultado.Text = resultadoConversao.ToString() + " K";
            }if(de_C.Checked == true && Para_C.Checked == true) {
                resultado.Text = valor.Text;
            }if (de_F.Checked == true && Para_C.Checked == true) {
                resultadoConversao = (double.Parse(valor.Text) - 32) / 1.8;
                resultado.Text = resultadoConversao.ToString();
            }if(de_F.Checked == true && Para_K.Checked == true) {
                resultadoConversao = (double.Parse(valor.Text)-32)*(5/9)+273;
                resultado.Text = resultadoConversao.ToString();
            }if(de_F.Checked == true && Para_F.Checked == true) {
                resultado.Text = valor.Text;
            }if(de_K.Checked == true && Para_C.Checked == true) {
                resultadoConversao = double.Parse(valor.Text) - 273;
                resultado.Text = resultadoConversao.ToString();
            }if(de_K.Checked == true && Para_F.Checked == true) {
                resultadoConversao = (double.Parse(valor.Text)-273) * 1.8 +32;
                resultado.Text = resultadoConversao.ToString();
            }if(de_K.Checked == true && de_K.Checked == true) {
                resultado.Text = valor.Text;
            }
        }
    }
}
