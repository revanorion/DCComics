namespace DCComics.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Location_Type",
                c => new
                    {
                        LOCATION_TYPE_SEQ = c.Byte(nullable: false, identity: true),
                        LOCATION_TYPE_CODE = c.String(maxLength: 20),
                        LOCATION_TYPE_DESC = c.String(maxLength: 100),
                        START_DATE = c.DateTime(),
                        END_DATE = c.DateTime(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                        Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.LOCATION_TYPE_SEQ);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 100),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Person");
            DropTable("dbo.Location_Type");
        }
    }
}
