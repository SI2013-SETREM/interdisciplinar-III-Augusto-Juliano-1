using Newtonsoft.Json;
using SotosWoodwork.Repository;
using SotosWoodwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SotosWoodwork.Controllers
{
    public class ProdutoMateriaisController : Controller
    {
        public ActionResult ProdutoMateriaisList()
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
                    Sts_produtomateriais sts_produtomateriais = (Sts_produtomateriais)repository.GetById(typeof(Sts_produtomateriais), id);
                    repository.Delete(sts_produtomateriais);

                    return JsonConvert.SerializeObject(sts_produtomateriais);
                }
                catch
                {
                    repository.RollbackTransaction();

                    return "Erro";
                }
            }
        }

        public string FindAllProdutoMateriais(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                IList<Sts_produtomateriais> list = repository.ToList<Sts_produtomateriais>().Where(x => x.Sts_produto.Pro_codigo == id).ToList();
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
                    Sts_produtomateriais sts_produtomateriais = JsonConvert.DeserializeObject<Sts_produtomateriais>(json);
                    repository.Save(sts_produtomateriais);

                    return JsonConvert.SerializeObject(sts_produtomateriais);
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