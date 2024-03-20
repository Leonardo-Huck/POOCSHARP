using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRetangulo
{
    public class Retangulo
    {
        private string tipoObjeto = "Retangulo";
        public double Base { get; set; }
        public double Altura { get; set; }

        public void ExibirDados()
        {
            if(Base == Altura)
            {
                this.tipoObjeto = "Quadrado";
            }
            Console.WriteLine($"A base do {tipoObjeto} é de: {Base}");
            Console.WriteLine($"A altura do {tipoObjeto} é de: {Altura}");
            Console.WriteLine($"A Área do {tipoObjeto} é de: {Base*Altura}");
        }
            
    }
}
