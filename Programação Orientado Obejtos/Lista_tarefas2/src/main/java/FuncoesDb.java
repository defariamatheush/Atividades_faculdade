import javax.swing.*;
import java.sql.Connection;
import java.sql.DriverManager;

public class FuncoesDb {

    public String CriarTarefa(){
        String msg = "";

        return msg;
    }

    public Connection obterConexao(){
        Connection connection = null;
        try{
            String usuario = "mysql";
            String senha = "root";
            String bD = "Tarefas";
            String iP = "localhost";
            String porta = "1433";
            String stringConexao = "jdbc:microsoft:sqlserver://"+iP+":"+porta+";DatabaseName="+bD;

            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");

            connection = DriverManager.getConnection(stringConexao,usuario,senha);
            if (connection != null) {
                System.out.println("Connection Successful!");
            }

        }catch (Exception e){
            JOptionPane.showMessageDialog(null,"Erro ao conectar: "+e.toString());
        }
        return connection;
    }
}
