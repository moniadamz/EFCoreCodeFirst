using Microsoft.EntityFrameworkCore.Migrations;

namespace ExercicioEFCoreCodeFirst.Migrations
{
    public partial class NovaAlteracao2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Characters_ActorId",
                table: "Characters",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_MovieId",
                table: "Characters",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Actors_ActorId",
                table: "Characters",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "ActorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Movies_MovieId",
                table: "Characters",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Actors_ActorId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Movies_MovieId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_ActorId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_MovieId",
                table: "Characters");
        }
    }
}
