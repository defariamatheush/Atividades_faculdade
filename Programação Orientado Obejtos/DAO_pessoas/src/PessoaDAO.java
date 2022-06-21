import java.util.ArrayList;

public class PessoaDAO {

    private ArrayList<Pessoa> pessoas = new ArrayList<>();

    public PessoaDAO(){    }

    public Pessoa getById(int id){
        if(pessoas.isEmpty()){
            throw new RuntimeException("Não tem nenhuma pessoa na lista");
        } else{
            for (Pessoa p: this.pessoas){
                return p;
            }
        }
        return null;
    }

    public ArrayList<Pessoa> getAll(){
        if(pessoas.isEmpty()){
            throw new RuntimeException("Não tem nenhuma pessoa na lista");
        } else{
            return pessoas;
        }
    }

    public void add(Pessoa pessoa){
            if(pessoas.contains(pessoa)){
                throw new RuntimeException("Já contem essa pessoa");
            } else {
                this.pessoas.add(pessoa);
            }
    }

    public void delete(Pessoa pessoa){
        if(pessoas.contains(pessoa)) {
            this.pessoas.remove(pessoa);
        }
    }
}
