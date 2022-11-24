using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioV___SOP {
    internal class Program {
        static void Main(string[] args) {
            List<EntidadeFrames> frames = new List<EntidadeFrames>();
            Funcoes.Funcoes funcoes = new Funcoes.Funcoes();


            Console.WriteLine("Quantos frames você deseja adicionar?");
            Console.Write("R: ");
            int quantidadeFrames =int.Parse(Console.ReadLine());
            EntidadeFrames entidadeFrames = new EntidadeFrames();

            for (int i = 0; i < quantidadeFrames; i++) {
                entidadeFrames = new EntidadeFrames();
                Console.WriteLine("Frame: "+(i+1));
                entidadeFrames.Frame = i + 1;
                Console.Write("\r Tempo de carga: ");
                entidadeFrames.TempoCarga = Double.Parse(Console.ReadLine());
                Console.Write("\r Quantidade Referências: ");
                entidadeFrames.QuantidadeReferência = Double.Parse(Console.ReadLine());
                Console.Write("\r Tempo da última referência: ");
                entidadeFrames.TempoUltimaReferencia = Double.Parse(Console.ReadLine());
                Console.Write("\r BR: ");
                entidadeFrames.BR = int.Parse(Console.ReadLine());
                while (entidadeFrames.BR > 1 || entidadeFrames.BR < 0) {
                    Console.WriteLine("[BR] - Informe somente 1 ou 0:");
                    entidadeFrames.BR = int.Parse(Console.ReadLine());
                }
                Console.Write("\r BM: ");
                entidadeFrames.BM = int.Parse(Console.ReadLine());
                while (entidadeFrames.BM > 1 || entidadeFrames.BM < 0) {
                    Console.WriteLine("[BM] - Informe somente 1 ou 0:");
                    entidadeFrames.BM = int.Parse(Console.ReadLine());
                }
                frames.Add(entidadeFrames);
            }
            //Console.WriteLine("Substituição de página FIFO: ");
            //Console.Write("Frame:");
            //funcoes.FIFO(frames);
            //Console.WriteLine();

            //Console.WriteLine("Substituição de página LFU: ");
            //Console.Write("Frame:");
            //funcoes.FIFO(frames);
            //Console.WriteLine();

            //Console.WriteLine("Substituição de página LRU: ");
            //Console.Write("Frame:");
            //funcoes.FIFO(frames);
            //Console.WriteLine();

            //Console.WriteLine("Substituição de página NRU: ");
            //Console.Write("Frame:");
            //funcoes.FIFO(frames);
            //Console.WriteLine();


            Console.WriteLine(frames.Max(entidadeFrames.TempoUltimaReferencia);

            foreach (var frame in frames) {
                    
            }

        }
    }
}
