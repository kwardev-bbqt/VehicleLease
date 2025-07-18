﻿namespace VehicleLease.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRegionToBranch : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Branches", "Region", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Branches", "Region");
        }
    }
}
