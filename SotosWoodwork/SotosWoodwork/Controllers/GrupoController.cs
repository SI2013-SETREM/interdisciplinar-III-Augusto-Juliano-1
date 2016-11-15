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
    public class GrupoController : Controller
    {
        public ActionResult GrupoList()
        {
            return View();
        }

        public ActionResult GrupoForm()
        {
            return View();
        }

        [HttpGet]
        public string FindAll()
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                IList<Sts_grupo> listSts_grupo = repository.ToList<Sts_grupo>();
                return JsonConvert.SerializeObject(listSts_grupo);
            }
        }

        [HttpGet]
        public string GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                Sts_grupo Sts_grupo = (Sts_grupo)repository.GetById(typeof(Sts_grupo), id);
                return JsonConvert.SerializeObject(Sts_grupo);
            }
        }

        public string Delete(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    Sts_grupo Sts_grupo = (Sts_grupo)repository.GetById(typeof(Sts_grupo), id);
                    repository.Delete(Sts_grupo);

                    return JsonConvert.SerializeObject(Sts_grupo);
                }
                catch
                {
                    repository.RollbackTransaction();

                    return "Erro";
                }
            }
        }

        public string Save(string json)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    Sts_grupo Sts_grupo = JsonConvert.DeserializeObject<Sts_grupo>(json);
                    repository.Save(Sts_grupo);

                    return JsonConvert.SerializeObject(Sts_grupo);
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