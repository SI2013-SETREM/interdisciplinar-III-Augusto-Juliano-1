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
    public class UnidadeMedidaController : Controller
    {
        public ActionResult UnidadeMedidaList()
        {
            return View();
        }

        public ActionResult UnidadeMedidaForm()
        {
            return View();
        }


        [HttpGet]
        public string FindAll()
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                IList<Sts_unidademedida> listUnidadeMedida = repository.ToList<Sts_unidademedida>();
                return JsonConvert.SerializeObject(listUnidadeMedida);
            }
        }

        [HttpGet]
        public string GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                Sts_unidademedida sts_unidademedida = (Sts_unidademedida)repository.GetById(typeof(Sts_unidademedida), id);
                return JsonConvert.SerializeObject(sts_unidademedida);
            }
        }

        public string Save(string json)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    Sts_unidademedida sts_unidademedida = JsonConvert.DeserializeObject<Sts_unidademedida>(json);
                    repository.Save(sts_unidademedida);

                    return JsonConvert.SerializeObject(sts_unidademedida);
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
                    Sts_unidademedida sts_unidademedida = (Sts_unidademedida)repository.GetById(typeof(Sts_unidademedida), id);
                    repository.Delete(sts_unidademedida);

                    return JsonConvert.SerializeObject(sts_unidademedida);
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