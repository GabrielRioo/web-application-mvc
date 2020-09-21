using FN.Store.UI.Data;
using FN.Store.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FN.Store.UI.Controllers
{
    public class ProdutosController : Controller
    {
        public ViewResult Index()
        {
            var ctx = new FNStoreDataContext();
            var produtos = ctx.Produtos.ToList();


            return View(produtos);
        }
    }
}
