// Screen Soud

string mensagemDeBoasVindas = "Boas vindas ao Screen Soudd";

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
        case 1: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNum);
            break;
        case 2: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNum);
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

ExibirMensagem();

ExibirOpcoesDoMenu();