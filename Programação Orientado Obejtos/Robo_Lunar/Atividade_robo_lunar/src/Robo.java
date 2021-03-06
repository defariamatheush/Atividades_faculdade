import java.util.Locale;
import java.util.Scanner;

public class Robo {

    private int bateria;
    private String direcao;


    public Robo(int bateria, String direcao){
        this.bateria = bateria;
        this.direcao = direcao;
    }

    public int getBateria(){
        return bateria;
    }

    private void setBateria(int bateria){
        this.bateria = bateria;
    }

    public String getDirecao(){
        return direcao;
    }

    private void setDirecao(String direcao){
        this.direcao = direcao;
    }

    public void statusRobo(){
        System.out.println("O status da bateria e de :"+getBateria()+",direcao: "+getDirecao());
    }

    public boolean temBateria(){
        if (getBateria() > 10){
            return true;
        }else{
            return false;
        }
    }

    public void movimentarFrente(){
        if (temBateria() == true){
            this.setBateria(getBateria() - 10);
            System.out.println("Moveu para frente");
        }else{
            System.out.println("Robo parado, necessario ser carregado");
        }
    }

    public void movimentarTras(){
        if (temBateria() == true){
            this.setBateria(getBateria() - 10);
            System.out.println("Moveu para tras");
        }else{
            System.out.println("Robo parado, necessario ser carregado");
        }
    }

    public void capturarFoto(){
        if (temBateria() == true){
            this.setBateria(getBateria() - 5);
            System.out.println("Foto tirada");
        }else{
            System.out.println("Robo parado, necessario ser carregado");
        }
    }

    public void mudarDirecao(String direcao){
       if (this.direcao.equalsIgnoreCase(direcao)){
           System.out.println("Ja está na mesma direcao");
       }else{
           if (temBateria() == true){
               this.setBateria(getBateria() - 10);
               setDirecao(direcao);
               System.out.println("Direcao virada para a :"+getDirecao());
           }else{
               System.out.println("Robo parado, necessario ser carregado");
           }
       }
    }

    public void recarregarRobo(){
        if(temBateria() == false){
            setBateria(100);
            System.out.println("Bateria sendo carregada...");
            System.out.println("Bateria carregada");
        }
    }












}
