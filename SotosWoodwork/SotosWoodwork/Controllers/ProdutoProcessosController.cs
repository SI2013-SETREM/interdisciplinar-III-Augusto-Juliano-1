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
    public class ProdutoProcessosController : Controller
    {
        public ActionResult ProdutoProcessosList()
        {
            return View();
        }

        public string Delete(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    Sts_produtoprocessos sts_produtoprocessos = (Sts_produtoprocessos)repository.GetById(typeof(Sts_produtoprocessos), id);
                    repository.Delete(sts_produtoprocessos);

                    return JsonConvert.SerializeObject(sts_produtoprocessos);
                }
                catch
                {
                    repository.RollbackTransaction();

                    return "Erro";
                }
            }
        }

        public string FindAllProdutoProcessos(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                IList<Sts_produtoprocessos> list = repository.ToList<Sts_produtoprocessos>().Where(x => x.Sts_produto.Pro_codigo == id).ToList();
                return JsonConvert.SerializeObject(list);
            }
        }

        [HttpGet]
        public string GetProduto(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                Sts_produto sts_produto = (Sts_produto)repository.GetById(typeof(Sts_produto), id);
                return JsonConvert.SerializeObject(sts_produto);
            }
        }


        public string Save(string json)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    Sts_produtoprocessos sts_produtoprocessos = JsonConvert.DeserializeObject<Sts_produtoprocessos>(json);
                    repository.Save(sts_produtoprocessos);

                    return JsonConvert.SerializeObject(sts_produtoprocessos);
                }
                catch
                {
                    repository.RollbackTransaction();

                    return "Erro";
                }
            }
        }
    }
}