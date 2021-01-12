using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelApp.Migrations
{
    public partial class AddFKRoleId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserFamilia",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserPassword",
                table: "Users",
                newName: "SecondName");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "UserLogin",
                table: "Users",
                newName: "Login");

            migrationBuilder.RenameColumn(
                name: "RoleName",
                table: "Roles",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "SecondName",
                table: "Users",
                newName: "UserPassword");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Login",
                table: "Users",
                newName: "UserLogin");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Roles",
                newName: "RoleName");

            migrationBuilder.AddColumn<string>(
                name: "UserFamilia",
                table: "Users",
                type: "text",
                nullable: true);
        }
    }
}
