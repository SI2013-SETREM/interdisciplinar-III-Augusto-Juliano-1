using FluentNHibernate.Mapping;

namespace SotosWoodwork.Models
{
    public class Sts_unidademedida
    {
        public virtual int Unm_codigo { get; set; }
        public virtual string Unm_descricao { get; set; }
        public virtual string Unm_sigla { get; set; }
    }

    public class Sts_unidademedidaMap : ClassMap<Sts_unidademedida>
    {
        public Sts_unidademedidaMap()
        {
            Id(x => x.Unm_codigo).GeneratedBy.Sequence("unm_codigo");
            Map(x => x.Unm_descricao);
            Map(x => x.Unm_sigla);

            Table("sts_unidademedida");
        }
    }
}