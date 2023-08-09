using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExampleAppAPI.API.Migrations
{
    /// <inheritdoc />
    public partial class renameLatitude : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lattitude",
                table: "Client",
                newName: "Latitude");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Latitude",
                table: "Client",
                newName: "Lattitude");
        }
    }
}
