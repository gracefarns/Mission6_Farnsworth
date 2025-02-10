using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission6Assignment.Migrations
{
    /// <inheritdoc />
    public partial class normalized : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Director",
                table: "Movies",
                newName: "DirectorL");

            migrationBuilder.AddColumn<string>(
                name: "DirectorF",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DirectorF",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "DirectorL",
                table: "Movies",
                newName: "Director");
        }
    }
}
