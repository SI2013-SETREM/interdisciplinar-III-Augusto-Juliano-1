using FluentNHibernate.Mapping;

namespace SotosWoodwork.Models
{
    public class Sts_grupo
    {
        public virtual int Grp_codigo { get; set; }
        public virtual string Grp_descricao { get; set; }
        public virtual bool Grp_status { get; set; }
        public virtual decimal Grp_descontofixo { get; set; }
    }

    public class Sts_grupoMap : ClassMap<Sts_grupo>
    {
        public Sts_grupoMap ()
        {
            Id(x => x.Grp_codigo).GeneratedBy.Sequence("grp_codigo");
            Map(x => x.Grp_descricao);
            Map(x => x.Grp_status);
            Map(x => x.Grp_descontofixo);

            Table("sts_grupo");
        }
    }
}