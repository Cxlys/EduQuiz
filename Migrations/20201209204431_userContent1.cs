using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace pleaseoftheloveofgodbethelastversionofthisproject.Migrations
{
    public partial class userContent1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "userContent",
                columns: table => new
                {
                    postId = table.Column<int>(nullable: false),
                    userRef = table.Column<string>(maxLength: 450, nullable: true),
                    questionContent = table.Column<string>(maxLength: 50, nullable: true),
                    answerContent = table.Column<string>(maxLength: 200, nullable: true),
                    likes = table.Column<int>(nullable: true),
                    dislikes = table.Column<int>(nullable: true),
                    flags = table.Column<int>(nullable: true),
                    shadowed = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__userCont__DD0C739A7D3847AA", x => x.postId);
                    table.ForeignKey(
                        name: "FK_userReftoId",
                        column: x => x.userRef,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_userContent_userRef",
                table: "userContent",
                column: "userRef");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userContent");
        }
    }
}
