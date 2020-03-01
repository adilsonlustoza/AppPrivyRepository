using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPrivy.WebAppMvc.Migrations
{
    public partial class IniciandoMigrationsSite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Pesquisa",
                schema: "dbo",
                columns: table => new
                {
                    PesquisaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    IdentificadorUnico = table.Column<string>(nullable: true),
                    Titulo = table.Column<string>(maxLength: 150, nullable: false),
                    Descricao = table.Column<string>(maxLength: 1500, nullable: false),
                    Url = table.Column<string>(maxLength: 500, nullable: false),
                    Image = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pesquisa", x => x.PesquisaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pesquisa",
                schema: "dbo");
        }
    }
}
