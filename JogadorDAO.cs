using MySql.Data.MySqlClient;

public class JogadorDAO
{
    private Conexao conexao = new Conexao();

    public void Inserir(Jogador jogador)
    {
        using (MySqlConnection conn = conexao.Conectar())
        {
            string sql = @"INSERT INTO jogadores
                           (nome, idade, posicao, numero_camisa)
                           VALUES
                           (@nome, @idade, @posicao, @numeroCamisa)";

            MySqlCommand comando = new MySqlCommand(sql, conn);

            comando.Parameters.AddWithValue("@nome", jogador.Nome);
            comando.Parameters.AddWithValue("@idade", jogador.Idade);
            comando.Parameters.AddWithValue("@posicao", jogador.Posicao);
            comando.Parameters.AddWithValue("@numeroCamisa", jogador.NumeroCamisa);

            comando.ExecuteNonQuery();
        }
    }

        public void Listar()
    {
        using (MySqlConnection conn = conexao.Conectar())
        {
            string sql = "SELECT * FROM jogadores";

            MySqlCommand comando = new MySqlCommand(sql, conn);

            MySqlDataReader leitor = comando.ExecuteReader();

            while (leitor.Read())
            {
                Console.WriteLine(
                    $"ID: {leitor["id"]} | " +
                    $"Nome: {leitor["nome"]} | " +
                    $"Idade: {leitor["idade"]} | " +
                    $"Posição: {leitor["posicao"]} | " +
                    $"Camisa: {leitor["numero_camisa"]}"
                );
            }
        }
    }
        public void Atualizar(Jogador jogador)
    {
        using (MySqlConnection conn = conexao.Conectar())
        {
            string sql = @"UPDATE jogadores
                        SET nome = @nome,
                            idade = @idade,
                            posicao = @posicao,
                            numero_camisa = @numeroCamisa
                        WHERE id = @id";

            MySqlCommand comando = new MySqlCommand(sql, conn);

            comando.Parameters.AddWithValue("@id", jogador.Id);
            comando.Parameters.AddWithValue("@nome", jogador.Nome);
            comando.Parameters.AddWithValue("@idade", jogador.Idade);
            comando.Parameters.AddWithValue("@posicao", jogador.Posicao);
            comando.Parameters.AddWithValue("@numeroCamisa", jogador.NumeroCamisa);

            int linhasAlteradas = comando.ExecuteNonQuery();

            if (linhasAlteradas > 0)
            {
                Console.WriteLine("Jogador atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Jogador não encontrado!");
            }
        }
    }
        public void Excluir(int id)
    {
        using (MySqlConnection conn = conexao.Conectar())
        {
            string sql = "DELETE FROM jogadores WHERE id = @id";

            MySqlCommand comando = new MySqlCommand(sql, conn);

            comando.Parameters.AddWithValue("@id", id);

            int linhasAlteradas = comando.ExecuteNonQuery();

            if (linhasAlteradas > 0)
            {
                Console.WriteLine("Jogador excluído com sucesso!");
            }
            else
            {
                Console.WriteLine("Jogador não encontrado!");
            }
        }
    }
        public void Buscar(int id)
    {
        using (MySqlConnection conn = conexao.Conectar())
        {
            string sql = "SELECT * FROM jogadores WHERE id = @id";

            MySqlCommand comando = new MySqlCommand(sql, conn);

            comando.Parameters.AddWithValue("@id", id);

            MySqlDataReader leitor = comando.ExecuteReader();

            if (leitor.Read())
            {
                Console.WriteLine();
                Console.WriteLine("Jogador encontrado!");
                Console.WriteLine($"ID: {leitor["id"]}");
                Console.WriteLine($"Nome: {leitor["nome"]}");
                Console.WriteLine($"Idade: {leitor["idade"]}");
                Console.WriteLine($"Posição: {leitor["posicao"]}");
                Console.WriteLine($"Número da camisa: {leitor["numero_camisa"]}");
            }
            else
            {
                Console.WriteLine("Jogador não encontrado!");
            }
        }
    }
}