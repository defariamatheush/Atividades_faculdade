using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioV___SOP {
    public class EntidadeFrames {

        public int Frame { get; set; }
        public double TempoCarga { get; set; }
        public double QuantidadeReferência { get; set; }
        public double TempoUltimaReferencia { get; set; }
        public int BR { get; set; }
        public int BM { get; set; }

        public override string ToString() {
            return "Frame: " + Frame + "\n" +
                    "Tempo de carga: " + TempoCarga + "\n" +
                    "Quantidade de referência: " + QuantidadeReferência + "\n" +
                    "Tempo da ultima referência: " + TempoUltimaReferencia + "\n" +
                    "BR: " + BR + "\n" +
                    "BM: " + BM + "\n";

        }
    }
}
