using FluentNHibernate.Mapping;

namespace SotosWoodwork.Models
{
    public class Sts_processosprodutivos
    {
        public virtual int Prp_codigo { get; set; }
        public virtual Sts_setorpessoas Sts_setorpessoas { get; set; }
        public virtual Sts_maquina Sts_maquina { get; set; }
        public virtual string Prp_descricao { get; set; }
        public virtual decimal Prp_tempoestimado { get; set; }
    }

    public class Sts_processosprodutivosMap : ClassMap<Sts_processosprodutivos>
    {
        public Sts_processosprodutivosMap()
        {
            Id(x => x.Prp_codigo).GeneratedBy.Sequence("prp_codigo");
            References(x => x.Sts_setorpessoas, "stp_codigo").Not.LazyLoad();
            References(x => x.Sts_maquina, "maq_codigo").Not.LazyLoad();            
            Map(x => x.Prp_descricao);
            Map(x => x.Prp_tempoestimado);

            Table("sts_processosprodutivos");
        }
    }
}