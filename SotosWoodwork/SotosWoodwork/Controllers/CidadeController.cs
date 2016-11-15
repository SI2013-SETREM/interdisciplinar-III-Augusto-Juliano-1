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
    public class CidadeController : Controller
    {
        public ActionResult CidadeList()
        {
            return View();
        }

        public ActionResult CidadeForm()
        {
            return View();
        }

        [HttpGet]
        public string FindAll()
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                IList<Sts_cidade> listSts_cidade = repository.ToList<Sts_cidade>();
                return JsonConvert.SerializeObject(listSts_cidade);
            }
        }

        [HttpGet]
        public string GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                Sts_cidade Sts_cidade = (Sts_cidade)repository.GetById(typeof(Sts_cidade), id);
                return JsonConvert.SerializeObject(Sts_cidade);
            }
        }

        public string Delete(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    Sts_cidade Sts_cidade = (Sts_cidade)repository.GetById(typeof(Sts_cidade), id);
                    repository.Delete(Sts_cidade);

                    return JsonConvert.SerializeObject(Sts_cidade);
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
                    Sts_cidade Sts_cidade = JsonConvert.DeserializeObject<Sts_cidade>(json);
                    repository.Save(Sts_cidade);

                    return JsonConvert.SerializeObject(Sts_cidade);
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