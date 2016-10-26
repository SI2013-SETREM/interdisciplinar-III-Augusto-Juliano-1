using FluentNHibernate.Mapping;

namespace SotosWoodwork.Models
{
    public class Sts_cidade
    {
        public virtual int Cid_codigo { get; set; }
        public virtual string Cid_descricao { get; set; }
        public virtual string Cid_uf { get; set; }
    }

    public class Sts_cidadeMap : ClassMap<Sts_cidade>
    {
        public Sts_cidadeMap()
        {
            Id(x => x.Cid_codigo).Column("cid_codigo").GeneratedBy.Sequence("cid_codigo");
            Map(x => x.Cid_descricao);
            Map(x => x.Cid_uf);

            Table("sts_cidade");
        }
    }
}