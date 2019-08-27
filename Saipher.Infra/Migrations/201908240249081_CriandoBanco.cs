namespace Saipher.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriandoBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aeronave",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Matricula = c.String(nullable: false, maxLength: 50, unicode: false),
                        Tipo = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.ID, unique: true, name: "UK_AERONAVE_ID");
            
            CreateTable(
                "dbo.Aeroporto",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Sigla = c.String(maxLength: 100, unicode: false),
                        Nome = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlanoDeVoo",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        AeroportoOrigemId = c.Guid(nullable: false),
                        AeroportoDestinoId = c.Guid(nullable: false),
                        AeronaveId = c.Guid(nullable: false),
                        VooId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Voo",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Numero = c.String(maxLength: 100, unicode: false),
                        Data = c.DateTime(nullable: false),
                        Horario = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Aeronave", "UK_AERONAVE_ID");
            DropTable("dbo.Voo");
            DropTable("dbo.PlanoDeVoo");
            DropTable("dbo.Aeroporto");
            DropTable("dbo.Aeronave");
        }
    }
}
