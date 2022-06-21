import java.util.List;
import java.util.Scanner;
import java.util.ArrayList;


public class Main {

    public static void main(String[] args){
        Scanner leitor = new Scanner(System.in);
        PessoaDAO DAO = new PessoaDAO();

        while (true){
            Pessoa pessoa = new Pessoa();
            System.out.println("Informe uma opcao: ");
            System.out.println("[1] - Procurar por ID");
            System.out.println("[2] - Ver Registros");
            System.out.println("[3] - Cadastrar nome");
            System.out.println("[4] - Deletar nome");
            System.out.println("[5] - Finalizar programa");
            System.out.print("Opcao:");
            int opcao = leitor.nextInt();
            leitor.nextLine();
            switch (opcao) {
                case 1:
                    System.out.println("Informe uma ID");
                    int id = leitor.nextInt();
                    System.out.println(DAO.getById(id));
                    break;
                case 2:
                    System.out.println("Registros:");
                    System.out.print("Cod   ");
                    System.out.print("|");
                    System.out.println("  Nome  ");
                    System.out.println("--------------");
                    for(Pessoa p: DAO.getAll()) {
                        System.out.print("|");
                        System.out.print("  "+p.getId());
                        System.out.print("|");
                        System.out.print("  "+p.getNome());
                        System.out.println("|");
                    }
                    break;
                case 3:
                    System.out.println("Informe um nome:");
                    String nome = leitor.nextLine();
                    System.out.println("Informe uma ID:");
                    id = leitor.nextInt();
                    pessoa.setNome(nome);
                    pessoa.setId(id);
                    DAO.add(pessoa);
                    break;
                case 4:
                    System.out.println("Informe uma ID para deletar:");
                    System.out.print("ID: ");
                    id = leitor.nextInt();
                    DAO.delete(DAO.getById(id));
                    break;
                case 5:
                    System.exit(0);
                    break;
            }
        }


/*
        ArrayList<List> pessoa = new ArrayList<>();
        ArrayList<Integer> listaId = new ArrayList<>();
        int id;
        ArrayList<String> listaNome = new ArrayList<>();
        String nome;
        Scanner leitor = new Scanner(System.in);

        System.out.print("Informe uma id: ");
        id = leitor.nextInt();
        System.out.print("Informe um nome: ");
        nome = leitor.next();
        listaId.add(id);
        listaNome.add(nome);
        System.out.print("Informe uma id: ");
        id = leitor.nextInt();
        System.out.print("Informe um nome: ");
        nome = leitor.next();
        listaId.add(id);
        listaNome.add(nome);
        pessoa.add(listaId);
        pessoa.add(listaNome);


        for(int i=0;i<listaId.size();i++) {
            if (i == 0) {
                System.out.print("Cod   ");
                System.out.print("|");
                System.out.println("  Nome  ");
                System.out.println("--------------");
                System.out.print("|");
                System.out.print("  "+listaId.get(i)+"  ");
                System.out.print("|");
                System.out.print("  "+listaNome.get(i)+"  ");
                System.out.println("|");
            } else {
                System.out.println("--------------");
                System.out.print("|");
                System.out.print("  "+listaId.get(i)+"  ");
                System.out.print("|");
                System.out.print("  "+listaNome.get(i)+"  ");
                System.out.println("|");
            }
        }

        leitor.close();
*/


    }

}
