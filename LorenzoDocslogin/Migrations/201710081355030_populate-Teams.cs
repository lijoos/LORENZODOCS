namespace LorenzoDocslogin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateTeams : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Teams (Id,name) values(1,'CDC')");
            Sql("Insert into Teams (Id,name) values(2,'Maternity')");
        }
        
        public override void Down()
        {
        }
    }
}
