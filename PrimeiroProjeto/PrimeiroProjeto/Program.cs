// Screen Sound

string mensagemDeBoasVindas = "Boas vindas ao Screen Soudd";
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

void ExibirMensagem()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░

");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirMensagem();
    Console.WriteLine("\nDigite 1 para registrar uma Banda ");
    Console.WriteLine("Digite 2 para mostrar todas as Bandas ");
    Console.WriteLine("Digite 3 Para avaliar uma Banda ");
    Console.WriteLine("Digite 4 para exibir a nota média de uma Banda ");
    Console.WriteLine("Digite 0 para sair");
    
    Console.Write("\nDigite uma opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);
    
    switch(opcaoEscolhidaNum)
    {
        case 1: AdicionarBanda();
            break;
        case 2: MostrarBandas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4:
            Console.WriteLine("Você escolhue a opção " + opcaoEscolhidaNum);
            break;
        case 0: Console.WriteLine("Programado encerrado!!");
            break;
        default: Console.WriteLine("Opção inválida!!!");
            break;

    }
}

void AdicionarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de Bandas!! ");
    Console.Write("Digite o nome da Banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A Banda {nomeDaBanda} foi registrada com sucesso!!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindos todas as Bandas registradas!!");
    
    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal!!");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda!!");
    Console.Write("Digite o nome da Banda que deseja avaliar: ");
    string nomeDabanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDabanda))
    {
        Console.Write($"Qual a nota que a Banda {nomeDabanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDabanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDabanda}");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    } else
    {
        Console.WriteLine($"\nA Banda {nomeDabanda}, não foi encontrada!!!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal: ");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirOpcoesDoMenu();