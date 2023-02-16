using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SabotageHelpToolApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateReviewModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Reviewers_reviewersId",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "reviewersId",
                table: "Reviews",
                newName: "reviewerId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_reviewersId",
                table: "Reviews",
                newName: "IX_Reviews_reviewerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Reviewers_reviewerId",
                table: "Reviews",
                column: "reviewerId",
                principalTable: "Reviewers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Reviewers_reviewerId",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "reviewerId",
                table: "Reviews",
                newName: "reviewersId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_reviewerId",
                table: "Reviews",
                newName: "IX_Reviews_reviewersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Reviewers_reviewersId",
                table: "Reviews",
                column: "reviewersId",
                principalTable: "Reviewers",
                principalColumn: "Id");
        }
    }
}
