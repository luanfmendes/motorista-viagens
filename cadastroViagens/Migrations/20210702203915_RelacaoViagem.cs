using Microsoft.EntityFrameworkCore.Migrations;

namespace cadastroViagens.Migrations
{
    public partial class RelacaoViagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MotoristaId",
                table: "Viagem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Viagem_MotoristaId",
                table: "Viagem",
                column: "MotoristaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Viagem_Motorista_MotoristaId",
                table: "Viagem",
                column: "MotoristaId",
                principalTable: "Motorista",
                principalColumn: "MotoristaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Viagem_Motorista_MotoristaId",
                table: "Viagem");

            migrationBuilder.DropIndex(
                name: "IX_Viagem_MotoristaId",
                table: "Viagem");

            migrationBuilder.DropColumn(
                name: "MotoristaId",
                table: "Viagem");
        }
    }
}
