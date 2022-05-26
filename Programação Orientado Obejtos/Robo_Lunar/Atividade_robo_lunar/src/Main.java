import javax.sound.midi.Soundbank;
import java.sql.SQLOutput;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
       Scanner leitor = new Scanner(System.in);

       Robo robo = new Robo(100, "Norte");

       boolean Loop = true;
       while (Loop){
           System.out.println("--------------------------");
           robo.statusRobo();
           System.out.println("--------------------------");
           System.out.println("O que deseja fazer?");
           System.out.println("1 - Mudar direcao");
           System.out.println("2 - Capturar foto");
           System.out.println("3 - Ir para frente");
           System.out.println("4 - Ir para tras");
           System.out.println("5 - Recarregar bateria");
           System.out.println("6 - Sair do sistema");

           switch (leitor.nextInt()){
               case 1:
                   System.out.println("Qual direcao?");
                   System.out.println("1 - Norte");
                   System.out.println("2 - Sul");
                   System.out.println("3 - Leste");
                   System.out.println("4 - Oeste");
                   switch (leitor.nextInt()){
                       case 1:
                           robo.mudarDirecao("Norte");
                           break;
                       case 2:
                           robo.mudarDirecao("Sul");
                           break;
                       case 3:
                           robo.mudarDirecao("Leste");
                           break;
                       case 4:
                           robo.mudarDirecao("Oeste");
                           break;
                       default:
                           System.out.println("Opcao invalida, informar novamente!");
                   }
                   break;
               case 2:
                   robo.capturarFoto();
                   break;
               case 3:
                   robo.movimentarFrente();
                   break;
               case 4:
                   robo.movimentarTras();
                   break;
               case 5:
                   robo.recarregarRobo();
                   break;
               case 6:
                   System.out.println("Sistema sendo finalizado");
                   Loop = false;
           }
       }
       leitor.close();
    }
}
