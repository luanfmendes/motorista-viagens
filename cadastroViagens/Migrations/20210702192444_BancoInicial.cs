using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cadastroViagens.Migrations
{
    public partial class BancoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caminhao",
                columns: table => new
                {
                    CaminhaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eixos = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caminhao", x => x.CaminhaoId);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.EnderecoId);
                });

            migrationBuilder.CreateTable(
                name: "Viagem",
                columns: table => new
                {
                    ViagemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataHoraViagem = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LocalEntrega = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalSaida = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KmTotalEntreCidades = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viagem", x => x.ViagemId);
                });

            migrationBuilder.CreateTable(
                name: "Motorista",
                columns: table => new
                {
                    MotoristaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaminhaoId = table.Column<int>(type: "int", nullable: true),
                    EnderecoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorista", x => x.MotoristaId);
                    table.ForeignKey(
                        name: "FK_Motorista_Caminhao_CaminhaoId",
                        column: x => x.CaminhaoId,
                        principalTable: "Caminhao",
                        principalColumn: "CaminhaoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Motorista_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "EnderecoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Motorista_CaminhaoId",
                table: "Motorista",
                column: "CaminhaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorista_EnderecoId",
                table: "Motorista",
                column: "EnderecoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Motorista");

            migrationBuilder.DropTable(
                name: "Viagem");

            migrationBuilder.DropTable(
                name: "Caminhao");

            migrationBuilder.DropTable(
                name: "Endereco");
        }
    }
}
