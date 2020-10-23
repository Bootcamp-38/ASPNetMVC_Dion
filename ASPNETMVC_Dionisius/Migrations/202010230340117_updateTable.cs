namespace ASPNETMVC_Dionisius.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TB_M_Division", "DepId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TB_M_Division", "DepId");
        }
    }
}
