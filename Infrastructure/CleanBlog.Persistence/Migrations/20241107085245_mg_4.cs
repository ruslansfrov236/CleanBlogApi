using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanBlog.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mg_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Headers_HeaderImages_HeaderImageId",
                table: "Headers");

            migrationBuilder.DropIndex(
                name: "IX_Headers_HeaderImageId",
                table: "Headers");

            migrationBuilder.DropColumn(
                name: "HeaderImageId",
                table: "Headers");

            migrationBuilder.AddColumn<Guid>(
                name: "HeaderId",
                table: "HeaderImages",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_HeaderImages_HeaderId",
                table: "HeaderImages",
                column: "HeaderId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HeaderImages_Headers_HeaderId",
                table: "HeaderImages",
                column: "HeaderId",
                principalTable: "Headers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HeaderImages_Headers_HeaderId",
                table: "HeaderImages");

            migrationBuilder.DropIndex(
                name: "IX_HeaderImages_HeaderId",
                table: "HeaderImages");

            migrationBuilder.DropColumn(
                name: "HeaderId",
                table: "HeaderImages");

            migrationBuilder.AddColumn<Guid>(
                name: "HeaderImageId",
                table: "Headers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Headers_HeaderImageId",
                table: "Headers",
                column: "HeaderImageId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Headers_HeaderImages_HeaderImageId",
                table: "Headers",
                column: "HeaderImageId",
                principalTable: "HeaderImages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
