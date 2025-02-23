using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp2.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_user_Passes",
                table: "user_Passes");

            migrationBuilder.RenameTable(
                name: "user_Passes",
                newName: "user_pass");

            migrationBuilder.AlterColumn<string>(
                name: "username",
                table: "user_pass",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "user_pass",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_pass",
                table: "user_pass",
                column: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_user_pass",
                table: "user_pass");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "user_pass");

            migrationBuilder.RenameTable(
                name: "user_pass",
                newName: "user_Passes");

            migrationBuilder.AlterColumn<string>(
                name: "username",
                table: "user_Passes",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_Passes",
                table: "user_Passes",
                column: "username");
        }
    }
}
