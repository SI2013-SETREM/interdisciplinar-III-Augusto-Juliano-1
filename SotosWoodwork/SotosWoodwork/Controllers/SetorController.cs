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
    public class SetorController : Controller
    {
        public ActionResult SetorList()
        {
            return View();
        }

        public ActionResult SetorForm()
        {
            return View();
        }

        [HttpGet]
        public string FindAll()
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                IList<Sts_setor> listSts_setor = repository.ToList<Sts_setor>();
                return JsonConvert.SerializeObject(listSts_setor);
            }
        }

        [HttpGet]
        public string GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                Sts_setor sts_setor = (Sts_setor)repository.GetById(typeof(Sts_setor), id);
                return JsonConvert.SerializeObject(sts_setor);
            }
        }

        public string Save(string json)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    Sts_setor sts_setor = JsonConvert.DeserializeObject<Sts_setor>(json);
                    repository.Save(sts_setor);

                    return JsonConvert.SerializeObject(sts_setor);
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
                    Sts_setor sts_setor = (Sts_setor)repository.GetById(typeof(Sts_setor), id);
                    repository.Delete(sts_setor);

                    return JsonConvert.SerializeObject(sts_setor);
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