using FluentNHibernate.Mapping;
using System;

namespace SotosWoodwork.Models
{
    public class Sts_ordemcompra
    {
        public virtual int Odc_codigo { get; set; }
        public virtual Sts_pessoa Sts_pessoa { get; set; }
        public virtual DateTime Odc_datacadastro { get; set; }
        public virtual DateTime Odc_dataentrega { get; set; }
        public virtual string Odc_procedencia { get; set; }
        public virtual bool Odc_aprovada { get; set; }
        public virtual string Odc_fase { get; set; }
        public virtual int Odc_nfe { get; set; }
        public virtual string Odc_transportador { get; set; }
    }

    public class Sts_ordemcompraMap : ClassMap<Sts_ordemcompra>
    {
        public Sts_ordemcompraMap()
        {
            Id(x => x.Odc_codigo).GeneratedBy.Sequence("odc_codigo");
            References(x => x.Sts_pessoa, "pes_fornecedor").Not.LazyLoad();
            Map(x => x.Odc_datacadastro);
            Map(x => x.Odc_dataentrega);
            Map(x => x.Odc_procedencia);
            Map(x => x.Odc_aprovada);
            Map(x => x.Odc_fase);
            Map(x => x.Odc_nfe);
            Map(x => x.Odc_transportador);

            Table("sts_ordemcompra");
        }
    }
}