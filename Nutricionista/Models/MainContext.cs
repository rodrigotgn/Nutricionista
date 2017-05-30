using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Migrations.History;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Nutricionista.Models
{
    public class MainContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }
        
        private static MainContext instance;

        /// <summary>
        /// Retorna o MainContext já instanciado.
        /// Método criado para ser utilizado pelo project Console, já que o mesmo não possui HttpContext.Current.Items.
        /// </summary>
        public static MainContext GetInstance()
        {
            if (instance == null)
            {
                instance = new MainContext();
            }
            return instance;
        }

        public MainContext(string connString) : base(connString)
        {
        }

        public MainContext() : base("MainConnection")
        {
        }

        public DbSet<Usuario> Usuarios { get; set; } 
        public DbSet<Servicos> Servicos { get; set; }
        public DbSet<Depoimento> Depoimentos { get; set; }
        public DbSet<DepoimentoItem> DepoimentoItems { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<ConfiguracaoSistema> ConfiguracaoSistemas { get; set; }
        public DbSet<Clinica> Clinicas { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogItem> BlogItems { get; set; }
        
    }

    public class MySqlHistoryContext : HistoryContext
    {
        public MySqlHistoryContext(DbConnection existingConnection, string defaultSchema) : base(existingConnection, defaultSchema)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<HistoryRow>().Property(h => h.MigrationId).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<HistoryRow>().Property(h => h.ContextKey).HasMaxLength(200).IsRequired();
        }
    }

    public class MySqlConfiguration : DbConfiguration
    {
        public MySqlConfiguration()
        {
            SetHistoryContext("MySql.Data.MySqlClient", (conn, schema) => new MySqlHistoryContext(conn, schema));
        }
    }
}