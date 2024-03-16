using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    public class Mensagem
    {
        //private string textoMensagem;
        //public void ExibirMensagem()
        //{
        //    Console.WriteLine(this.textoMensagem);
        //}

        //public string GetTextoMensagem()
        //{ 
        //    return textoMensagem; 
        //}

        //public void SetTextoMensagem(string valor)
        //{
        //    textoMensagem = valor.ToUpper();
        //}

        private string textoMensagem;

        public string TextoMensagem
        {
            get { return textoMensagem; }  set { this.textoMensagem = value.ToUpper(); } 
        }

        public void ExibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem);
        }
}
}
