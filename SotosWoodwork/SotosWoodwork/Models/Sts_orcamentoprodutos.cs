using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SotosWoodwork.Models
{
    public class Sts_orcamentoprodutos
    {
        public virtual int Ocp_codigo { get; set; }
        public virtual Sts_produto Sts_produto { get; set; }
        public virtual Sts_orcamento Sts_orcamento { get; set; }
        public virtual decimal Orc_quantidade { get; set; }
        public virtual decimal Orc_valorunit { get; set; }
        public virtual DateTime Orc_dataentrega { get; set; }
    }

    public class Sts_orcamentoprodutosMap : ClassMap<Sts_orcamentoprodutos>
    {
        public Sts_orcamentoprodutosMap()
        {
            Id(x => x.Ocp_codigo).GeneratedBy.Sequence("ocp_codigo");
            References(x => x.Sts_produto, "pro_codigo").Not.LazyLoad();
            References(x => x.Sts_orcamento, "orc_codigo").Not.LazyLoad();
            Map(x => x.Orc_quantidade);
            Map(x => x.Orc_valorunit);
            Map(x => x.Orc_dataentrega);

            Table("sts_orcamentoprodutos");
        }
    }
}