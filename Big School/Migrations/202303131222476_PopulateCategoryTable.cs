namespace Big_School.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUEs (1, 'Development')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUEs (2, 'Business')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUEs (3, 'Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
