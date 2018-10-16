namespace Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fkcursoturma : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Turmas", name: "Curso_Id", newName: "CursoId");
            RenameIndex(table: "dbo.Turmas", name: "IX_Curso_Id", newName: "IX_CursoId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Turmas", name: "IX_CursoId", newName: "IX_Curso_Id");
            RenameColumn(table: "dbo.Turmas", name: "CursoId", newName: "Curso_Id");
        }
    }
}
