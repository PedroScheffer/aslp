public class FuncionarioMeioPeriodo : Funcionario, IBonus
{
    // Atributos da classe
    private double salariohora;
    private int horastrabalhadas;

    // Construtor da classe
    public FuncionarioMeioPeriodo(string nome, int matricula, double salariohora, int horastrabalhadas)
        : base(nome, matricula) // chama o construtor da classe base (Funcionario) com os parâmetros nome e matricula
    {
        // inicializa o atributo salariohora com o valor passado como parâmetro
        this.salariohora = salariohora;
        // inicializa o atributo horastrabalhadas com o valor passado como parâmetro
        this.horastrabalhadas = horastrabalhadas;
    }

    // Método que calcula o salário do funcionário
    public override double CalcularSalario()
    {
        // retorna o produto do valor da hora de trabalho e do número de horas trabalhadas
        return salariohora * horastrabalhadas;
    }
    public double CalcularBonus()
    {
        return CalcularSalario() * 0.05;
    }
    // Método que exibe as informações e calcula o salario com bonus
    public override void ExibirInformacoes()
    {
        double salario = CalcularSalario();
        double bonus = CalcularBonus();
        double total = salario + bonus;


        Console.WriteLine($"Dados do Funcionario\n Nome: {nome}\n Matricula: {matricula}\n Horas Trabalhadas: {horastrabalhadas}\n Valor Hora: R${salariohora}\n Salario: R${CalcularSalario()}\n Bônus Obtido: R${bonus}\n Total: R${total}");
    }
}