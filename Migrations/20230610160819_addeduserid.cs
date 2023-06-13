using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebNotepad.Migrations
{
    /// <inheritdoc />
    public partial class addeduserid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                schema: "Identity",
                table: "Note",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                schema: "Identity",
                table: "Note");
        }
    }
}
