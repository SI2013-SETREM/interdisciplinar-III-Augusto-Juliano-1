using FluentNHibernate.Mapping;
using System;

namespace SotosWoodwork.Models
{
    public class Sts_ordemcompraprodutos
    {
        public virtual int Ocp_codigo { get; set; }
        public virtual Sts_ordemcompra Sts_ordemcompra { get; set; }
        public virtual Sts_produto Sts_produto { get; set; }
        public virtual decimal Ocp_valorunitario { get; set; }
        public virtual decimal Ocp_quantidade { get; set; }
        public virtual decimal Ocp_quantidaderecebida { get; set; }
        public virtual DateTime Ocp_datarecebimento { get; set; }
    }

    public class Sts_ordemcompraprodutosMap : ClassMap<Sts_ordemcompraprodutos>
    {
        public Sts_ordemcompraprodutosMap()
        {
            Id(x => x.Ocp_codigo).GeneratedBy.Sequence("pes_codigo");
            References(x => x.Sts_ordemcompra, "ocp_codigo").Not.LazyLoad();
            References(x => x.Sts_produto, "pro_codigo").Not.LazyLoad();
            Map(x => x.Ocp_valorunitario);
            Map(x => x.Ocp_quantidade);
            Map(x => x.Ocp_quantidaderecebida);
            Map(x => x.Ocp_datarecebimento);

            Table("sts_ordemcompraprodutos");
        }
    }
}