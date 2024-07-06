public class Empresa
{
    public List<Funcionario> funcionarios = new List<Funcionario>();

    public void AdicionarFuncionario(Funcionario funcionario)
    {
        funcionarios.Add(funcionario);
    }

    public void RemoverFuncionario(int matricula)
    {
        funcionarios.RemoveAll(f => f.matricula == matricula);
    }

    public void ExibirFuncionarios()
    {
        Console.WriteLine("Lista de funcionários:");
        foreach (var funcionario in funcionarios)
        {
            funcionario.ExibirInformacoes();
        }
    }
    // METODO PARA O CASE 5
    public Funcionario EncontrarFuncionarioPorMatricula(int matricula)
    {
        return funcionarios.FirstOrDefault(f => f.matricula == matricula);
    }
}
