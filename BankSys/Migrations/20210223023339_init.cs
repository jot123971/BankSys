using Microsoft.EntityFrameworkCore.Migrations;
using System.IO;

namespace BankSys.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bank",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_Name = table.Column<string>(nullable: true),
                    employee_Position = table.Column<string>(nullable: true),
                    employee_Email = table.Column<string>(nullable: true),
                    employee_Contact = table.Column<string>(nullable: true),
                    employee_Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.Id);
                });
            var sqlFile = Path.Combine(".//DBScript", @"script.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bank");
        }
    }
}
