using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioV___SOP.Funcoes {
    public class Funcoes {
        public int FIFO(List<EntidadeFrames> listFrames) {
            double fifo = 100;
            int idfifo = 0;
            foreach (var frame in listFrames) {
                if (frame.TempoCarga < fifo) {
                    idfifo = frame.Frame;
                    fifo = frame.TempoCarga;
                }
            }

            return idfifo;
        }

        public int LFU(List<EntidadeFrames> listFrames) {
            double lfu = 100;
            int idlfu = 0;
            foreach (var frame in listFrames) {
                if (frame.QuantidadeReferência < lfu) {
                    idlfu = frame.Frame;
                    lfu = frame.QuantidadeReferência;
                }
            }
            return idlfu;
        }

        public int LRU(List<EntidadeFrames> listFrames) {
            double lru = 100;
            int idlru = 0;
            foreach (var frame in listFrames) {
                if (frame.TempoUltimaReferencia < lru) {
                    idlru = frame.Frame;
                    lru = frame.TempoUltimaReferencia;
                }
            }
            return idlru;
        }

        public double NRU(List<EntidadeFrames> listFrames) {
            double nru1 = 0;
            double nru2 = 0;
            double nru3 = 0;

            double idnru = 0;
            foreach (var frame in listFrames) {
                if (frame.BR == 0 && frame.BM == 0) {
                    nru1 = frame.Frame;
                }else if(frame.BR == 1 && frame.BM == 0) {
                    nru2 = frame.Frame;
                } else if (frame.BR == 1 && frame.BM == 1) {
                    nru3 = frame.Frame;
                }
            }

            if(nru1 != 0) {
                idnru = nru1;
            }
            else if (nru2 != 0) {
                idnru = nru2;
            }
            else{
                idnru = nru3;
            }
            return idnru;
        }
    }
}
