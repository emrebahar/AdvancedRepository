namespace IleriRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.City",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.District",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    CityId = c.Int(nullable: false),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.City", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);

            CreateTable(
                "dbo.Personnel",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    EducationId = c.Int(nullable: false),
                    Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Name = c.String(),
                    SurName = c.String(),
                    BirthOfDate = c.DateTime(nullable: false),
                    Street = c.String(),
                    Avenue = c.String(),
                    HouseNumber = c.String(),
                    DistrictId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.District", t => t.DistrictId, cascadeDelete: true)
                .ForeignKey("dbo.Education", t => t.EducationId, cascadeDelete: true)
                .Index(t => t.EducationId)
                .Index(t => t.DistrictId);

            CreateTable(
                "dbo.Education",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Student",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    EducationId = c.Int(nullable: false),
                    TeacherId = c.Int(nullable: false),
                    UniversityDepartment = c.String(),
                    Name = c.String(),
                    SurName = c.String(),
                    BirthOfDate = c.DateTime(nullable: false),
                    Street = c.String(),
                    Avenue = c.String(),
                    HouseNumber = c.String(),
                    DistrictId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.District", t => t.DistrictId, cascadeDelete: true)
                .ForeignKey("dbo.Education", t => t.EducationId, cascadeDelete: true)
                .ForeignKey("dbo.Lecturer", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.EducationId)
                .Index(t => t.TeacherId)
                .Index(t => t.DistrictId);

            CreateTable(
                "dbo.Lecturer",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    EducationId = c.Int(),
                    AcademicTitle = c.String(),
                    Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Branch = c.String(),
                    Name = c.String(),
                    SurName = c.String(),
                    BirthOfDate = c.DateTime(nullable: false),
                    Street = c.String(),
                    Avenue = c.String(),
                    HouseNumber = c.String(),
                    DistrictId = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.District", t => t.DistrictId)
                .ForeignKey("dbo.Education", t => t.EducationId)
                .Index(t => t.EducationId)
                .Index(t => t.DistrictId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Student", "TeacherId", "dbo.Lecturer");
            DropForeignKey("dbo.Lecturer", "EducationId", "dbo.Education");
            DropForeignKey("dbo.Lecturer", "DistrictId", "dbo.District");
            DropForeignKey("dbo.Student", "EducationId", "dbo.Education");
            DropForeignKey("dbo.Student", "DistrictId", "dbo.District");
            DropForeignKey("dbo.Personnel", "EducationId", "dbo.Education");
            DropForeignKey("dbo.Personnel", "DistrictId", "dbo.District");
            DropForeignKey("dbo.District", "CityId", "dbo.City");
            DropIndex("dbo.Lecturer", new[] { "DistrictId" });
            DropIndex("dbo.Lecturer", new[] { "EducationId" });
            DropIndex("dbo.Student", new[] { "DistrictId" });
            DropIndex("dbo.Student", new[] { "TeacherId" });
            DropIndex("dbo.Student", new[] { "EducationId" });
            DropIndex("dbo.Personnel", new[] { "DistrictId" });
            DropIndex("dbo.Personnel", new[] { "EducationId" });
            DropIndex("dbo.District", new[] { "CityId" });
            DropTable("dbo.Lecturer");
            DropTable("dbo.Student");
            DropTable("dbo.Education");
            DropTable("dbo.Personnel");
            DropTable("dbo.District");
            DropTable("dbo.City");
        }
    }
}
