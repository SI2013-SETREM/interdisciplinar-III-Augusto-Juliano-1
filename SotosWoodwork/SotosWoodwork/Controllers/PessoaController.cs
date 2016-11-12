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
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form()
        {
            return View();
        }

        [HttpGet]
        public string FindAll()
        {
            using (ISession session = DataBase.OpenSession())
            {
                IList<Sts_pessoa> listSts_pessoa = session
                    .CreateCriteria<Sts_pessoa>()
                    .List<Sts_pessoa>();
                return JsonConvert.SerializeObject(listSts_pessoa);
            }
        }

        [HttpGet]
        public string GetById(int id)
        {
            using (ISession session = DataBase.OpenSession())
            {
                Sts_pessoa sts_pessoa = session.Get<Sts_pessoa>(id);
                return JsonConvert.SerializeObject(sts_pessoa);
            }
        }
    }
}