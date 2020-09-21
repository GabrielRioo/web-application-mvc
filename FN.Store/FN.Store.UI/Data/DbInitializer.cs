using FN.Store.UI.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace FN.Store.UI.Data
{
	internal class DbInitializer : CreateDatabaseIfNotExists<FNStoreDataContext>
	{
		protected override void Seed(FNStoreDataContext context)
		{
			var produtos = new List<Produto>() {
			new Produto() { Nome = "Carne", Preco = 70.5M, Qtde = 150, Tipo = "Alimento" },
			new Produto() { Nome = "Pasta de Dente", Preco = 9.5M, Qtde = 30, Tipo = "Higiene" },
			new Produto() { Nome = "Desinfetante", Preco = 8.99M, Qtde = 90, Tipo = "Limpeza" },
			new Produto() { Nome = "Celular", Preco = 899.99M, Qtde = 52, Tipo = "Eletronico" }

			};
			context.Produtos.AddRange(produtos);
			context.SaveChanges();
		}
	}
}