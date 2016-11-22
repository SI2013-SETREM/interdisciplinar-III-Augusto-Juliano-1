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
    public class OrcamentoProdutosController : Controller
    {
        public ActionResult OrcamentoProdutosList()
        {
            return View();
        }

        public ActionResult OrcamentoProdutosForm()
        {
            return View();
        }


        [HttpGet]
        public string FindAllProductsOrder(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                IList<Sts_orcamentoprodutos> list = repository.ToList<Sts_orcamentoprodutos>()
                    .Where(x => x.Sts_orcamento.Orc_codigo == id).ToList();
                return JsonConvert.SerializeObject(list);
            }
        }

        [HttpGet]
        public string GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                Sts_orcamentoprodutos sts_orcamentoprodutos = (Sts_orcamentoprodutos)repository.GetById(typeof(Sts_orcamentoprodutos), id);
                return JsonConvert.SerializeObject(sts_orcamentoprodutos);
            }
        }

        public string Save(string json)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    Sts_orcamentoprodutos sts_orcamentoprodutos = JsonConvert.DeserializeObject<Sts_orcamentoprodutos>(json);
                    repository.Save(sts_orcamentoprodutos);

                    return JsonConvert.SerializeObject(sts_orcamentoprodutos);
                }
                catch
                {
                    repository.RollbackTransaction();

                    return "Erro";
                }
            }
        }

        public string Delete(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    Sts_orcamentoprodutos sts_orcamentoprodutos = (Sts_orcamentoprodutos)repository.GetById(typeof(Sts_orcamentoprodutos), id);
                    repository.Delete(sts_orcamentoprodutos);

                    return JsonConvert.SerializeObject(sts_orcamentoprodutos);
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