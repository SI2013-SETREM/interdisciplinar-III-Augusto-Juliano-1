using Newtonsoft.Json;
using SotosWoodwork.Models;
using SotosWoodwork.Repository;
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

        [HttpGet]
        public string gerarOP(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    Sts_orcamento sts_orcamento = (Sts_orcamento)repository.GetById(typeof(Sts_orcamento), id);
                    IList<Sts_orcamentoprodutos> list = repository.ToList<Sts_orcamentoprodutos>().Where(x => x.Sts_orcamento.Orc_codigo == id).ToList();
                    if (sts_orcamento.Orc_situacao == "E" && list.Count > 0)
                    {       
                        Sts_ordemproducao sts_ordemproducao = new Sts_ordemproducao();
                        sts_ordemproducao.Ord_codigo = 0;
                        sts_ordemproducao.Ord_datacadastro = DateTime.Now;
                        sts_ordemproducao.Ord_dataentrega = sts_orcamento.Orc_dataentrega;
                        sts_ordemproducao.Ord_situacao = "E";
                        sts_ordemproducao.Sts_orcamento = sts_orcamento;
                        repository.Save(sts_ordemproducao);
                        for (int i = 0; i < list.Count; i++)
                        {
                            Sts_ordemprodutos sts_ordemprodutos = new Sts_ordemprodutos();
                            sts_ordemprodutos.Odp_codigo = 0;
                            sts_ordemprodutos.Odp_quantidade = list[i].Ocp_quantidade;
                            sts_ordemprodutos.Sts_ordemproducao = sts_ordemproducao;
                            sts_ordemprodutos.Sts_produto = list[i].Sts_produto;
                            sts_ordemprodutos.Odp_produzido = false;
                            repository.Save(sts_ordemprodutos);
                        }
                        sts_orcamento.Orc_situacao = "A";
                        repository.Save(sts_orcamento);
                        return JsonConvert.SerializeObject(sts_ordemproducao);
                    }
                    else
                    {
                        return "Erro";
                    }
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