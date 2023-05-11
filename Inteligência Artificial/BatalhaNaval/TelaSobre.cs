using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatalhaNaval
{
    public partial class TelaSobre : Form
    {
        public TelaSobre()
        {
            InitializeComponent();
        }

        private void TelaSobre_Deactivate(object sender,EventArgs e)
        {
            
        }

        private void TelaSobre_FormClosed(object sender,FormClosedEventArgs e)
        {
        }

        private void TelaSobre_FormClosing(object sender,FormClosingEventArgs e)
        {
            
        }

        private void inicio_Click(object sender,EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender,EventArgs e)
        {
            this.Hide();
            var form2 = new TelaInicio();
            form2.Closed += (s,args) => this.Close();
            form2.Show();
        }
    }
}
