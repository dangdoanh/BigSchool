namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Categories values (1,'SEO')");
            Sql("Insert into Categories values (2,'MARKETING')");
            Sql("Insert into Categories values (3,'DIGITAL')");
        }
        
        public override void Down()
        {
        }
    }
}
