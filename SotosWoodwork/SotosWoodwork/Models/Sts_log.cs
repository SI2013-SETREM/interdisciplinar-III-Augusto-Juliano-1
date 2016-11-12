using FluentNHibernate.Mapping;
using System;

namespace SotosWoodwork.Models
{
    public class Sts_log
    {
        public virtual int Log_codigo { get; set; }
        public virtual Sts_pessoa Sts_pessoa { get; set; }
        public virtual string Log_acao { get; set; }
        public virtual DateTime Log_data { get; set; }
        public virtual string Log_antigo { get; set; }
        public virtual string Log_novo { get; set; }
        public virtual string Log_tabela { get; set; }
    }

    public class Sts_logMap : ClassMap<Sts_log>
    {
        public Sts_logMap()
        {
            Id(x => x.Log_codigo).GeneratedBy.Sequence("pes_codigo");
            References(x => x.Sts_pessoa, "pes_codigo").Not.LazyLoad();
            Map(x => x.Log_acao);
            Map(x => x.Log_data);
            Map(x => x.Log_antigo);
            Map(x => x.Log_novo);
            Map(x => x.Log_tabela);

            Table("sts_log");
        }
    }
}