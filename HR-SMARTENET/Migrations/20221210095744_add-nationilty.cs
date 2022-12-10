using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_SMARTENET.Migrations
{
    public partial class addnationilty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_bloodTypes",
                table: "bloodTypes");

            migrationBuilder.RenameTable(
                name: "bloodTypes",
                newName: "BloodTypes");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "BloodTypes",
                newName: "bloodType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BloodTypes",
                table: "BloodTypes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nationality = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nationalities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BloodTypes",
                table: "BloodTypes");

            migrationBuilder.RenameTable(
                name: "BloodTypes",
                newName: "bloodTypes");

            migrationBuilder.RenameColumn(
                name: "bloodType",
                table: "bloodTypes",
                newName: "Type");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bloodTypes",
                table: "bloodTypes",
                column: "Id");
        }
    }
}
