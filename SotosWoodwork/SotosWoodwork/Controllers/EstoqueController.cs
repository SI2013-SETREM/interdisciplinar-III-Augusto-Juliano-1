using Newtonsoft.Json;
using SotosWoodwork.Models;
using SotosWoodwork.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SotosWoodwork.Controllers
{
    public class EstoqueController : Controller
    {
        public ActionResult EstoqueList()
        {
            return View();
        }

        [HttpGet]
        public string FindAll()
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                IList<Sts_estoque> listSts_estoque = repository.ToList<Sts_estoque>();
                return JsonConvert.SerializeObject(listSts_estoque);
            }
        }

        [HttpGet]
        public string FindByProduto(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                Sts_produto sts_produto = (Sts_produto)repository.GetById(typeof(Sts_produto), id);
                IList<Sts_estoque> listSts_estoque = repository.ToList<Sts_estoque>().Where(x => x.Sts_produto.Pro_codigo == sts_produto.Pro_codigo).ToList();
                return JsonConvert.SerializeObject(listSts_estoque);
            }
        }
    }
}