using FluentNHibernate.Mapping;

namespace SotosWoodwork.Models
{
    public class Sts_maquina
    {
        public virtual int Maq_codigo { get; set; }
        public virtual Sts_setor Sts_setor { get; set; }
        public virtual string Maq_descricao { get; set; }
        public virtual bool Maq_status { get; set; }
    }

    public class Sts_maquinaMap : ClassMap<Sts_maquina>
    {
        public Sts_maquinaMap()
        {
            Id(x => x.Maq_codigo).GeneratedBy.Sequence("maq_codigo");
            References(x => x.Sts_setor, "set_codigo").Not.LazyLoad();
            Map(x => x.Maq_descricao);
            Map(x => x.Maq_status);

            Table("sts_maquina");
        }
    }
}