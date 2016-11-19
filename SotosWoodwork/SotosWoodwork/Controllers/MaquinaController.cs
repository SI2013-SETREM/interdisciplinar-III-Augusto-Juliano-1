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
    public class MaquinaController : Controller
    {
        public ActionResult MaquinaList()
        {
            return View();
        }

        public ActionResult MaquinaForm()
        {
            return View();
        }


        [HttpGet]
        public string FindAll()
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                IList<Sts_maquina> listSts_maquina = repository.ToList<Sts_maquina>();
                return JsonConvert.SerializeObject(listSts_maquina);
            }
        }

        [HttpGet]
        public string GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                Sts_maquina sts_maquina = (Sts_maquina)repository.GetById(typeof(Sts_maquina), id);
                return JsonConvert.SerializeObject(sts_maquina);
            }
        }

        public string Save(string json)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    Sts_maquina sts_maquina = JsonConvert.DeserializeObject<Sts_maquina>(json);
                    repository.Save(sts_maquina);

                    return JsonConvert.SerializeObject(sts_maquina);
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
                    Sts_maquina sts_maquina = (Sts_maquina)repository.GetById(typeof(Sts_maquina), id);
                    repository.Delete(sts_maquina);

                    return JsonConvert.SerializeObject(sts_maquina);
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