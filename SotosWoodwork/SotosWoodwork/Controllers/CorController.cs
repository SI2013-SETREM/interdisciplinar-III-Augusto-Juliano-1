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
    public class CorController : Controller
    {
        public ActionResult CorList()
        {
            return View();
        }

        public ActionResult CorForm()
        {
            return View();
        }

        [HttpGet]
        public string FindAll()
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                IList<Sts_cor> listSts_cor = repository.ToList<Sts_cor>();
                return JsonConvert.SerializeObject(listSts_cor);
            }
        }

        [HttpGet]
        public string GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                Sts_cor sts_cor = (Sts_cor)repository.GetById(typeof(Sts_cor), id);
                return JsonConvert.SerializeObject(sts_cor);
            }
        }

        public string Delete(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    Sts_cor sts_cor = (Sts_cor)repository.GetById(typeof(Sts_cor), id);
                    repository.Delete(sts_cor);

                    return JsonConvert.SerializeObject(sts_cor);
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
                    Sts_cor sts_cor = JsonConvert.DeserializeObject<Sts_cor>(json);
                    repository.Save(sts_cor);

                    return JsonConvert.SerializeObject(sts_cor);
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