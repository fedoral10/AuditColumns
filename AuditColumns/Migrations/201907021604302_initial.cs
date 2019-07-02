namespace AuditColumns.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ARTICULO",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NOMBRE = c.String(),
                        COSTO = c.Double(nullable: false),
                        FECHA_CREACION = c.DateTime(nullable: false),
                        USUARIO_CREACION = c.String(),
                        FECHA_MODIFICACION = c.DateTime(),
                        USUARIO_MODIFICACION = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ARTICULO");
        }
    }
}
