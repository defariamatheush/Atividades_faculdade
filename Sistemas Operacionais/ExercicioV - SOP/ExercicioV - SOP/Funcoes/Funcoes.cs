using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioV___SOP.Funcoes {
    public class Funcoes {
        public int FIFO(List<EntidadeFrames> listFrames) {
            //int numMaior = listFrames.Max();

            return 0;
        }

        public int LFU(EntidadeFrames entidadeFrames) {
            return entidadeFrames.Frame;
        }

        public int LRU(EntidadeFrames entidadeFrames) {
            return entidadeFrames.Frame;
        }

        public int NRU(EntidadeFrames entidadeFrames) {
            return entidadeFrames.Frame;
        }

        public int Desempate(){
            return 0;
        }
    }
}
