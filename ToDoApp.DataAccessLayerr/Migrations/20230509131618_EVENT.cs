using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoApp.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class EVENT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PartecipantNumber",
                table: "EventTypes",
                newName: "EntrantNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EntrantNumber",
                table: "EventTypes",
                newName: "PartecipantNumber");
        }
    }
}
