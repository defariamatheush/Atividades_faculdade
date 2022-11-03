import javax.swing.*;
import java.awt.*;

public class TelaTarefas {

    public static void main(String[] args) {
        JPanel panel = new JPanel();
        JPanel panelTarefas = new JPanel();
        panel.add(panelTarefas);
        JFrame frame = new JFrame();
        frame.setTitle("Tarefas");

        frame.setSize(420,420);
        frame.setResizable(false);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        panel.setLayout(null);
        panelTarefas.setLayout(null);

        panelTarefas.setBounds(50,90,300,250);
        panelTarefas.setBorder(BorderFactory.createEmptyBorder(0,10,10,10));
        panelTarefas.setBackground(Color.magenta);

        JLabel lbl_tarefa = new JLabel("Caixa de entrada");
        lbl_tarefa.setBounds(55,50,100,25);
        panel.add(lbl_tarefa);

        JScrollPane scrollPane = new JScrollPane(panelTarefas);
        frame.add(scrollPane);

        JButton novaTarefa = new JButton("Nova Tarefa");
        novaTarefa.setBounds(200,40,150,30);
        panel.add(novaTarefa);

        JRadioButton radioButton = new JRadioButton("Comprar carvão");
        radioButton.setBounds(150,330,100,30);
        panelTarefas.add(radioButton);

        panel.add(panelTarefas);
        frame.add(panel);
        frame.setVisible(true);
    }
}
