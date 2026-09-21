public class Jogador
{
    public int Id { get; set; }

    private string nome = "";
    private int idade;
    private string posicao = "";
    private int numeroCamisa;

    public string Nome
    {
        get { return nome; }
        set
        {
            if (value == "")
            {
                Console.WriteLine("O nome não pode ser vazio!");
            }
            else
            {
                bool valido = true;

                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]))
                    {
                        valido = false;
                    }
                }

                if (valido)
                {
                    nome = value;
                }
                else
                {
                    Console.WriteLine("O nome deve conter somente letras!");
                }
            }
        }
    }

    public int Idade
    {
        get { return idade; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("A idade deve ser positiva!");
            }
            else
            {
                idade = value;
            }
        }
    }

    public string Posicao
    {
        get { return posicao; }
        set
        {
            if (value == "")
            {
                Console.WriteLine("A posição não pode ser vazia!");
            }
            else
            {
                bool valido = true;

                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]))
                    {
                        valido = false;
                    }
                }

                if (valido)
                {
                    posicao = value;
                }
                else
                {
                    Console.WriteLine("A posição deve conter somente letras!");
                }
            }
        }
    }

    public int NumeroCamisa
    {
        get { return numeroCamisa; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("O número da camisa deve ser positivo!");
            }
            else
            {
                string numero = value.ToString();
                bool valido = true;

                for (int i = 0; i < numero.Length; i++)
                {
                    if (!char.IsDigit(numero[i]))
                    {
                        valido = false;
                    }
                }

                if (valido)
                {
                    numeroCamisa = value;
                }
                else
                {
                    Console.WriteLine("O número da camisa deve conter somente dígitos!");
                }
            }
        }
    }

    public Jogador(string nome, int idade, string posicao, int numeroCamisa)
    {
        Nome = nome;
        Idade = idade;
        Posicao = posicao;
        NumeroCamisa = numeroCamisa;
    }

    public override string ToString()
    {
        return $"ID: {Id} | Jogador: {Nome} | Idade: {Idade} | Posição: {Posicao} | Camisa: {NumeroCamisa}";
    }

    public void Aniversario()
    {
        idade++;
    }
}