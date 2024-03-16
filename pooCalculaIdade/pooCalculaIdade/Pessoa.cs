using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
    public class Pessoa
    {
		private int anoNascimento;

		public int AnoNascimento
		{
			get { return anoNascimento; }
			set { anoNascimento = value; }
		}

		private string nome;

		public string Nome
		{
			get { return nome; }
			set { nome = value.ToUpper(); }
		}

		private int idade;

		public int Idade
		{
			get 
			{
				CalcularIdade();
				return idade; 
			}
		}


		public void ExibirDados()
		{
			Console.WriteLine($"Nome: {Nome}");
			Console.WriteLine($"Ano de nascimento: {AnoNascimento}");
			//CalcularIdade();
			Console.WriteLine($"Idade: {Idade}");
		}

		private void CalcularIdade()
		{
			DateTime data = DateTime.Now;
			int ano = data.Year;

			this.idade = ano - this.AnoNascimento;
		}

	}
}
