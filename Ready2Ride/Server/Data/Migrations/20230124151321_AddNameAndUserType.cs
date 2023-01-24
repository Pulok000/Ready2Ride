using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ready2Ride.Server.Data.Migrations
{
    public partial class AddNameAndUserType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                            name: "UserType",
                            table: "AspNetUsers",
                            type: "nvarchar(max)",
                            nullable: true);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");
            migrationBuilder.DropColumn(
                            name: "UserType",
                            table: "AspNetUsers");

        }
    }
}
