using FN.Store.UI.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace FN.Store.UI.Data
{
	internal class DbInitializer : CreateDatabaseIfNotExists <FNStoreDataContext>
	{
		protected override void Seed(FNStoreDataContext context)
		{

			var produtos = new List<Produto>() {
				new Produto() { Nome = "Carne", Preco = 70.5M, Qtde = 150, Tipo="Alimento" },
				new Produto() { Nome = "Celular", Preco = 899.5M, Qtde = 250, Tipo="Eletronico" },
				new Produto() { Nome = "Desinfetante", Preco = 30.5M, Qtde = 90, Tipo="Limpeza" },
				new Produto() { Nome = "Pasta de Dentes", Preco = 15.5M, Qtde = 50, Tipo="Higiene" },
			};

			context.Produtos.AddRange(produtos);
			context.SaveChanges();
		}
	}
}