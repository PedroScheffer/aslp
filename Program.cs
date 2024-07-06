public class Program
{
    public static void Main(string[] args)
    {
        Empresa minhaEmpresa = new Empresa();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Adicionar funcionário de tempo integral");
            Console.WriteLine("2. Adicionar funcionário de meio período");
            Console.WriteLine("3. Remover funcionário");
            Console.WriteLine("4. Exibir informações de todos os funcionários");
            Console.WriteLine("5. Adicionar projeto(s) a um funcionário");
            Console.WriteLine("6. Sair do programa");
            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o nome do funcionário em tempo integral: ");
                    string nomeIntegral = Console.ReadLine();
                    Console.Write("Digite a matrícula do funcionário: ");
                    int matriculaIntegral = int.Parse(Console.ReadLine());
                    Console.Write("Digite o salário mensal do funcionário: ");
                    double salarioMensalIntegral = double.Parse(Console.ReadLine());

                    FuncionarioTempoIntegral funcionarioIntegral = new FuncionarioTempoIntegral(nomeIntegral, matriculaIntegral, salarioMensalIntegral);
                    minhaEmpresa.AdicionarFuncionario(funcionarioIntegral);
                    Console.WriteLine("Funcionário adicionado com sucesso!");
                    break;
                case 2:
                    Console.Write("Digite o nome do funcionário de meio período: ");
                    string nomeMeioPeriodo = Console.ReadLine();
                    Console.Write("Digite a matrícula do funcionário: ");
                    int matriculaMeioPeriodo = int.Parse(Console.ReadLine());
                    Console.Write("Digite o valor da hora de trabalho: ");
                    double salarioHoraMeioPeriodo = double.Parse(Console.ReadLine());
                    Console.Write("Digite o número de horas trabalhadas: ");
                    int horasTrabalhadasMeioPeriodo = int.Parse(Console.ReadLine());

                    FuncionarioMeioPeriodo funcionarioMeioPeriodo = new FuncionarioMeioPeriodo(nomeMeioPeriodo, matriculaMeioPeriodo, salarioHoraMeioPeriodo, horasTrabalhadasMeioPeriodo);
                    minhaEmpresa.AdicionarFuncionario(funcionarioMeioPeriodo);
                    Console.WriteLine("Funcionário adicionado com sucesso!");
                    break;
                case 3:
                    Console.Write("Digite a matrícula do funcionário a ser removido: ");
                    int matriculaRemover = int.Parse(Console.ReadLine());
                    minhaEmpresa.RemoverFuncionario(matriculaRemover);
                    break;
                case 4:
                    minhaEmpresa.ExibirFuncionarios();
                    break;
                case 5:
                    Console.Write("Digite a matrícula do funcionário: ");
                    int matriculaFuncionario = int.Parse(Console.ReadLine());

                    // Encontrar o funcionário com a matrícula informada
                    Funcionario funcionarioEncontrado = minhaEmpresa.EncontrarFuncionarioPorMatricula(matriculaFuncionario);

                    if (funcionarioEncontrado != null)
                    {
                        Console.Write("Digite o nome do projeto a ser adicionado: ");
                        string nomeProjeto = Console.ReadLine();

                        // Adicionar o projeto ao funcionário
                        funcionarioEncontrado.AdicionarProjeto(nomeProjeto);
                        Console.WriteLine($"Projeto '{nomeProjeto}' adicionado ao funcionário {funcionarioEncontrado.nome}.");
                    }
                    else
                    {
                        Console.WriteLine("Funcionário não encontrado. Verifique a matrícula informada.");
                    }
                    break;

                case 6:
                    Console.WriteLine("Programa encerrado.");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}