namespace Nutricionista.Migrations
{
    using MySql.Data.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Model;
    using System.Data.Entity.Migrations.Sql;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Nutricionista.Models.MainContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            //SetSqlGenerator("MySql.Data.MySqlClient", new MyOwnMySqlMigrationSqlGenerator());
        }

        protected override void Seed(Nutricionista.Models.MainContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }

        public class MyOwnMySqlMigrationSqlGenerator : MySqlMigrationSqlGenerator
        {
            protected override MigrationStatement Generate(AddForeignKeyOperation addForeignKeyOperation)
            {
                addForeignKeyOperation.PrincipalTable = addForeignKeyOperation.PrincipalTable.Replace("dbo.", "");
                addForeignKeyOperation.DependentTable = addForeignKeyOperation.DependentTable.Replace("dbo.", "");
                MigrationStatement ms = base.Generate(addForeignKeyOperation);
                return ms;
            }
        }
    }
}
