// Classe abstrata Funcionario
public abstract class Funcionario
{
    // Propriedades
    public string? nome;
    public int matricula;

    // Lista de projetos
    List<string> projetos = new List<string>();

    // Construtor
    public Funcionario(string nome, int matricula)
    {
        this.nome = nome;
        this.matricula = matricula;
    }

    // Método abstrato para calcular o salário 
    public abstract double CalcularSalario();

    // Método abstrato para exibir informações
    public abstract void ExibirInformacoes();

    // Método sobrecarregado AdicionarProjeto
    public void AdicionarProjeto(string projeto)
    {
        projetos.Add(projeto);
    }

    public void AdicionarProjeto(List<string> projetos)
    {
        this.projetos.AddRange(projetos);
    }


}
