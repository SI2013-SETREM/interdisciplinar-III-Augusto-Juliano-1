using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SotosWoodwork.Models
{
    public class Sts_estoque
    {
        public virtual int Est_codigo { get; set; }
        public virtual Sts_produto Sts_produto { get; set; }
        public virtual Sts_ordemprodutos Sts_ordemprodutos { get; set; }
        public virtual Sts_ordemcompraprodutos Sts_ordemcompraprodutos { get; set; }
        public virtual DateTime Est_dataregistro { get; set; }
        public virtual decimal Est_quantidade { get; set; }
        public virtual string Est_tipo { get; set; }
        
    }

    public class Sts_estoqueMap : ClassMap<Sts_estoque>
    {
        public Sts_estoqueMap()
        {
            Id(x => x.Est_codigo).GeneratedBy.Sequence("est_codigo");
            References(x => x.Sts_produto, "pro_codigo").Not.LazyLoad();
            References(x => x.Sts_ordemprodutos, "odp_codigo").Not.LazyLoad();
            References(x => x.Sts_ordemcompraprodutos, "ocp_codigo").Not.LazyLoad();
            Map(x => x.Est_dataregistro);
            Map(x => x.Est_quantidade);
            Map(x => x.Est_tipo);

            Table("sts_estoque");
        }
    }
}