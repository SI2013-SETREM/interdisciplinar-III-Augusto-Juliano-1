using FluentNHibernate.Mapping;

namespace SotosWoodwork.Models
{
    public class Sts_produtomateriais
    {
        public virtual int Pmp_codigo { get; set; }
        public virtual Sts_produto Sts_produto { get; set; }
        public virtual Sts_produto Sts_materiaprima { get; set; }
        public virtual decimal Pmp_quantidade { get; set; }
    }

    public class Sts_produtomateriaisMap : ClassMap<Sts_produtomateriais>
    {
        public Sts_produtomateriaisMap()
        {
            Id(x => x.Pmp_codigo).GeneratedBy.Sequence("pmp_codigo");
            References(x => x.Sts_produto, "pro_codigo").Not.LazyLoad();
            References(x => x.Sts_materiaprima, "pro_materiaprima").Not.LazyLoad();
            Map(x => x.Pmp_quantidade);

            Table("sts_produtomateriais");
        }
    }
}