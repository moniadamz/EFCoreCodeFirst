using Microsoft.EntityFrameworkCore.Migrations;

namespace ExercicioEFCoreCodeFirst.Migrations
{
    public partial class NovaAlteracao1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Characters_ActorMovieID",
                table: "Actors");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Movies_MovieIdID",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_MovieIdID",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Actors_ActorMovieID",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "MovieIdID",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "ActorMovieID",
                table: "Actors");

            migrationBuilder.AddColumn<int>(
                name: "ActorId",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Characters",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActorId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Characters");

            migrationBuilder.AddColumn<int>(
                name: "MovieIdID",
                table: "Characters",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ActorMovieID",
                table: "Actors",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_MovieIdID",
                table: "Characters",
                column: "MovieIdID");

            migrationBuilder.CreateIndex(
                name: "IX_Actors_ActorMovieID",
                table: "Actors",
                column: "ActorMovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Characters_ActorMovieID",
                table: "Actors",
                column: "ActorMovieID",
                principalTable: "Characters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Movies_MovieIdID",
                table: "Characters",
                column: "MovieIdID",
                principalTable: "Movies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
