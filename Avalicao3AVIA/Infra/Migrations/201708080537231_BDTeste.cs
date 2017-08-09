namespace Avalicao3AVIA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BDTeste : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        IDUsuario = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Sobrenome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Email = c.String(nullable: false, maxLength: 150, unicode: false),
                        Cidade = c.String(maxLength: 100, unicode: false),
                        Telefone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDUsuario);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuario");
        }
    }
}
