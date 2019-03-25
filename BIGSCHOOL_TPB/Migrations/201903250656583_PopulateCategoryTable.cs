namespace BIGSCHOOL_TPB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES(1, 'Lap trinh')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES(2, 'Kinh doanh')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES(3,'Quan tri mang')");
        }
        
        public override void Down()
        {
        }
    }
}
