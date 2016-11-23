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
    public class OrdemProducaoController : Controller
    {
        public ActionResult OrdemProducaoList()
        {
            return View();
        }

        public ActionResult OrdemProducaoForm()
        {
            return View();
        }


        [HttpGet]
        public string FindAll()
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                IList<Sts_ordemproducao> listOrc_ordemproducao = repository.ToList<Sts_ordemproducao>();
                return JsonConvert.SerializeObject(listOrc_ordemproducao);
            }
        }

        [HttpGet]
        public string GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                Sts_ordemproducao sts_ordemproducao = (Sts_ordemproducao)repository.GetById(typeof(Sts_ordemproducao), id);
                return JsonConvert.SerializeObject(sts_ordemproducao);
            }
        }

        public string Save(string json)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    Sts_ordemproducao sts_ordemproducao = JsonConvert.DeserializeObject<Sts_ordemproducao>(json);
                    if (sts_ordemproducao.Ord_codigo == 0)
                    {
                        sts_ordemproducao.Ord_datacadastro = DateTime.Now;
                        sts_ordemproducao.Ord_situacao = "E";
                    }
                    repository.Save(sts_ordemproducao);

                    return JsonConvert.SerializeObject(sts_ordemproducao);
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
                    Sts_ordemproducao sts_ordemproducao = (Sts_ordemproducao)repository.GetById(typeof(Sts_ordemproducao), id);
                    if (sts_ordemproducao.Ord_situacao == "E")
                    {
                        sts_ordemproducao.Ord_situacao = "C";
                        repository.Save(sts_ordemproducao);
                    }
                    else if (sts_ordemproducao.Ord_situacao == "P")
                    {
                        return "Produzida";
                    }

                    return JsonConvert.SerializeObject(sts_ordemproducao);
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