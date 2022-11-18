using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeTarefas2 {
    public partial class telaCadastroTarefas : Form {
        Tarefas telaTarefas = new Tarefas();
        public telaCadastroTarefas() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            try {
                using (SqlConnection SQLConection = new SqlConnection("Data Source=MATHEUSF\\SQLEXPRESS;Initial Catalog=Tarefas;Integrated Security=True")) {

                    StringBuilder mySQL = new StringBuilder();
                    mySQL.Append("INSERT INTO Tarefas.dbo.Tarefas (");
                    mySQL.Append("DescTarefa,Prioridade,StatusTarefa,DescPrioridade");
                    mySQL.Append(")VALUES('");
                    mySQL.Append(TextBoxTarefa.Text + "'");
                    if (ComboBoxPrioridade.Text == "Alto") {
                        mySQL.Append("," + 1 + ",");
                    }
                    if (ComboBoxPrioridade.Text == "Médio") {
                        mySQL.Append("," + 2 + ",");
                    }
                    if (ComboBoxPrioridade.Text == "Baixo") {
                        mySQL.Append("," + 3 + ",");
                    }
                    if (CheckBox.Checked == true) {
                        mySQL.Append("'Finalizado'");
                    } else {
                        mySQL.Append("'Não finalizado'");
                    }
                    mySQL.Append(",'"+ComboBoxPrioridade.Text+"')");
                    SqlCommand command;
                    SQLConection.Open();
                    command = new SqlCommand(mySQL.ToString(), SQLConection);
                    command.ExecuteNonQuery();
                    SQLConection.Close();
                    MessageBox.Show("Tarefa cadastrada");
                }
            } catch {
                MessageBox.Show("[Erro - Conexão com banco de dados]");
            }
            this.Close();
            telaTarefas.Show();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
            telaTarefas.Show();
        }
    }
}
