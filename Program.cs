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
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Posição: ");
        string posicao = Console.ReadLine();

        Console.Write("Número da camisa: ");
        int numeroCamisa = int.Parse(Console.ReadLine());

        Jogador jogador = new Jogador(
            nome,
            idade,
            posicao,
            numeroCamisa
        );

        JogadorDAO dao = new JogadorDAO();

        dao.Inserir(jogador);

        Console.WriteLine();
        Console.WriteLine("Jogador cadastrado com sucesso!");
    }
    else if (opcao == 2)
    {
        JogadorDAO dao = new JogadorDAO();

        dao.Listar();
    }
    else if (opcao == 3)
    {
        Console.Write("Digite o ID do jogador: ");
        int id = int.Parse(Console.ReadLine());

        JogadorDAO dao = new JogadorDAO();

        dao.Buscar(id);
    }
    else if (opcao == 4)
    {
        Console.Write("Digite o ID do jogador que deseja atualizar: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Novo nome: ");
        string nome = Console.ReadLine();

        Console.Write("Nova idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Nova posição: ");
        string posicao = Console.ReadLine();

        Console.Write("Novo número da camisa: ");
        int numeroCamisa = int.Parse(Console.ReadLine());

        Jogador jogador = new Jogador(
            nome,
            idade,
            posicao,
            numeroCamisa
        );

        jogador.Id = id;

        JogadorDAO dao = new JogadorDAO();

        dao.Atualizar(jogador);
    }
    else if (opcao == 5)
    {
        Console.Write("Digite o ID do jogador que deseja excluir: ");
        int id = int.Parse(Console.ReadLine());

        JogadorDAO dao = new JogadorDAO();

        dao.Excluir(id);
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
    Console.Write("Quer continuar? (S/N): ");
    string continuar = Console.ReadLine();

    if (continuar.ToLower() == "n")
    {
        Console.WriteLine("Saindo...");
        break;
    }
}