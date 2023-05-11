using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatalhaNaval.Helpers;
using BatalhaNaval.Entidades;
using BatalhaNaval.Controller;
using System.Runtime.ConstrainedExecution;

namespace BatalhaNaval
{
    public partial class TelaJogo : Form
    {
        Helper helper = new Helper();
        Player player = new Player();
        int contPosPlayer = 0;
        bool start = false;
        bool vezJogador = true;
        ControllerIA controllerIA = new ControllerIA();
        ControllerPlayer controllerPlayer = new ControllerPlayer();
        ControllerJogo controllerStart = new ControllerJogo();
        List<Posicoes> posicoesIa = new List<Posicoes>();

        public TelaJogo()
        {
            TelaInicio tela = new TelaInicio();
            tela.Hide();
            InitializeComponent();
            helper.AdicionarLinhas(dt_Player);
            helper.AdicionarLinhas(dt_ia);

        }

        private void dt_Player_CellDoubleClick(object sender,DataGridViewCellEventArgs e)
        {
            Posicoes posicoes = new Posicoes();
            posicoes.X = dt_Player.CurrentCell.RowIndex;
            posicoes.Y = dt_Player.CurrentCell.ColumnIndex;
            if (start != true)
            {
                player.AdicionarPosicao(posicoes);
                if(dt_Player.Rows [posicoes.X].Cells [posicoes.Y].Style.BackColor.Name == "0")
                {
                    helper.ColocarCor(dt_Player,dt_Player.CurrentCell.RowIndex,dt_Player.CurrentCell.ColumnIndex,Color.Yellow);
                    contPosPlayer += 1;
                    player_restantes.Text = contPosPlayer.ToString();
                    Contador();
                }
                else
                {
                    MessageBox.Show("Já foi preenchido");
                }
            }
            else
            {
                if (dt_ia.Rows [posicoes.X].Cells [posicoes.Y].Style.BackColor == Color.Orange)
                {
                    MessageBox.Show("Posição já foi usada");
                }
                else if (dt_ia.Rows [posicoes.X].Cells [posicoes.Y].Style.BackColor == Color.Red)
                {
                    MessageBox.Show("Posição já foi estourada");
                }
            }
        }
        private async void Contador()
        {
            if (contPosPlayer == 10)
            {
                TrocarCor();
                Start();
            }
        }

        private void TrocarCor()
        {
            dt_Player.DefaultCellStyle.SelectionBackColor = Color.Yellow;
        }

        private async void Start()
        {
            if (start != true)
            {
                MessageBox.Show("Que os jogos comecem!! \n Bom jogo!!");
                MessageBox.Show("Sua vez!");
                dt_ia.Enabled = true;
                dt_Player.Enabled = false;
                start = true;
                Start();
            }
            else
            {
                List<Posicoes> posicoesPlayer = player.GetPosicoesPlayer();

                if (posicoesIa.Count == 0)
                    posicoesIa = controllerIA.GerarCampos(dt_ia);

                if (posicoesIa.Count() == 10)
                {
                    if (vezJogador == true)
                    {
                        vezJogador = controllerStart.Start(vezJogador,posicoesIa,posicoesPlayer);
                    }
                    else
                    {
                        while (vezJogador == false)
                        {
                            vezJogador = controllerStart.Start(vezJogador,posicoesIa,posicoesPlayer);
                        }
                        Start();
                    }
                }
            }

        }

        private void dt_ia_CellDoubleClick(object sender,DataGridViewCellEventArgs e)
        {
            if (dt_ia.Enabled == true && vezJogador == true)
            {
                Posicoes posicoes = new Posicoes();
                posicoes.X = dt_ia.CurrentCell.RowIndex;
                posicoes.Y = dt_ia.CurrentCell.ColumnIndex;
                bool resultado = controllerStart.VerificarPosicao(posicoes,posicoesIa);
                if (resultado == false)
                {
                    MessageBox.Show("Errou! Vez do adversário!");
                    helper.ColocarCor(dt_ia,posicoes.X,posicoes.Y,Color.Orange);
                    vezJogador = false;
                    Start();
                }
                else
                {
                    MessageBox.Show("Navio afundado, sua vez novamente");
                    helper.ColocarCor(dt_ia,posicoes.X,posicoes.Y,Color.Red);
                    controllerStart.AdicionarAfundados("IA");
                    vezJogador = true;
                    Start();
                }
            }
        }
        private void ValorFinal(object sender,EventArgs e)
        {
            if (ia_afundados.Text == "10")
            {
                MessageBox.Show("PARABÉNS! VOCÊ GANHOU!");
            }
            else if (player_afundados.Text == "10")
            {
                MessageBox.Show("QUE PENA! VOCÊ PERDEU!");
            }
        }

        private void dt_Player_CellContentClick(object sender,DataGridViewCellEventArgs e)
        {
            Posicoes posicoes = new Posicoes();
            posicoes.X = dt_Player.CurrentCell.RowIndex;
            posicoes.Y = dt_Player.CurrentCell.ColumnIndex;
            if (start != true)
            {
                if (dt_Player.Rows [posicoes.X].Cells [posicoes.Y].Style.BackColor == Color.SteelBlue)
                {
                    player.AdicionarPosicao(posicoes);
                    helper.ColocarCor(dt_Player,dt_Player.CurrentCell.RowIndex,dt_Player.CurrentCell.ColumnIndex,Color.Yellow);
                    contPosPlayer += 1;
                    player_restantes.Text = contPosPlayer.ToString();
                    Contador();
                }

            }
            else
            {
                if (dt_ia.Rows [posicoes.X].Cells [posicoes.Y].Style.BackColor == Color.Orange)
                {
                    MessageBox.Show("Posição já foi usada");
                }
                else if (dt_ia.Rows [posicoes.X].Cells [posicoes.Y].Style.BackColor == Color.Red)
                {
                    MessageBox.Show("Posição já foi estourada");
                }
            }
        }

        private void TelaJogo_Load(object sender,EventArgs e)
        {
        }

        private void button1_Click(object sender,EventArgs e)
        {
            this.Hide();
            var form2 = new TelaInicio();
            form2.Closed += (s,args) => this.Close();
            form2.Show();
        }

        private void inicio_Click(object sender,EventArgs e)
        {
            this.Close();
        }
    }
}
