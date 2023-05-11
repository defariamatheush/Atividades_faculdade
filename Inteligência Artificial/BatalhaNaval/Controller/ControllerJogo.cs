using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatalhaNaval.Entidades;
using BatalhaNaval.Helpers;

namespace BatalhaNaval.Controller
{
    public class ControllerJogo
    {
        public bool Start(bool vezJogador,List<Posicoes> posicoesIa,List<Posicoes> posicoesPlayer)
        {            
            DataGridView dataGrid_Player = (DataGridView)Application.OpenForms ["TelaJogo"].Controls.Find("dt_Player",true).FirstOrDefault();
            DataGridView dataGrid_ia = (DataGridView)Application.OpenForms ["TelaJogo"].Controls.Find("dt_ia",true).FirstOrDefault();
            GroupBox gpbx_Player = (GroupBox)Application.OpenForms ["TelaJogo"].Controls.Find("gbx_player",true).FirstOrDefault();
            GroupBox gpbx_Ia = (GroupBox)Application.OpenForms ["TelaJogo"].Controls.Find("gbx_ia",true).FirstOrDefault();
            ControllerIA controllerIA = new ControllerIA();
            ControllerPlayer controllerPlayer = new ControllerPlayer();
            Helper helper = new Helper();
            switch (vezJogador)
            {
                case true:
                    dataGrid_ia.Enabled = true;
                    dataGrid_Player.Enabled = false;
                    gpbx_Ia.BackColor = Color.FromArgb(255,255,128);
                    gpbx_Player.BackColor = Color.Gray;
                    vezJogador = true;
                    break;
                case false:
                    dataGrid_ia.Enabled = false;
                    dataGrid_Player.Enabled = true;
                    gpbx_Player.BackColor = Color.FromArgb(255,255,128);
                    gpbx_Ia.BackColor = Color.Gray;
                    vezJogador = controllerIA.VezInteligenciaArtficial(posicoesIa,posicoesPlayer);
                    //var resultado = controllerIA.VezInteligenciaArtficial(posicoesIa,posicoesPlayer);
                    //if (resultado == false)
                    //{
                    //    vezJogador = false;
                    //    Start(vezJogador,posicoesIa,posicoesPlayer);
                    //}                        
                    //else
                    //{
                    //    vezJogador = true;
                    //    Start(vezJogador,posicoesIa,posicoesPlayer);                        
                    //}
                    break;
            }
            helper.AlterarCores(vezJogador,dataGrid_ia,dataGrid_Player);
            return vezJogador;
        }

        public bool VerificarPosicao(Posicoes posicoes,List<Posicoes> posicoesIa)
        {
            bool resultado = false;

            var resultaIa = posicoesIa.FindAll(x => x.X == posicoes.X && posicoes.Y == x.Y);

            //if(dt_player.Rows [posicoes.X].Cells [posicoes.Y].Style.BackColor == Color.Yellow)
            //    resultado= true;
            //else if(dt_player.Rows [posicoes.X].Cells [posicoes.Y].Style.BackColor == Color.SteelBlue) 
            //    resultado = false;
            if(resultaIa.Count() > 0)
                resultado= true;
            else
                resultado= false;
            return resultado;
        }


        public string VerificarPosicao(Posicoes posicoes,List<Posicoes> listPosicoes,DataGridView dt_player)
        {
            string resultado = "Errou";

            if (dt_player.Rows [posicoes.X].Cells [posicoes.Y].Style.BackColor == Color.Yellow)
                resultado = "Acertou";
            else if(dt_player.Rows [posicoes.X].Cells [posicoes.Y].Style.BackColor.Name == "0")
                resultado = "Errou";
            else if(dt_player.Rows [posicoes.X].Cells [posicoes.Y].Style.BackColor == Color.Red)
                resultado = "Repetir";
            else if(dt_player.Rows [posicoes.X].Cells [posicoes.Y].Style.BackColor == Color.Orange)
                resultado = "Repetir";

            return resultado;

        }

        public void AdicionarAfundados(string navioAfundado)
        {
            Label ia_afundados = (Label)Application.OpenForms ["TelaJogo"].Controls.Find("ia_afundados",true).FirstOrDefault();
            Label player_afundados = (Label)Application.OpenForms ["TelaJogo"].Controls.Find("player_afundados",true).FirstOrDefault();

            Label ia_restantes = (Label)Application.OpenForms ["TelaJogo"].Controls.Find("ia_restantes",true).FirstOrDefault();
            Label player_restantes = (Label)Application.OpenForms ["TelaJogo"].Controls.Find("player_restantes",true).FirstOrDefault();
            if (navioAfundado == "IA")
            {
                double valorrestantes = Convert.ToDouble(ia_restantes.Text);
                valorrestantes -= 1;
                ia_restantes.Text = valorrestantes.ToString();
                double valortxt = Convert.ToDouble(ia_afundados.Text);
                valortxt += 1;
                ia_afundados.Text = valortxt.ToString();
            }
            else if(navioAfundado == "Player")
            {
                double valorrestantes = Convert.ToDouble(player_restantes.Text);
                valorrestantes -= 1;
                player_restantes.Text = valorrestantes.ToString();
                double valortxt = Convert.ToDouble(player_afundados.Text);
                valortxt += 1;
                player_afundados.Text = valortxt.ToString();
            }
        }


    }
}
