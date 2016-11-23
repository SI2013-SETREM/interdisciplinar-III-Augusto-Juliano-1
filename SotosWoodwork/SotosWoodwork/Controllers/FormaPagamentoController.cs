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
    public class FormaPagamentoController : Controller
    {
        public ActionResult FormaPagamentoList()
        {
            return View();
        }

        public ActionResult FormaPagamentoForm()
        {
            return View();
        }

        [HttpGet]
        public string FindAll()
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                IList<Sts_formapagamento> listSts_formapagamento = repository.ToList<Sts_formapagamento>();
                return JsonConvert.SerializeObject(listSts_formapagamento);
            }
        }

        [HttpGet]
        public string GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            { 
                Sts_formapagamento sts_formapagamento = (Sts_formapagamento)repository.GetById(typeof(Sts_formapagamento), id);
                return JsonConvert.SerializeObject(sts_formapagamento);
            }
        }

        public string Save(string json)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    Sts_formapagamento sts_formapagamento = JsonConvert.DeserializeObject<Sts_formapagamento>(json);
                    repository.Save(sts_formapagamento);

                    return JsonConvert.SerializeObject(sts_formapagamento);
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
                    Sts_formapagamento sts_formapagamento = (Sts_formapagamento)repository.GetById(typeof(Sts_formapagamento), id);
                    repository.Delete(sts_formapagamento);

                    return JsonConvert.SerializeObject(sts_formapagamento);
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