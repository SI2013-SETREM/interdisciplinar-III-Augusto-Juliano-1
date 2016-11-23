using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SotosWoodwork.Models
{
    public class Sts_formapagamento
    {
        public virtual int Frp_codigo { get; set; }
        public virtual string Frp_descricao { get; set; }
        public virtual decimal Frp_desconto { get; set; }
    }

    public class Sts_formapagamentoMap : ClassMap<Sts_formapagamento>
    {
        public Sts_formapagamentoMap()
        {
            Id(x => x.Frp_codigo).GeneratedBy.Sequence("frp_codigo");
            Map(x => x.Frp_descricao);
            Map(x => x.Frp_desconto);

            Table("sts_formapagamento");
        }
    }
}