using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject_BloggingNewsSite.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Summary",
                table: "FinalProject_BloggingNewsSiteModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Summary",
                table: "FinalProject_BloggingNewsSiteModel");
        }
    }
}
