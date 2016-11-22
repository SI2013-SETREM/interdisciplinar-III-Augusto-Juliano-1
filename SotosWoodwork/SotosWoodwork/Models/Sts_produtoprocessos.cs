using FluentNHibernate.Mapping;
using System;

namespace SotosWoodwork.Models
{
    public class Sts_produtoprocessos
    {
        public virtual int Ppc_codigo { get; set; }
        public virtual Sts_produto Sts_produto { get; set; }
        public virtual Sts_maquina Sts_maquina { get; set; }
        public virtual Sts_setorpessoas Sts_setorpessoas { get; set; }
        public virtual DateTime Ppc_tempoproducao { get; set; }
        public virtual string Ppc_descricao { get; set; }
    }

    public class Sts_produtoprocessosMap : ClassMap<Sts_produtoprocessos>
    {
        public Sts_produtoprocessosMap()
        {
            Id(x => x.Ppc_codigo).GeneratedBy.Sequence("ppc_codigo");
            References(x => x.Sts_produto, "pro_codigo").Not.LazyLoad();
            References(x => x.Sts_maquina, "maq_codigo").Not.LazyLoad();
            References(x => x.Sts_setorpessoas, "stp_codigo").Not.LazyLoad();
            Map(x => x.Ppc_tempoproducao);
            Map(x => x.Ppc_descricao);

            Table("sts_produtoprocessos");
        }
    }
}