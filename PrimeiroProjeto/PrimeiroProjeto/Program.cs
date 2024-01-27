// Screen Sound

string mensagemDeBoasVindas = "Boas vindas ao Screen Soudd";
List<string> listaDeBandas = new List<string>();

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
    Console.WriteLine("\nDigite 1 para registrar uma banda ");
    Console.WriteLine("Digite 2 para mostrar todas as bandas ");
    Console.WriteLine("Digite 3 Para Avaliar uma Banda ");
    Console.WriteLine("Digite 4 para exibir a nota média de uma banda ");
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
        case 3: Console.WriteLine("Você escolhue a opção " + opcaoEscolhidaNum);
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
    Console.WriteLine("**************************");
    Console.WriteLine("Registro de Bandas");
    Console.WriteLine("**************************\n");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDeBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandas()
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("Exibindos todas as bandas registradas!!");
    Console.WriteLine("********************************************\n");

    foreach(string banda in listaDeBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal!!");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();