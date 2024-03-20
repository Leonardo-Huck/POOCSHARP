namespace pooMaiorIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] pessoas = new Pessoa[3];

            for(int i = 0; i < pessoas.Length; i++)
            {
                pessoas[i] = new Pessoa();

                Console.Write($"Informe o nome da {i+1} pessoa: ");
                pessoas[i].Nome = Console.ReadLine();

                Console.Write($"Informe a idade da {i+1} pessoa: ");
                pessoas[i].Idade = Convert.ToInt32(Console.ReadLine());
            }

            Pessoa maisVelha = new Pessoa();

            foreach (Pessoa pessoa in pessoas)
            {
                if (pessoa.Idade > maisVelha.Idade)
                {
                    maisVelha.Nome = pessoa.Nome;
                    maisVelha.Idade = pessoa.Idade;
                }
            }
            maisVelha.ExibirDados();
        }
    }
}
