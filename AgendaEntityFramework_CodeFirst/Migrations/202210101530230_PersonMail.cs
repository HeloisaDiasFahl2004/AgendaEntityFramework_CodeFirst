namespace AgendaEntityFramework_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonMail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Mail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Mail");
        }
    }
}
