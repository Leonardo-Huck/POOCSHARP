using pooCalculaIdade;

Console.WriteLine("Programa para Calcular a idade");

Console.Write("Digite o seu nome: ");
string nome = Console.ReadLine();

Console.Write("Digite o ano de nascimento: ");
int anoNascimento = int.Parse(Console.ReadLine());

Pessoa pessoa = new Pessoa(nome, anoNascimento);
Console.WriteLine();
pessoa.ExibirDados();