using Newtonsoft.Json;
using Pechkin;
using Pechkin.Synchronized;
using SotosWoodwork.Models;
using SotosWoodwork.Repository;
using SotosWoodwork.Utils;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SotosWoodwork.Controllers
{
    public class OrcamentoController : Controller
    {
        public ActionResult OrcamentoList()
        {
            return View();
        }

        public ActionResult OrcamentoForm()
        {
            return View();
        }

        public ActionResult OrcamentoHtml(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                Sts_orcamento sts_orcamento = (Sts_orcamento)repository.GetById(typeof(Sts_orcamento), id);
                return View(sts_orcamento);
            }
            
        }

        public FileContentResult OrcamentoPdf(int id)
        {
            
            return new HtmlToPdf().Execute(Request, "#/Orcamento", "Orcamento");
        }


        [HttpGet]
        public string FindAll()
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                IList<Sts_orcamento> listSts_orcamento = repository.ToList<Sts_orcamento>();
                return JsonConvert.SerializeObject(listSts_orcamento);
            }
        }

        [HttpGet]
        public string GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                Sts_orcamento sts_orcamento = (Sts_orcamento)repository.GetById(typeof(Sts_orcamento), id);
                return JsonConvert.SerializeObject(sts_orcamento);
            }
        }

        public string Save(string json)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    Sts_orcamento sts_orcamento = JsonConvert.DeserializeObject<Sts_orcamento>(json);
                    repository.Save(sts_orcamento);

                    return JsonConvert.SerializeObject(sts_orcamento);
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
                    Sts_orcamento sts_orcamento = (Sts_orcamento)repository.GetById(typeof(Sts_orcamento), id);
                    repository.Delete(sts_orcamento);

                    return JsonConvert.SerializeObject(sts_orcamento);
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