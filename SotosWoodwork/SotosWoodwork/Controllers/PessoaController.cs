using System.Collections.Generic;
using System.Web.Mvc;
using Newtonsoft.Json;
using SotosWoodwork.Models;
using NHibernate;
using SotosWoodwork.Repository;
using System.Linq;

namespace SotosWoodwork.Controllers
{
    public class PessoaController : Controller
    {
        //Listagem e Manutenção de Clientes
        public ActionResult PessoaList()
        {
            return View();
        }

        public ActionResult PessoaForm()
        {
            return View();
        }

        //Listagem e Manutenção de Fornecedores
        public ActionResult FornecedorList()
        {
            return View();
        }

        public ActionResult FornecedorForm()
        {
            return View();
        }

        //Listagem e Manutenção de Colaboradores
        public ActionResult ColaboradorList()
        {
            return View();
        }

        public ActionResult ColaboradorForm()
        {
            return View();
        }

        [HttpGet]
        public string FindAllClient()
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                IList<Sts_pessoa> listSts_pessoa = repository.ToList<Sts_pessoa>().Where(x => x.Pes_categoria == "C").ToList();
                return JsonConvert.SerializeObject(listSts_pessoa);
            }
        }

        [HttpGet]
        public string FindAllEmployee()
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                IList<Sts_pessoa> list = repository.ToList<Sts_pessoa>().Where(x => x.Pes_categoria == "T").ToList();

                return JsonConvert.SerializeObject(list);
            }
        }

        [HttpGet]
        public string FindAllProvider()
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                IList<Sts_pessoa> list = repository.ToList<Sts_pessoa>().Where(x => x.Pes_categoria == "F").ToList();

                return JsonConvert.SerializeObject(list);
            }
        }

        [HttpGet]
        public string GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                Sts_pessoa sts_pessoa = (Sts_pessoa)repository.GetById(typeof(Sts_pessoa), id);
                return JsonConvert.SerializeObject(sts_pessoa);
            }
        }

        public string Delete(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    Sts_pessoa sts_pessoa = (Sts_pessoa)repository.GetById(typeof(Sts_pessoa), id);
                    repository.Delete(sts_pessoa);

                    return JsonConvert.SerializeObject(sts_pessoa);
                }
                catch
                {
                    repository.RollbackTransaction();

                    return "Erro";
                }
            }
        }

        public string SaveClient(string json)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    Sts_pessoa sts_pessoa = JsonConvert.DeserializeObject<Sts_pessoa>(json);
                    sts_pessoa.Pes_categoria = "C";
                    repository.Save(sts_pessoa);

                    return JsonConvert.SerializeObject(sts_pessoa);
                }
                catch
                {
                    repository.RollbackTransaction();

                    return "Erro";
                }
            }
        }

        public string SaveEmployee(string json)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    Sts_pessoa sts_pessoa = JsonConvert.DeserializeObject<Sts_pessoa>(json);
                    sts_pessoa.Pes_categoria = "T";
                    sts_pessoa.Pes_tipo = "F";
                    repository.Save(sts_pessoa);

                    return JsonConvert.SerializeObject(sts_pessoa);
                }
                catch
                {
                    repository.RollbackTransaction();

                    return "Erro";
                }
            }
        }

        public string SaveProvider(string json)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    Sts_pessoa sts_pessoa = JsonConvert.DeserializeObject<Sts_pessoa>(json);
                    sts_pessoa.Pes_categoria = "F";
                    repository.Save(sts_pessoa);

                    return JsonConvert.SerializeObject(sts_pessoa);
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