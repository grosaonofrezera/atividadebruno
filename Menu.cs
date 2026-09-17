while (true)
{
    Console.Clear();

    Console.WriteLine("===========================");
    Console.WriteLine("    SISTEMA DE JOGADORES");
    Console.WriteLine("===========================");
    Console.WriteLine();
    Console.WriteLine("1 - Cadastrar jogador");
    Console.WriteLine("2 - Listar jogadores");
    Console.WriteLine("3 - Buscar jogador");
    Console.WriteLine("4 - Atualizar jogador");
    Console.WriteLine("5 - Excluir jogador");
    Console.WriteLine("0 - Sair");
    Console.WriteLine();
    Console.Write("Escolha uma opção: ");

    int opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {
        Console.WriteLine("Cadastrar jogador");
    }
    else if (opcao == 2)
    {
        Console.WriteLine("Listar jogadores");
    }
    else if (opcao == 3)
    {
        Console.WriteLine("Buscar jogador");
    }
    else if (opcao == 4)
    {
        Console.WriteLine("Atualizar jogador");
    }
    else if (opcao == 5)
    {
        Console.WriteLine("Excluir jogador");
    }
    else if (opcao == 0)
    {
        Console.WriteLine("Saindo...");
        break;
    }
    else
    {
        Console.WriteLine("Opção inválida!");
    }

    Console.WriteLine();
    Console.WriteLine("Pressione ENTER para continuar...");
    Console.ReadLine();
}