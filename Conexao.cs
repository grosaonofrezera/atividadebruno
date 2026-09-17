using MySql.Data.MySqlClient;

public class Conexao
{
    private string connectionString =
        "Server=localhost;Database=sistema_jogadores;User=root;Password=Senac2026;";

    public MySqlConnection Conectar()
    {
        MySqlConnection conexao = new MySqlConnection(connectionString);
        conexao.Open();

        return conexao;
    }
}