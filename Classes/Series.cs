using System;
namespace DIO.Series
{
    public class Series : EntidadeBase
    {
        private Genero Genero {get; set;}
        private string Nome {get; set;}
        private string Descricao {get; set;}
        private int Ano {get; set;}
        private bool Excluido{get; set;}

        public Series(int id,Genero genero, string nome, string descricao, int ano)
        {
            
            ID = id;
            Genero = genero;
            Nome = nome;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }
         public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Nome + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}
        public string retornaTitulo()
		{
			return this.Nome;
		}

		public int retornaId()
		{
			return this.ID;
		}

        public void Excluir()
        {
            this.Excluido = true;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }
    }
}