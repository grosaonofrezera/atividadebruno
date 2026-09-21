 ////////Sistema de Jogadores//////////

 ////////Integrantes////////

Caio Adada
Gabriel Rosa
Vicente Mezaroba

///////Sobre o projeto////////

Esse projeto é um sistema de jogadores de futebol feito em C#.

Ele funciona pelo terminal e serve para cadastrar e organizar jogadores. No sistema é possível cadastrar, listar, buscar, atualizar e excluir jogadores.

Cada jogador tem:

 Nome
 Idade
 Posição
 Número da camisa

////////Banco de dados/////////

Foi usado o MySQL para guardar os jogadores.

O banco se chama sistema_jogadores e dentro dele existe a tabela jogadores.

O arquivo BANCO.SQL cria o banco e a tabela.

////////Biblioteca usada////////////

Para o C# conseguir conversar com o MySQL, foi usada a biblioteca MySql.Data.

Ela permite fazer a conexão com o banco e executar os comandos SQL.

///////como instalar////////

Para instalar a biblioteca, abra o terminal na pasta do projeto e coloque:

dotnet add package MySql.Data

///////////Como configurar o banco/////////////

Primeiro, é preciso ter o MySQL instalado.

Depois, é só abrir o arquivo BANCO.SQL no MySQL e executar o código. Ele vai criar o banco sistema_jogadores e a tabela jogadores.

Também é necessário deixar a conexão com o MySQL configurada no projeto com o usuário e a senha usados no computador.

///////Como executar/////////

Depois de configurar o banco e instalar a biblioteca, abra o terminal na pasta do projeto e execute:

dotnet run

Depois disso, o sistema vai aparecer no terminal.

//////////como o sistema funciona////////////

Quando o programa começa, aparece um menu com algumas opções:

1 - Cadastrar jogador
2 - Listar jogadores
3 - Buscar jogador
4 - Atualizar jogador
5 - Excluir jogador
0 - Sair

Para cadastrar um jogador, o programa pede o nome, idade, posição e número da camisa.

Depois, essas informações são enviadas para o banco de dados.

Também dá para procurar um jogador pelo ID, atualizar suas informações ou excluir ele.

/////////Conexão com o banco////////////

A conexão é feita usando o MySqlConnection.

O C# se conecta ao banco e depois consegue mandar os comandos SQL para ele, como INSERT, SELECT, UPDATE e DELETE.

Na busca de um jogador, por exemplo, o sistema usa um SELECT para procurar o jogador pelo ID. O MySqlDataReader pega as informações que o banco encontrou e o programa mostra elas no terminal.

Os comandos usam parâmetros, como @id, para passar os valores para o SQL de uma forma mais segura.
