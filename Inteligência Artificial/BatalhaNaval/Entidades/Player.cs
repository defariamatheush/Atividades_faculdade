using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatalhaNaval.Entidades
{
    public class Player
    {
        private List<Posicoes> Posicoes {
            get; set;
        }
        public void AdicionarPosicao(Posicoes posicoes)
        {
            Posicoes.Add(posicoes);
        }
        public Player()
        {
            Posicoes= new List<Posicoes>();
        }

        public List<Posicoes> GetPosicoesPlayer()
        {
            return Posicoes;
        }
    }
}
