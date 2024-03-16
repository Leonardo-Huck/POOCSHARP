using ControleDeAnimais;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Controle de Animais");
        Console.WriteLine("-------------------");

        Animal[] animals = new Animal[5];

        for (int i = 0; i < animals.Length; i++)
            animals[i] = new Animal();

        int totalCachorro = 0, totalGato = 0, totalPeixe = 0;

        for (int i = 0; i < animals.Length; i++)
        {
            Console.WriteLine($"Informe o nome do {i + 1}º animal: ");
            animals[i].Nome = Console.ReadLine();
            Console.WriteLine($"Informe o tipo do {i + 1}º animal (Cachorro, Gato ou Peixe): ");
            animals[i].Tipo = Console.ReadLine();

            if (animals[i].Tipo == "Cachorro") totalCachorro++;
            if (animals[i].Tipo == "Gato") totalGato++;
            if (animals[i].Tipo == "Peixe") totalPeixe++;
            Console.Clear();
        }

        Console.WriteLine("Total de Animais:");
        Console.WriteLine($"Cachorros: {totalCachorro}\nGatos: {totalGato}\nPeixes: {totalPeixe}");

        Console.WriteLine("\nAnimais Cadastrados:");
        foreach (Animal animal in animals)
        {
            Console.WriteLine($"{animal.Nome}");
            Console.WriteLine($"{animal.Tipo}\n");
        }
    }
}