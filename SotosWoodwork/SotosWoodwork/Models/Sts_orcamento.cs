using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SotosWoodwork.Models
{
    public class Sts_orcamento
    {
        public virtual int Orc_codigo { get; set; }
        public virtual DateTime Orc_data { get; set; }
        public virtual int Orc_numeropedido { get; set; }
        public virtual string Orc_formapagamento { get; set; }
        public virtual decimal Orc_desconto { get; set; }
        public virtual bool Orc_situacao { get; set; }
        public virtual DateTime Orc_dataentrega { get; set; }
    }

    public class Sts_orcamentoMap : ClassMap<Sts_orcamento>
    {
        public Sts_orcamentoMap()
        {
            Id(x => x.Orc_codigo).GeneratedBy.Sequence("orc_codigo");
            Map(x => x.Orc_data);
            Map(x => x.Orc_numeropedido);
            Map(x => x.Orc_formapagamento);
            Map(x => x.Orc_desconto);
            Map(x => x.Orc_situacao);
            Map(x => x.Orc_dataentrega);

            Table("sts_orcamento");
        }
    }
}

