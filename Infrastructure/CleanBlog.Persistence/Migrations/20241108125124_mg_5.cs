using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanBlog.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mg_5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HeaderImages_Headers_HeaderId",
                table: "HeaderImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HeaderImages",
                table: "HeaderImages");

            migrationBuilder.RenameTable(
                name: "HeaderImages",
                newName: "HeaderImage");

            migrationBuilder.RenameIndex(
                name: "IX_HeaderImages_HeaderId",
                table: "HeaderImage",
                newName: "IX_HeaderImage_HeaderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HeaderImage",
                table: "HeaderImage",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HeaderImage_Headers_HeaderId",
                table: "HeaderImage",
                column: "HeaderId",
                principalTable: "Headers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HeaderImage_Headers_HeaderId",
                table: "HeaderImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HeaderImage",
                table: "HeaderImage");

            migrationBuilder.RenameTable(
                name: "HeaderImage",
                newName: "HeaderImages");

            migrationBuilder.RenameIndex(
                name: "IX_HeaderImage_HeaderId",
                table: "HeaderImages",
                newName: "IX_HeaderImages_HeaderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HeaderImages",
                table: "HeaderImages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HeaderImages_Headers_HeaderId",
                table: "HeaderImages",
                column: "HeaderId",
                principalTable: "Headers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
