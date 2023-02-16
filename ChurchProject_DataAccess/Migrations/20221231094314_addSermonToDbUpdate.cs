using Microsoft.EntityFrameworkCore.Migrations;

namespace ChurchProject_DataAccess.Migrations
{
    public partial class addSermonToDbUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Sermon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sermon_CategoryId",
                table: "Sermon",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sermon_Category_CategoryId",
                table: "Sermon",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sermon_Category_CategoryId",
                table: "Sermon");

            migrationBuilder.DropIndex(
                name: "IX_Sermon_CategoryId",
                table: "Sermon");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Sermon");
        }
    }
}
