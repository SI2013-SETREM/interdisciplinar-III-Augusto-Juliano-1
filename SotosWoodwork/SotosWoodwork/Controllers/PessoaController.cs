using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using SotosWoodwork.Models;
using NHibernate;
using SotosWoodwork.Repository;

namespace SotosWoodwork.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form()
        {
            return View();
        }

        public string GetPessoas()
        {
            //IList<Sts_pessoa> listSts_pessoa = new IList<Sts_pessoa>();
            using (ISession session = DataBase.OpenSession())
            {
                IList<Sts_pessoa> listSts_pessoa = session
                    .CreateCriteria<Sts_pessoa>()
                    .List<Sts_pessoa>();
                return JsonConvert.SerializeObject(listSts_pessoa);
            }
            
        }


    }
}