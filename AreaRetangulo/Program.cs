namespace AreaRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Calculo da area de um retangulo ou quadrado");
            Console.Write("Informe a base: ");
            retangulo.Base = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a altura: ");
            retangulo.Altura = Convert.ToDouble(Console.ReadLine());

            retangulo.ExibirDados();
            Console.ReadKey();
        }
    }
}
