using FluentNHibernate.Mapping;

namespace SotosWoodwork.Models
{
    public class Sts_pessoa
    {
        public virtual int Pes_codigo { get; set; }
        public virtual Sts_cidade Sts_cidade { get; set; }
        public virtual Sts_grupo Sts_grupo { get; set; }
        public virtual string Pes_razaosocial { get; set; }
        public virtual string Pes_nomefantasia { get; set; }
        public virtual string Pes_tipo { get; set; }
        public virtual string Pes_categoria { get; set; }
        public virtual string Pes_cpfcnpj { get; set; }
        public virtual string Pes_endereco { get; set; }
        public virtual string Pes_bairro { get; set; }
        public virtual string Pes_numero { get; set; }
        public virtual string Pes_complemento { get; set; }
        public virtual string Pes_email { get; set; }
        public virtual string Pes_telefone { get; set; }
        public virtual string Pes_telefone2 { get; set; }
        public virtual string Pes_cep { get; set; }
        public virtual bool Pes_situacao { get; set; }                
    }

    public class Sts_pessoaMap : ClassMap<Sts_pessoa>
    {
        public Sts_pessoaMap()
        {
            Id(x => x.Pes_codigo).GeneratedBy.Sequence("pes_codigo");
            References(x => x.Sts_cidade, "cid_codigo").Not.LazyLoad();
            References(x => x.Sts_grupo, "grp_codigo").Not.LazyLoad();
            Map(x => x.Pes_razaosocial);
            Map(x => x.Pes_nomefantasia);
            Map(x => x.Pes_tipo);
            Map(x => x.Pes_categoria);
            Map(x => x.Pes_cpfcnpj);
            Map(x => x.Pes_endereco);
            Map(x => x.Pes_bairro);
            Map(x => x.Pes_numero);
            Map(x => x.Pes_complemento);
            Map(x => x.Pes_email);
            Map(x => x.Pes_telefone);
            Map(x => x.Pes_telefone2);
            Map(x => x.Pes_cep);
            Map(x => x.Pes_situacao);

            Table("sts_pessoa");
        }
    }
}