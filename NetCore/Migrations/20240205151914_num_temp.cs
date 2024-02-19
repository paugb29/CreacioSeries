using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCore.Migrations
{
    public partial class num_temp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "num_temporades",
                table: "Serie",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "num_temporades",
                table: "Serie");
        }
    }
}
