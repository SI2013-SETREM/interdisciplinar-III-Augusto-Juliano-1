using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Cfg;

namespace SotosWoodwork.Repository
{
    public class DataBase
    {
        private static ISessionFactory _sessionFactory;
        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    _sessionFactory = Fluently.Configure()
                        .Database(PostgreSQLConfiguration.PostgreSQL82
                        .ShowSql()
                        .ConnectionString("Server=localhost;Port=5432;Database=SotosWoodwork;User Id=postgres;Password=admin;"))
                        .Mappings(c => c.FluentMappings.AddFromAssemblyOf<Models.Sts_pessoaMap>())
                        //.ExposeConfiguration(x => new SchemaExport(x).Create(false, true))
                        .BuildSessionFactory();

                    /*_sessionFactory = new Configuration()
                        .Configure()
                        .AddAssembly(typeof (Models.Sts_pessoaMap).Assembly)
                        .BuildSessionFactory();*/
                }
                return _sessionFactory;
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}