using Microsoft.EntityFrameworkCore.Migrations;

namespace pleaseoftheloveofgodbethelastversionofthisproject.Migrations
{
    public partial class godiwanttodie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userContent_questionType_questionType",
                table: "userContent");

            migrationBuilder.DropForeignKey(
                name: "FK_userReftoId",
                table: "userContent");

            migrationBuilder.DropForeignKey(
                name: "FK_userSessionTracker_questionType_questionType",
                table: "userSessionTracker");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userSessionTracker",
                table: "userSessionTracker");

            migrationBuilder.DropPrimaryKey(
                name: "PK__userCont__DD0C739A7D3847AA",
                table: "userContent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_questionType",
                table: "questionType");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionsAttempted",
                table: "AspNetUsers",
                nullable: false,
                defaultValueSql: "((0))",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CorrectAnswers",
                table: "AspNetUsers",
                nullable: false,
                defaultValueSql: "((0))",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK__userSess__23DB122BFA942296",
                table: "userSessionTracker",
                column: "sessionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__userCont__DD0C739AAFAE5F63",
                table: "userContent",
                column: "postId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__question__F04DF13A498E6817",
                table: "questionType",
                column: "typeId");

            migrationBuilder.AddForeignKey(
                name: "FK_questionType",
                table: "userContent",
                column: "questionType",
                principalTable: "questionType",
                principalColumn: "typeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userReftoId",
                table: "userContent",
                column: "userRef",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_toQuestionType",
                table: "userSessionTracker",
                column: "questionType",
                principalTable: "questionType",
                principalColumn: "typeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_questionType",
                table: "userContent");

            migrationBuilder.DropForeignKey(
                name: "FK_userReftoId",
                table: "userContent");

            migrationBuilder.DropForeignKey(
                name: "FK_toQuestionType",
                table: "userSessionTracker");

            migrationBuilder.DropPrimaryKey(
                name: "PK__userSess__23DB122BFA942296",
                table: "userSessionTracker");

            migrationBuilder.DropPrimaryKey(
                name: "PK__userCont__DD0C739AAFAE5F63",
                table: "userContent");

            migrationBuilder.DropPrimaryKey(
                name: "PK__question__F04DF13A498E6817",
                table: "questionType");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionsAttempted",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValueSql: "((0))");

            migrationBuilder.AlterColumn<int>(
                name: "CorrectAnswers",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValueSql: "((0))");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userSessionTracker",
                table: "userSessionTracker",
                column: "sessionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__userCont__DD0C739A7D3847AA",
                table: "userContent",
                column: "postId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_questionType",
                table: "questionType",
                column: "typeId");

            migrationBuilder.AddForeignKey(
                name: "FK_userContent_questionType_questionType",
                table: "userContent",
                column: "questionType",
                principalTable: "questionType",
                principalColumn: "typeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userReftoId",
                table: "userContent",
                column: "userRef",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userSessionTracker_questionType_questionType",
                table: "userSessionTracker",
                column: "questionType",
                principalTable: "questionType",
                principalColumn: "typeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
