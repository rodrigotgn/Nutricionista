namespace Nutricionista.Migrations
{
    using Models;
    using System;
    using System.Data.Entity.Migrations;

    public partial class create_users : DbMigration
    {
        public override void Up()
        {
            using (var context = new MainContext())
            {
                context.Usuarios.Add(new Usuario() {
                    DesEmail = "rodrigotgn@outlook.com",
                    DesNome = "Rodrigo Torres",
                    DesSenha = "123456",
                    FlgExcluido = false,
                    FlgBloqueado = false,
                    TipPerfil = Utils.Enum.Perfil.Administrador,
                    DatCadastro = DateTime.Now
                });
                
                context.SaveChanges();
            }
        }
        
        public override void Down()
        {
        }
    }
}
