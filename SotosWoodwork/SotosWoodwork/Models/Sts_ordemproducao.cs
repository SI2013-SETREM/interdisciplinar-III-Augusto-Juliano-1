using FluentNHibernate.Mapping;
using System;

namespace SotosWoodwork.Models
{
    public class Sts_ordemproducao
    {
        public virtual int Ord_codigo { get; set; }
        public virtual Sts_orcamento Sts_orcamento { get; set; }
        public virtual DateTime Ord_datacadastro { get; set; }
        public virtual DateTime Ord_dataentrega { get; set; }
        public virtual string Ord_situacao { get; set; }
    }

    public class Sts_ordemproducaoMap : ClassMap<Sts_ordemproducao>
    {
        public Sts_ordemproducaoMap()
        {
            Id(x => x.Ord_codigo).GeneratedBy.Sequence("ord_codigo");
            References(x => x.Sts_orcamento, "orc_codigo").Not.LazyLoad();
            Map(x => x.Ord_datacadastro);
            Map(x => x.Ord_dataentrega);
            Map(x => x.Ord_situacao);

            Table("sts_ordemproducao");
        }
    }
}