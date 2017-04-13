namespace SwimmingPool.DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateOrderTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Order");
        }
    }
}
