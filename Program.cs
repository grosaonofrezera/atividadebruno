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

    int opcao;

    while (true)
    {
        Console.Write("Escolha uma opção: ");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out opcao) && opcao >= 0 && opcao <= 5)
        {
            break;
        }

        Console.WriteLine("Opção inválida!");
    }

    if (opcao == 1)
    {
        string nome;

        while (true)
        {
            Console.Write("Nome: ");
            nome = Console.ReadLine();

            bool valido = true;

            if (nome == "")
            {
                valido = false;
            }

            for (int i = 0; i < nome.Length; i++)
            {
                if (!char.IsLetter(nome[i]))
                {
                    valido = false;
                }
            }

            if (valido)
            {
                break;
            }

            Console.WriteLine("O nome deve conter somente letras e não pode ter espaços!");
        }

        int idade;

        while (true)
        {
            Console.Write("Idade: ");
            string entrada = Console.ReadLine();

            if (!entrada.Contains(" ") &&
                int.TryParse(entrada, out idade) &&
                idade > 0)
            {
                break;
            }

            Console.WriteLine("A idade deve ser um número positivo e não pode conter espaços!");
        }

        string posicao;

        while (true)
        {
            Console.Write("Posição: ");
            posicao = Console.ReadLine();

            bool valido = true;

            if (posicao == "")
            {
                valido = false;
            }

            for (int i = 0; i < posicao.Length; i++)
            {
                if (!char.IsLetter(posicao[i]))
                {
                    valido = false;
                }
            }

            if (valido)
            {
                break;
            }

            Console.WriteLine("A posição deve conter somente letras e não pode ter espaços!");
        }

        int numeroCamisa;

        while (true)
        {
            Console.Write("Número da camisa: ");
            string entrada = Console.ReadLine();

            if (!entrada.Contains(" ") &&
                int.TryParse(entrada, out numeroCamisa) &&
                numeroCamisa >= 1 &&
                numeroCamisa <= 99)
            {
                break;
            }

            Console.WriteLine("O número da camisa deve ter de 1 a 99 e não pode conter espaços!");
        }

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
        int id;

        while (true)
        {
            Console.Write("Digite o ID do jogador: ");
            string entrada = Console.ReadLine();

            if (!entrada.Contains(" ") &&
                int.TryParse(entrada, out id) &&
                id > 0)
            {
                break;
            }

            Console.WriteLine("O ID deve ser um número positivo e não pode conter espaços!");
        }

        JogadorDAO dao = new JogadorDAO();

        dao.Buscar(id);
    }

    else if (opcao == 4)
    {
        int id;

        while (true)
        {
            Console.Write("Digite o ID do jogador que deseja atualizar: ");
            string entrada = Console.ReadLine();

            if (!entrada.Contains(" ") &&
                int.TryParse(entrada, out id) &&
                id > 0)
            {
                break;
            }

            Console.WriteLine("O ID deve ser um número positivo e não pode conter espaços!");
        }

        string nome;

        while (true)
        {
            Console.Write("Novo nome: ");
            nome = Console.ReadLine();

            bool valido = true;

            if (nome == "")
            {
                valido = false;
            }

            for (int i = 0; i < nome.Length; i++)
            {
                if (!char.IsLetter(nome[i]))
                {
                    valido = false;
                }
            }

            if (valido)
            {
                break;
            }

            Console.WriteLine("O nome deve conter somente letras e não pode ter espaços!");
        }

        int idade;

        while (true)
        {
            Console.Write("Nova idade: ");
            string entrada = Console.ReadLine();

            if (!entrada.Contains(" ") &&
                int.TryParse(entrada, out idade) &&
                idade > 0)
            {
                break;
            }

            Console.WriteLine("A idade deve ser um número positivo e não pode conter espaços!");
        }

        string posicao;

        while (true)
        {
            Console.Write("Nova posição: ");
            posicao = Console.ReadLine();

            bool valido = true;

            if (posicao == "")
            {
                valido = false;
            }

            for (int i = 0; i < posicao.Length; i++)
            {
                if (!char.IsLetter(posicao[i]))
                {
                    valido = false;
                }
            }

            if (valido)
            {
                break;
            }

            Console.WriteLine("A posição deve conter somente letras e não pode ter espaços!");
        }

        int numeroCamisa;

        while (true)
        {
            Console.Write("Novo número da camisa: ");
            string entrada = Console.ReadLine();

            if (!entrada.Contains(" ") &&
                int.TryParse(entrada, out numeroCamisa) &&
                numeroCamisa >= 1 &&
                numeroCamisa <= 99)
            {
                break;
            }

            Console.WriteLine("O número da camisa deve ter de 1 a 99 e não pode conter espaços!");
        }

        Jogador jogador = new Jogador(
            nome,
            idade,
            posicao,
            numeroCamisa
        );

        jogador.Id = id;

        JogadorDAO dao = new JogadorDAO();

        bool atualizado = dao.Atualizar(jogador);

        if (atualizado)
        {
            Console.WriteLine("Jogador atualizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Jogador não encontrado!");
        }
    }

    else if (opcao == 5)
    {
        int id;

        while (true)
        {
            Console.Write("Digite o ID do jogador que deseja excluir: ");
            string entrada = Console.ReadLine();

            if (!entrada.Contains(" ") &&
                int.TryParse(entrada, out id) &&
                id > 0)
            {
                break;
            }

            Console.WriteLine("O ID deve ser um número positivo e não pode conter espaços!");
        }

        JogadorDAO dao = new JogadorDAO();

        bool excluido = dao.Excluir(id);

        if (excluido)
        {
            Console.WriteLine("Jogador excluído com sucesso!");
        }
        else
        {
            Console.WriteLine("Jogador não encontrado!");
        }
    }

    else if (opcao == 0)
    {
        Console.WriteLine("Saindo...");
        break;
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


