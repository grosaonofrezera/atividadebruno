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
}