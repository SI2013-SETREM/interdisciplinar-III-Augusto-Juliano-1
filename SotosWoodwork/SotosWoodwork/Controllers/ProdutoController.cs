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
    public class ProdutoController : Controller
    {
        public ActionResult MateriaPrimaList()
        {
            return View();
        }

        public ActionResult MateriaPrimaForm()
        {
            return View();
        }

        [HttpGet]
        public string FindAllMateriaPrima()
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                IList<Sts_produto> listSts_produto = repository.ToList<Sts_produto>();
                return JsonConvert.SerializeObject(listSts_produto);
            }
        }

        [HttpGet]
        public string GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                Sts_produto Sts_produto = (Sts_produto)repository.GetById(typeof(Sts_produto), id);
                return JsonConvert.SerializeObject(Sts_produto);
            }
        }

        public string Delete(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    Sts_produto sts_produto = (Sts_produto)repository.GetById(typeof(Sts_produto), id);
                    repository.Delete(sts_produto);

                    return JsonConvert.SerializeObject(sts_produto);
                }
                catch
                {
                    repository.RollbackTransaction();

                    return "Erro";
                }
            }
        }

        public string SaveMateriaPrima(string json)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    Sts_produto sts_produto = JsonConvert.DeserializeObject<Sts_produto>(json);
                    if (sts_produto.Pro_codigo == 0)
                        sts_produto.Pro_datacadastro = DateTime.Now;
                    sts_produto.Pro_tipo = "M";
                    repository.Save(sts_produto);

                    return JsonConvert.SerializeObject(sts_produto);
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