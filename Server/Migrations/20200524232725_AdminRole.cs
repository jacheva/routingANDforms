using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class AdminRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
INSERT INTO AspNetRoles(Id, [Name], NormalizedName)
VALUES ('ffa36a66-ff92-4751-98fa-c1890334f2c5', 'Admin', 'Admin')
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
