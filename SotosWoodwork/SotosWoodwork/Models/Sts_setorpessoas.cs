using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SotosWoodwork.Models
{
    public class Sts_setorpessoas
    {
        public virtual int Stp_codigo { get; set; }
        public virtual Sts_pessoa Sts_pessoa { get; set; }
        public virtual Sts_setor Sts_setor { get; set; }
    }

    public class Sts_setorpessoasMap : ClassMap<Sts_setorpessoas>
    {
        public Sts_setorpessoasMap()
        {
            Id(x => x.Stp_codigo).GeneratedBy.Sequence("stp_codigo");
            References(x => x.Sts_pessoa, "pes_codigo").Not.LazyLoad();
            References(x => x.Sts_setor, "set_codigo").Not.LazyLoad();

            Table("sts_setorpessoas");
        }
    }
}