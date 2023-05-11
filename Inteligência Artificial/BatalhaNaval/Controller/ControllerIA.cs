using BatalhaNaval.Entidades;
using BatalhaNaval.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatalhaNaval.Controller
{

    public class ControllerIA
    {
        ControllerJogo controllerStart = new ControllerJogo();
        InteligenciaArtificial inteligenciaArtificial = new InteligenciaArtificial();
        List<Posicoes> posicoesUsadas = new List<Posicoes>();
        Helper helper = new Helper(); 
        public List<Posicoes> GerarCampos(DataGridView dataGrid)
        {
            Label ia_restantes = (Label)Application.OpenForms ["TelaJogo"].Controls.Find("ia_restantes",true).FirstOrDefault();
            Random randNum = new Random();
            for (int cont = 0; cont <= 9; cont++)
            {
                Posicoes posicoes = new Posicoes();
                posicoes.X = randNum.Next(10);
                posicoes.Y = randNum.Next(10);

                var result = inteligenciaArtificial.AdicionarPosicao(posicoes);
                if (result == false)
                    cont--;
                else
                {
                    cont++;
                    ia_restantes.Text = cont.ToString();
                    cont--;
                }
                    
            }
            return inteligenciaArtificial.GetPosicoesIa();
        }

        public bool VezInteligenciaArtficial(List<Posicoes> posicoesIa,List<Posicoes> posicoesPlayer)
        {
            bool vezJogador = false;
            DataGridView dataGrid_Player = (DataGridView)Application.OpenForms ["TelaJogo"].Controls.Find("dt_Player",true).FirstOrDefault();
            Posicoes posicaoIa = GerarPosicoes(dataGrid_Player);

            string resultado = controllerStart.VerificarPosicao(posicaoIa,posicoesPlayer,dataGrid_Player);

            switch (resultado)
            {
                case "Acertou":
                    MessageBox.Show("Adversário acertou, vez do adversário");
                    helper.ColocarCor(dataGrid_Player,posicaoIa.X,posicaoIa.Y,Color.Red);
                    controllerStart.AdicionarAfundados("Player");
                    vezJogador = false;
                    break;
                case "Repetir":
                    posicaoIa = new Posicoes();
                    VezInteligenciaArtficial(posicoesIa,posicoesPlayer);
                    break;
                case "Errou":
                    MessageBox.Show("Adversário errou, sua vez!");
                    helper.ColocarCor(dataGrid_Player,posicaoIa.X,posicaoIa.Y,Color.Orange);
                    vezJogador = true;
                    break;
            }            
            return vezJogador;
        }

        public Posicoes GerarPosicoes(DataGridView dt_player)
        {
            
            Random randNum = new Random();
            Posicoes posicoes = new Posicoes();
            for (int cont = 0; cont == 0; cont++)
            { 
                posicoes.X = randNum.Next(10);
                posicoes.Y = randNum.Next(10);

                if (dt_player.Rows [posicoes.X].Cells[posicoes.Y].Style.BackColor == Color.Yellow || dt_player.Rows [posicoes.X].Cells [posicoes.Y].Style.BackColor == Color.SteelBlue)
                {
                    var result = AdicionarPosicao(posicoes);
                    if (result == false)
                        cont--;
                }
                else if(dt_player.Rows [posicoes.X].Cells [posicoes.Y].Style.BackColor == Color.Orange || dt_player.Rows [posicoes.X].Cells [posicoes.Y].Style.BackColor == Color.Red)
                {
                    cont--;
                }                
            }
            return posicoes;
        }

        private bool AdicionarPosicao(Posicoes posicoes)
        {
            posicoesUsadas.Add(posicoes);
            var elementosRepetidos = posicoesUsadas.GroupBy(x => new { x.X,x.Y })
                                            .Where(g => g.Count() > 1)
                                            .Select(y => y.Key)
                                            .ToList();
            if (elementosRepetidos.Count() != 0)
            {
                posicoesUsadas.RemoveAt(posicoesUsadas.Count() - 1);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
