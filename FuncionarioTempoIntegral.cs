// Classe FuncionarioTempoIntegral que herda de Funcionario
public class FuncionarioTempoIntegral : Funcionario, IBonus
{
    // Atributo privado que armazena o salário mensal do funcionário
    private double salariomensal;

    // Construtor da classe que recebe nome, matrícula e salário mensal
    public FuncionarioTempoIntegral(string nome, int matricula, double salariomensal)
        : base(nome, matricula) // Chama o construtor da classe base (Funcionario)
    {
        // Atribui o valor do salário mensal ao atributo privado
        this.salariomensal = salariomensal;
    }

    // Método que calcula o salário do funcionário (sobrescreve o método da classe base)
    public override double CalcularSalario()
    {
        // Retorna o salário mensal do funcionário
        return salariomensal;
    }

    public double CalcularBonus()
    {
        return salariomensal * 0.10;
    }
    
    // Método que exibe as informações e calcula o salario com bonus
    public override void ExibirInformacoes()
    {
        double salario = CalcularSalario();
        double bonus = CalcularBonus();
        double total = salario + bonus;

        // Exibe as informações do funcionário no console
        Console.WriteLine($"Dados do Funcionario\n Nome:{nome}\n Matricula: {matricula}\n Salario Mensal: R${salariomensal}\n Bônus Obtido: R${bonus}\n Total: R${total}");
    }
}