/*
Código desenvolvido para caráter educativo, onde poderá ter mais formas para reduzir o código, porém como não estarei sendo pago por 
este código, vai ficar assim mesmo.

Desenvolvido por Matheus Henrique de Faria
*/


import java.util.Arrays;
import java.util.Scanner;
import java.util.Random;

public class RotacionarMatriz {
    //Método para fazer a matriz rotacionar
    static int[][] rotacionarMatriz(int[][] matriz) {
        int novaMatriz[][] = new int[matriz.length][matriz.length];
        for (int coluna = 0; coluna < matriz.length; coluna++) {
            for (int linha = 0; linha < matriz.length; linha++) {
                novaMatriz[linha][(matriz.length - 1) - coluna] = matriz[coluna][linha];
            }
        }
        return novaMatriz;
    }
    //Método para fazer a iterar números na matriz
    static int[][] iterandoMatriz(int[][] matriz) {
        Scanner leitor = new Scanner(System.in);
        for (int i = 0; i < matriz.length; i++) {
            for (int j = 0; j < matriz.length; j++) {
                System.out.println("Informe o valor para a posição " + (j + 1) + " do campo " + (i + 1));
                System.out.print("Valor: ");
                matriz[i][j] = leitor.nextInt();
            }
        }
        leitor.close();
        return matriz;
    }
    //Método para randomizar os números dentro da matriz
    static int[][] randomizandoMatriz(int[][] matriz){
        Random gerador = new Random();

            for (int i = 0; i < matriz.length; i++) {
                for (int j = 0; j < matriz.length; j++) {
                    matriz[i][j] = gerador.nextInt(1, 9);
                }
            }
        return matriz;
    }

    //Começo do código
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Informe o tamanho da matriz quadrada:");
        int tamMatriz = scanner.nextInt();

        int matriz[][] = new int[tamMatriz][tamMatriz];
        int novaMatriz[][] = new int[tamMatriz][tamMatriz];

        System.out.println("Deseja gerar os números aleatórios? ");
        System.out.println("1 - [Sim]");
        System.out.println("2 - [Não]");
        int gerar = scanner.nextInt();
        while (gerar > 2) {
                System.out.println("Informe a opção correta!!");
                System.out.println("Informe novamente a opção correta");
                System.out.println("1 - [Sim]");
                System.out.println("2 - [Não]");
                gerar = scanner.nextInt();
        }
        if (gerar == 1) {
            matriz = randomizandoMatriz(matriz); //Matriz recebe valor do método randomizandoMatriz

        }else if (gerar == 2) {
            matriz = iterandoMatriz(matriz); //Matriz recebe valor do método iterandoMatriz
        }

        //Parte que vai mostrar os números da matriz original
        System.out.println("A matriz inicial:");
        for (int i = 0; i < tamMatriz; i++) {
            for (int j = 0; j < tamMatriz; j++) {
                System.out.print("[" + matriz[i][j] + "]");
            }
            System.out.print("\n");
        }

        System.out.println("Quantos graus deseja rotacionar?");
        System.out.println("Informe quantos graus deseja rotacionar:");
        System.out.println("90°");
        System.out.println("180°");
        System.out.println("270°");
        System.out.println("360°");
        int opcao = scanner.nextInt();

        while (opcao % 90 != 0 || opcao > 360) {
                System.out.println("Informe a opção correta!!");
                System.out.println("Informe novamente a opção correta");
                System.out.println("Informe quantos graus deseja rotacionar:");
                System.out.println("90°");
                System.out.println("180°");
                System.out.println("270°");
                System.out.println("360°");
                opcao = scanner.nextInt();
        }

        novaMatriz = matriz;
        if (opcao % 90 == 0 && opcao <= 360) {
            int rotacao = opcao / 90;
            for (int numRotacao = 0; numRotacao < rotacao; numRotacao++) {
                novaMatriz = rotacionarMatriz(novaMatriz);
            }
        }

        System.out.println("A matriz nova:");
        for (int i = 0; i < matriz.length; i++) {
            for (int j = 0; j < matriz.length; j++) {
                System.out.print("[" + novaMatriz[i][j] + "]");
            }
            System.out.print("\n");
        }
        scanner.close();
    }
}