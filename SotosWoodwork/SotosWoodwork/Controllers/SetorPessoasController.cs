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
    public class SetorPessoasController : Controller
    {
        public ActionResult SetorPessoasList()
        {
            return View();
        }

        public string FindAllEmployees(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                IList<Sts_pessoa> list = repository.ToList<Sts_pessoa>()
                    .Where(x => !repository.ToList<Sts_setorpessoas>()
                            .Where(xy => xy.Sts_pessoa.Pes_codigo == x.Pes_codigo && xy.Sts_setor.Set_codigo == id).Any()
                    ).Where(x => x.Pes_categoria == "T").ToList();

                return JsonConvert.SerializeObject(list);
            }
        }

        public string FindAllEmployeesDepartment(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                IList<Sts_pessoa> list = repository.ToList<Sts_setorpessoas>().Where(x => x.Sts_setor.Set_codigo == id).Select(x => x.Sts_pessoa).ToList();
                return JsonConvert.SerializeObject(list);
            }
        }

        public string Save(string json, int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();

                    Sts_setor sts_setor = (Sts_setor)repository.GetById(typeof(Sts_setor), id);

                    IList<Sts_pessoa> list = JsonConvert.DeserializeObject<List<Sts_pessoa>>(json);                    
                    foreach (Sts_pessoa sts_pessoa in list)
                    {
                        if (repository.ToList<Sts_setorpessoas>().Where(x => x.Sts_setor.Set_codigo == id && sts_pessoa.Pes_codigo == x.Sts_pessoa.Pes_codigo).Count() == 0) {
                            Sts_setorpessoas sts_setorpessoas = new Sts_setorpessoas();
                            sts_setorpessoas.Sts_pessoa = sts_pessoa;
                            sts_setorpessoas.Sts_setor = sts_setor;
                            repository.Save(sts_setorpessoas);
                        }
                    }
                    repository.CommitTransaction();

                    return JsonConvert.SerializeObject(list);
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