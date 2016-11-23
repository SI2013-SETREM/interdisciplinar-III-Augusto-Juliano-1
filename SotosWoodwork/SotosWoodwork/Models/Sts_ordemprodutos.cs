using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SotosWoodwork.Models
{
    public class Sts_ordemprodutos
    {
        public virtual int Odp_codigo { get; set; }
        public virtual Sts_ordemproducao Sts_ordemproducao { get; set; }
        public virtual Sts_produto Sts_produto { get; set; }
        public virtual decimal Odp_quantidade { get; set; }
        public virtual DateTime Odp_dataproducao { get; set; }
        public virtual bool Odp_produzido { get; set; }
    }

    public class Sts_ordemprodutosMap : ClassMap<Sts_ordemprodutos>
    {
        public Sts_ordemprodutosMap()
        {
            Id(x => x.Odp_codigo).GeneratedBy.Sequence("odp_codigo");
            References(x => x.Sts_ordemproducao, "ord_codigo").Not.LazyLoad();
            References(x => x.Sts_produto, "pro_codigo").Not.LazyLoad();
            Map(x => x.Odp_quantidade);
            Map(x => x.Odp_dataproducao);
            Map(x => x.Odp_produzido);

            Table("sts_ordemprodutos");
        }
    }
}