using FluentNHibernate.Mapping;

namespace SotosWoodwork.Models
{
    public class Sts_cor
    {
        //c
        public virtual int Cor_codigo { get; set; }
        public virtual string Cor_descricao { get; set; }
        public virtual string Cor_codigocor { get; set; }
    }

    public class Sts_corMap : ClassMap<Sts_cor>
    {
        public Sts_corMap()
        {
            Id(x => x.Cor_codigo).GeneratedBy.Sequence("cor_codigo");
            Map(x => x.Cor_descricao);
            Map(x => x.Cor_codigocor);

            Table("sts_cor");
        }
    }
}