namespace ASPNETMVC_Dionisius.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTableNew : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.TB_M_Division", name: "Department_Id", newName: "DepartmentId");
            RenameIndex(table: "dbo.TB_M_Division", name: "IX_Department_Id", newName: "IX_DepartmentId");
            DropColumn("dbo.TB_M_Division", "DepId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TB_M_Division", "DepId", c => c.Int());
            RenameIndex(table: "dbo.TB_M_Division", name: "IX_DepartmentId", newName: "IX_Department_Id");
            RenameColumn(table: "dbo.TB_M_Division", name: "DepartmentId", newName: "Department_Id");
        }
    }
}
