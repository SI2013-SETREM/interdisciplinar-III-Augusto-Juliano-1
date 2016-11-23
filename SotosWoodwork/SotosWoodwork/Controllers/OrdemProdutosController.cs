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
    public class OrdemProdutosController : Controller
    {
        public ActionResult OrdemProdutosList()
        {
            return View();
        }

        public ActionResult OrdemProdutosForm()
        {
            return View();
        }

        [HttpGet]
        public string baixarOP(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    Sts_ordemprodutos sts_ordemprodutos = (Sts_ordemprodutos)repository.GetById(typeof(Sts_ordemprodutos), id);
                    if (sts_ordemprodutos.Odp_produzido == false)
                    {
                        sts_ordemprodutos.Odp_produzido = true;
                        repository.Save(sts_ordemprodutos);
                        IList<Sts_ordemprodutos> list = repository.ToList<Sts_ordemprodutos>().Where(x => x.Sts_ordemproducao.Ord_codigo == sts_ordemprodutos.Sts_ordemproducao.Ord_codigo).ToList();
                        bool tudoProduzido = true;
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (!list[i].Odp_produzido)
                                tudoProduzido = false;
                        }
                        if (tudoProduzido)
                            sts_ordemprodutos.Sts_ordemproducao.Ord_situacao = "P";
                        repository.Save(sts_ordemprodutos.Sts_ordemproducao);
                        Sts_estoque sts_estoque = new Sts_estoque();
                        sts_estoque.Est_codigo = 0;
                        sts_estoque.Est_dataregistro = DateTime.Now;
                        sts_estoque.Est_quantidade = sts_ordemprodutos.Odp_quantidade;
                        sts_estoque.Sts_ordemprodutos = sts_ordemprodutos;
                        sts_estoque.Sts_produto = sts_ordemprodutos.Sts_produto;
                        sts_estoque.Sts_ordemcompraprodutos = null;
                        sts_estoque.Est_tipo = "E";
                        repository.Save(sts_estoque);
                        return JsonConvert.SerializeObject(sts_ordemprodutos);
                    }
                    else
                    {
                        return "Erro";
                    }
                }
                catch {
                    repository.RollbackTransaction();

                    return "Erro";
                }
            }
        }

        [HttpGet]
        public string FindAllProductsOrder(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                IList<Sts_ordemprodutos> list = repository.ToList<Sts_ordemprodutos>()
                    .Where(x => x.Sts_ordemproducao.Ord_codigo == id).ToList();
                return JsonConvert.SerializeObject(list);
            }
        }

        [HttpGet]
        public string GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                Sts_ordemprodutos sts_ordemprodutos = (Sts_ordemprodutos)repository.GetById(typeof(Sts_ordemprodutos), id);
                return JsonConvert.SerializeObject(sts_ordemprodutos);
            }
        }

        public string Save(string json)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    Sts_ordemprodutos Sts_ordemprodutos = JsonConvert.DeserializeObject<Sts_ordemprodutos>(json);
                    repository.Save(Sts_ordemprodutos);
                    Sts_estoque sts_estoque = new Sts_estoque();
                    sts_estoque.Est_codigo = 0;
                    sts_estoque.Est_dataregistro = DateTime.Now;
                    sts_estoque.Est_quantidade = Sts_ordemprodutos.Odp_quantidade;
                    sts_estoque.Sts_ordemprodutos = Sts_ordemprodutos;
                    sts_estoque.Sts_produto = Sts_ordemprodutos.Sts_produto;
                    sts_estoque.Sts_ordemcompraprodutos = null;
                    sts_estoque.Est_tipo = "E";
                    repository.Save(sts_estoque);

                    return JsonConvert.SerializeObject(Sts_ordemprodutos);
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
                    Sts_ordemprodutos Sts_ordemprodutos = (Sts_ordemprodutos)repository.GetById(typeof(Sts_ordemprodutos), id);
                    repository.Delete(Sts_ordemprodutos);

                    return JsonConvert.SerializeObject(Sts_ordemprodutos);
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