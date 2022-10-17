import java.util.Scanner;


public class Principal {

    public static void main(String[] args) {
        try{
            Scanner leitor = new Scanner(System.in);
            boolean continuarPrograma = true;
            FuncoesDb funcoesDb = new FuncoesDb();
            funcoesDb.obterConexao();
            while(continuarPrograma) {
                System.out.println("#  MENU  #");
                System.out.println("1 - Criar tarefa");
                System.out.println("2 - Listar tarefas");
                System.out.println("3 - Concluir tarefa");
                System.out.println("4 - Alterar tarefa");
                System.out.println("0 - Sair do programa");
                System.out.print("Informe a opcao: ");

                var aux = leitor.nextInt();
                leitor.nextLine();
                switch (aux) {
                    case 0:
                        continuarPrograma = false;
                        break;
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;

                }
            }
            System.out.println("Programa finalizado");
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
    }

}


