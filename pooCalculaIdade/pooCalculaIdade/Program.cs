using pooCalculaIdade;

Console.WriteLine("Programa para Calcular a idade");

Pessoa pessoa = new Pessoa();

Console.WriteLine("Digite o seu nome: ");
pessoa.Nome = Console.ReadLine();

Console.WriteLine("Digite o ano de nascimento: ");
pessoa.AnoNascimento = int.Parse(Console.ReadLine());
pessoa.ExibirDados();