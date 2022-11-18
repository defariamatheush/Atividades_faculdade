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
    public partial class Tarefas : Form {
        
        public Tarefas() {            
            InitializeComponent();
            TarefasPendentes();
        }

        private void Tarefas_Load(object sender, EventArgs e) {
            TarefasPendentes();
        }

        private void Btn_CadastrarTarefa_Click(object sender, EventArgs e) {
            telaCadastroTarefas telaCadastroTarefas = new telaCadastroTarefas();
            telaCadastroTarefas.Show();
            this.Hide();
        }

        private void DataGridTarefas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            string valorTarefa = DataGridTarefas.Rows[e.RowIndex].Cells[0].Value.ToString();
            string valorPrioridade = DataGridTarefas.Rows[e.RowIndex].Cells[1].Value.ToString();
            DialogResult resultado = MessageBox.Show("Deseja finalizar a tarefa?"+ "\n"+"Tarefa: "+ valorTarefa+ "\n"+"Prioridade: "+ valorPrioridade,"Finalizar tarefa", MessageBoxButtons.YesNo);
            switch (resultado) 
            {
                case DialogResult.Yes:
                    this.Hide();
                    FinalizarTarefa(valorTarefa, valorPrioridade);
                    this.Show();

                    TarefasPendentes();
                    break;
                case DialogResult.No:
                    MessageBox.Show("Operação cancelada!");

                    break;
            }
        }

        private void TarefasPendentes() {
            using (SqlConnection connection = new SqlConnection("Data Source=MATHEUSF\\SQLEXPRESS;Initial Catalog=Tarefas;Integrated Security=True")) {
                connection.Open();
                var sql = "SELECT DescTarefa as Tarefa,DescPrioridade as Prioridade FROM Tarefas.dbo.Tarefas WHERE StatusTarefa = 'Não Finalizado' ORDER BY Prioridade";
                using (SqlDataAdapter da = new SqlDataAdapter(sql, connection)) {
                    using (DataTable dt = new DataTable()) {
                        da.Fill(dt);
                        DataGridTarefas.DataSource = dt;
                    }
                }
                connection.Close();
            }
        }

        private void FinalizarTarefa(string descTarefa,string prioridade) 
        {
            try {
                using (SqlConnection SQLConection = new SqlConnection("Data Source=MATHEUSF\\SQLEXPRESS;Initial Catalog=Tarefas;Integrated Security=True")) {

                    StringBuilder mySQL = new StringBuilder();
                    mySQL.Append("UPDATE Tarefas.dbo.Tarefas SET StatusTarefa = 'Finalizado' WHERE DescTarefa ='"+descTarefa+ "' and DescPrioridade = '" + prioridade+"'");

                    SqlCommand command;
                    SQLConection.Open();
                    command = new SqlCommand(mySQL.ToString(), SQLConection);
                    command.ExecuteNonQuery();
                    SQLConection.Close();
                    MessageBox.Show("Tarefa finalizada");

                }
            } catch {
                MessageBox.Show("[Erro - Conexão com banco de dados]");
            }
        }
    }
}
