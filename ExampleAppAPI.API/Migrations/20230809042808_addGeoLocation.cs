using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExampleAppAPI.API.Migrations
{
    /// <inheritdoc />
    public partial class addGeoLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Lattitude",
                table: "Client",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Client",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lattitude",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Client");
        }
    }
}
