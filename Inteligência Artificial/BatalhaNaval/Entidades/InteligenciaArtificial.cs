using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BatalhaNaval.Entidades
{
    public class InteligenciaArtificial
    {
        private List<Posicoes> Posicoes{get;  set;}
        public bool AdicionarPosicao(Posicoes posicoes)
        {
            Posicoes.Add(posicoes);
            var elementosRepetidos = Posicoes.GroupBy(x => new { x.X,x.Y })
                                            .Where(g => g.Count() > 1)
                                            .Select(y => y.Key)
                                            .ToList();
            if (elementosRepetidos.Count() != 0)
            {
                Posicoes.RemoveAt(Posicoes.Count() - 1);
                return false;
            }
            else
            {
                return true;
            }              
        }

        public List<Posicoes> GetPosicoesIa()
        {
            return Posicoes;
        }
        public InteligenciaArtificial()
        {
            Posicoes = new List<Posicoes>();          
        }

    }
}
