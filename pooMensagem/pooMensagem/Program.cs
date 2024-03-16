namespace pooMensagem
{
    class Program
    {
        static void Main()
        {
            Mensagem mensagem1 = new Mensagem();
            //Mensagem mensagem2 = new Mensagem();

            //mensagem1.SetTextoMensagem("Alo, Mundo 2!");
            //Console.WriteLine(mensagem1.GetTextoMensagem());
            //mensagem1.ExibirMensagem();

            //mensagem2.textoMensagem = "Teste pro miguel ver";
            //mensagem2.ExibirMensagem();
            mensagem1.TextoMensagem = "Alo, Mundo";
            mensagem1.ExibirMensagem();
            
            Console.ReadKey();
        }
    }
}
