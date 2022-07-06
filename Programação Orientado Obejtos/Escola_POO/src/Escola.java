import java.util.ArrayList;
import java.util.Scanner;

public class Escola {
    public static void main(String[] args) {

        int quantidadeAlunos, quantidadeNotas;
        Scanner leitor = new Scanner(System.in);
        System.out.print("Informe a quantidade de alunos: ");
        quantidadeAlunos = leitor.nextInt();
        System.out.print("Informe a quantidade de notas: ");
        quantidadeNotas = leitor.nextInt();

        for(int i = 0; i < quantidadeAlunos;i++) {
            ArrayList<String> listaNomes = new ArrayList<>();
            ArrayList<String> listaCod = new ArrayList<>();
            System.out.print("Informe o nome do aluno numero " + (i + 1) + ": ");
            listaNomes.add(leitor.next());
            System.out.println("Codigo do aluno gerado: "+(i+1));
            listaCod.add(String.valueOf(i+1));
            ArrayList<Integer> listaPesos = new ArrayList<>();
            ArrayList<Integer> listaNotas = new ArrayList<>();
            for (int j = 0; j < quantidadeNotas; j++) {
                System.out.print("Informe a nota "+(j+1)+" do aluno: " + (j + 1) + ": ");
                listaNotas.add(leitor.nextInt());
                System.out.print("Informe o peso da nota: ");
                listaPesos.add(leitor.nextInt());
            }
            if(i < quantidadeAlunos){
                int valorPesos = 0;
                int valorNotas = 0;
                int valor1 = 0;
                for (int c = 0; c < quantidadeAlunos; c++){
                    System.out.println("Codigo: "+listaCod.get(c));
                    System.out.println("Nome: "+listaNomes.get(c));
                    for (int n = 0; n < quantidadeNotas;n++){
                        System.out.println("Nota "+(n+1)+" : "+listaNotas.get(n));
                        valorPesos = Integer.parseInt(String.valueOf(valorPesos + listaPesos.get(n)));
                        valor1 = Integer.parseInt(String.valueOf(listaNotas.get(n)*listaPesos.get(n)));
                        valorNotas = Integer.parseInt(String.valueOf(valorNotas + valor1));
                    }
                    float media = valorNotas/valorPesos;
                    System.out.println("Media: "+media);


                }
            }
        }
    }
}
