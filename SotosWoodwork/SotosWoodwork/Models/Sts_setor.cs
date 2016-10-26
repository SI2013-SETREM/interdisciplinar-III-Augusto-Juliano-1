using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SotosWoodwork.Models
{
    public class Sts_setor
    {
        public virtual int Set_codigo { get; set; }
        public virtual string Set_descricao { get; set; }
        public virtual bool Set_produtivo { get; set; }
    }

    public class Sts_setorMap : ClassMap<Sts_setor>
    {
        public Sts_setorMap ()
        {
            Id(x => x.Set_codigo).GeneratedBy.Sequence("set_codigo");
            Map(x => x.Set_descricao);
            Map(x => x.Set_produtivo);

            Table("sts_setor");

        }
    }
}