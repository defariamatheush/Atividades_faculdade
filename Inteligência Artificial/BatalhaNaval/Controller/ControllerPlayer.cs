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
    public class ControllerPlayer
    {
        ControllerJogo controllerJogo = new ControllerJogo();
        Helper helper = new Helper();
        public bool VezPlayer(Posicoes posicaoPlayer)
        {
            bool vezJogador;
            DataGridView dt_ia = (DataGridView)Application.OpenForms ["TelaJogo"].Controls.Find("dt_ia",true).FirstOrDefault();
            DataGridView dt_Player = (DataGridView)Application.OpenForms ["TelaJogo"].Controls.Find("dt_Player",true).FirstOrDefault();
            bool resultado = true;
            if (resultado == true)
            {
                MessageBox.Show("Você acertou, jogue novamente");
                helper.ColocarCor(dt_ia,posicaoPlayer.X,posicaoPlayer.Y,Color.Red);
                controllerJogo.AdicionarAfundados("Player");
                vezJogador = false;
            }
            else
            {
                MessageBox.Show("Você errou, vez do adversário!");
                helper.ColocarCor(dt_ia,posicaoPlayer.X,posicaoPlayer.Y,Color.Orange);
                vezJogador = true;
            }

            return vezJogador;
        }
    }
}
