namespace ShoppingCart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Carts");
            AlterColumn("dbo.Carts", "RecordId", c => c.String());
            AlterColumn("dbo.Carts", "CartId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Carts", "CartId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Carts");
            AlterColumn("dbo.Carts", "CartId", c => c.String());
            AlterColumn("dbo.Carts", "RecordId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Carts", "RecordId");
        }
    }
}
