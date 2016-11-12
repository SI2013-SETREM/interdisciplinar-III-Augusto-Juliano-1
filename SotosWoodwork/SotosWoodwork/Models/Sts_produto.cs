using FluentNHibernate.Mapping;
using System;

namespace SotosWoodwork.Models
{
    public class Sts_produto
    {
        public virtual int Pro_codigo { get; set; }
        public virtual Sts_pessoa Sts_pessoa { get; set; }
        public virtual Sts_unidademedida Sts_unidademedida { get; set; }
        public virtual string Pro_codigofabrica { get; set; }
        public virtual string Pro_descricao { get; set; }
        public virtual string Pro_tipo { get; set; }
        public virtual DateTime Pro_datacadastro { get; set; }
        public virtual decimal Pro_valorcusto { get; set; }
        public virtual decimal Pro_valorvenda { get; set; }
    }

    public class Sts_produtoMap : ClassMap<Sts_produto>
    {
        public Sts_produtoMap()
        {
            Id(x => x.Pro_codigo).GeneratedBy.Sequence("pro_codigo");
            References(x => x.Sts_pessoa, "pes_fornecedor").Not.LazyLoad();
            References(x => x.Sts_unidademedida, "unm_codigo").Not.LazyLoad();
            Map(x => x.Pro_codigofabrica);
            Map(x => x.Pro_descricao);
            Map(x => x.Pro_tipo);
            Map(x => x.Pro_datacadastro);
            Map(x => x.Pro_valorcusto);
            Map(x => x.Pro_valorvenda);

            Table("sts_produto");
        }
    }
}