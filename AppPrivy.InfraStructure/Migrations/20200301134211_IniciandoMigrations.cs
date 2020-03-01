using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPrivy.InfraStructure.Migrations
{
    public partial class IniciandoMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "DoacaoMais");

            migrationBuilder.CreateTable(
                name: "Caccc",
                schema: "DoacaoMais",
                columns: table => new
                {
                    CacccId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    IdentificadorUnico = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(maxLength: 150, nullable: true),
                    Apelido = table.Column<string>(maxLength: 150, nullable: true),
                    Cnpj = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    EmailPagSeguro = table.Column<string>(nullable: true),
                    EmailPayPal = table.Column<string>(nullable: true),
                    UrlImagem = table.Column<string>(maxLength: 500, nullable: true),
                    Telefone = table.Column<string>(maxLength: 15, nullable: true),
                    Celular = table.Column<string>(maxLength: 15, nullable: true),
                    Autorizado = table.Column<bool>(nullable: false),
                    Responsavel = table.Column<string>(maxLength: 50, nullable: true),
                    DataFundacao = table.Column<DateTime>(nullable: true),
                    TipoDoacao = table.Column<int>(nullable: false),
                    Endereco_Cep = table.Column<string>(maxLength: 10, nullable: true),
                    Endereco_Logradouro = table.Column<string>(maxLength: 150, nullable: true),
                    Endereco_Numero = table.Column<string>(maxLength: 10, nullable: true),
                    Endereco_Longitude = table.Column<double>(nullable: true),
                    Endereco_Latitude = table.Column<double>(nullable: true),
                    Endereco_Bairro = table.Column<string>(maxLength: 50, nullable: true),
                    Endereco_Cidade = table.Column<string>(maxLength: 100, nullable: true),
                    Endereco_Estado = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caccc", x => x.CacccId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                schema: "DoacaoMais",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    IdentificadorUnico = table.Column<string>(nullable: true),
                    Login = table.Column<string>(maxLength: 150, nullable: true),
                    Email = table.Column<string>(maxLength: 350, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Bazar",
                schema: "DoacaoMais",
                columns: table => new
                {
                    BazarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    IdentificadorUnico = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(maxLength: 150, nullable: true),
                    Informacao = table.Column<string>(maxLength: 250, nullable: true),
                    Endereco_Cep = table.Column<string>(maxLength: 10, nullable: true),
                    Endereco_Logradouro = table.Column<string>(maxLength: 150, nullable: true),
                    Endereco_Numero = table.Column<string>(maxLength: 10, nullable: true),
                    Endereco_Longitude = table.Column<double>(nullable: true),
                    Endereco_Latitude = table.Column<double>(nullable: true),
                    Endereco_Bairro = table.Column<string>(maxLength: 50, nullable: true),
                    Endereco_Cidade = table.Column<string>(maxLength: 100, nullable: true),
                    Endereco_Estado = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 300, nullable: true),
                    Telefone = table.Column<string>(maxLength: 14, nullable: true),
                    OutrosContatos = table.Column<string>(maxLength: 300, nullable: true),
                    UrlImagem = table.Column<string>(maxLength: 500, nullable: true),
                    CacccId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bazar", x => x.BazarId);
                    table.ForeignKey(
                        name: "FK_Bazar_Caccc_CacccId",
                        column: x => x.CacccId,
                        principalSchema: "DoacaoMais",
                        principalTable: "Caccc",
                        principalColumn: "CacccId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Boletim",
                schema: "DoacaoMais",
                columns: table => new
                {
                    BoletimId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    IdentificadorUnico = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(maxLength: 150, nullable: true),
                    Descricao = table.Column<string>(maxLength: 3500, nullable: true),
                    LinkWeb = table.Column<string>(maxLength: 1000, nullable: true),
                    DataInicial = table.Column<DateTime>(nullable: true),
                    DataFinal = table.Column<DateTime>(nullable: true),
                    UrlImagem = table.Column<string>(maxLength: 300, nullable: true),
                    Ativa = table.Column<bool>(nullable: false),
                    tipoCampanha = table.Column<int>(nullable: false),
                    CacccId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boletim", x => x.BoletimId);
                    table.ForeignKey(
                        name: "FK_Boletim_Caccc_CacccId",
                        column: x => x.CacccId,
                        principalSchema: "DoacaoMais",
                        principalTable: "Caccc",
                        principalColumn: "CacccId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContaBancaria",
                schema: "DoacaoMais",
                columns: table => new
                {
                    ContaBancariaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    IdentificadorUnico = table.Column<string>(nullable: true),
                    NumeroBanco = table.Column<string>(nullable: true),
                    NomeBanco = table.Column<string>(nullable: true),
                    Agencia = table.Column<string>(nullable: true),
                    Conta = table.Column<string>(nullable: true),
                    Beneficiario = table.Column<string>(nullable: true),
                    UrlImagem = table.Column<string>(nullable: true),
                    CacccId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaBancaria", x => x.ContaBancariaId);
                    table.ForeignKey(
                        name: "FK_ContaBancaria_Caccc_CacccId",
                        column: x => x.CacccId,
                        principalSchema: "DoacaoMais",
                        principalTable: "Caccc",
                        principalColumn: "CacccId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Conteudo",
                schema: "DoacaoMais",
                columns: table => new
                {
                    ConteudoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    IdentificadorUnico = table.Column<string>(nullable: true),
                    Titulo = table.Column<string>(maxLength: 150, nullable: true),
                    Subtitulo = table.Column<string>(maxLength: 250, nullable: true),
                    Coluna = table.Column<string>(maxLength: 4000, nullable: true),
                    Url = table.Column<string>(maxLength: 500, nullable: true),
                    CacccId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conteudo", x => x.ConteudoId);
                    table.ForeignKey(
                        name: "FK_Conteudo_Caccc_CacccId",
                        column: x => x.CacccId,
                        principalSchema: "DoacaoMais",
                        principalTable: "Caccc",
                        principalColumn: "CacccId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Noticia",
                schema: "DoacaoMais",
                columns: table => new
                {
                    NoticiaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    IdentificadorUnico = table.Column<string>(nullable: true),
                    Titulo = table.Column<string>(maxLength: 300, nullable: true),
                    SubTitulo = table.Column<string>(maxLength: 300, nullable: true),
                    Conteudo = table.Column<string>(maxLength: 8000, nullable: true),
                    UrlImagem = table.Column<string>(maxLength: 500, nullable: true),
                    DataPublicacao = table.Column<DateTime>(nullable: true),
                    CacccId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noticia", x => x.NoticiaId);
                    table.ForeignKey(
                        name: "FK_Noticia_Caccc_CacccId",
                        column: x => x.CacccId,
                        principalSchema: "DoacaoMais",
                        principalTable: "Caccc",
                        principalColumn: "CacccId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                schema: "DoacaoMais",
                columns: table => new
                {
                    PacienteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    IdentificadorUnico = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(maxLength: 150, nullable: true),
                    Idade = table.Column<int>(nullable: true),
                    Enfermidade = table.Column<string>(maxLength: 45, nullable: true),
                    UrlImagem = table.Column<string>(maxLength: 300, nullable: true),
                    CacccId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.PacienteId);
                    table.ForeignKey(
                        name: "FK_Paciente_Caccc_CacccId",
                        column: x => x.CacccId,
                        principalSchema: "DoacaoMais",
                        principalTable: "Caccc",
                        principalColumn: "CacccId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dispositivo",
                schema: "DoacaoMais",
                columns: table => new
                {
                    DispositivoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    IdentificadorUnico = table.Column<string>(nullable: true),
                    DeviceId = table.Column<string>(maxLength: 150, nullable: true),
                    Release = table.Column<string>(maxLength: 150, nullable: true),
                    Incremental = table.Column<string>(maxLength: 150, nullable: true),
                    VersaoSDK = table.Column<string>(maxLength: 150, nullable: true),
                    FirgirPrint = table.Column<string>(maxLength: 150, nullable: true),
                    Board = table.Column<string>(maxLength: 150, nullable: true),
                    Brand = table.Column<string>(maxLength: 150, nullable: true),
                    Device = table.Column<string>(maxLength: 150, nullable: true),
                    Manufacture = table.Column<string>(maxLength: 150, nullable: true),
                    Model = table.Column<string>(maxLength: 150, nullable: true),
                    Host = table.Column<string>(maxLength: 150, nullable: true),
                    Code = table.Column<string>(maxLength: 150, nullable: true),
                    Type = table.Column<string>(maxLength: 150, nullable: true),
                    Serial = table.Column<string>(maxLength: 150, nullable: true),
                    UsuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dispositivo", x => x.DispositivoId);
                    table.ForeignKey(
                        name: "FK_Dispositivo_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalSchema: "DoacaoMais",
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notificacao",
                schema: "DoacaoMais",
                columns: table => new
                {
                    NotificacaoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    IdentificadorUnico = table.Column<string>(nullable: true),
                    Titulo = table.Column<string>(maxLength: 150, nullable: true),
                    Descricao = table.Column<string>(maxLength: 500, nullable: true),
                    Conteudo = table.Column<string>(maxLength: 3500, nullable: true),
                    DataInicial = table.Column<DateTime>(nullable: true),
                    DataFinal = table.Column<DateTime>(nullable: true),
                    Ativa = table.Column<bool>(nullable: false),
                    BoletimId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificacao", x => x.NotificacaoId);
                    table.ForeignKey(
                        name: "FK_Notificacao_Boletim_BoletimId",
                        column: x => x.BoletimId,
                        principalSchema: "DoacaoMais",
                        principalTable: "Boletim",
                        principalColumn: "BoletimId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NotificacaoDispositivo",
                schema: "DoacaoMais",
                columns: table => new
                {
                    DispositivoId = table.Column<int>(nullable: false),
                    NotificacaoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificacaoDispositivo", x => new { x.NotificacaoId, x.DispositivoId });
                    table.ForeignKey(
                        name: "FK_NotificacaoDispositivo_Dispositivo_DispositivoId",
                        column: x => x.DispositivoId,
                        principalSchema: "DoacaoMais",
                        principalTable: "Dispositivo",
                        principalColumn: "DispositivoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotificacaoDispositivo_Notificacao_NotificacaoId",
                        column: x => x.NotificacaoId,
                        principalSchema: "DoacaoMais",
                        principalTable: "Notificacao",
                        principalColumn: "NotificacaoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bazar_CacccId",
                schema: "DoacaoMais",
                table: "Bazar",
                column: "CacccId");

            migrationBuilder.CreateIndex(
                name: "IX_Boletim_CacccId",
                schema: "DoacaoMais",
                table: "Boletim",
                column: "CacccId");

            migrationBuilder.CreateIndex(
                name: "IX_ContaBancaria_CacccId",
                schema: "DoacaoMais",
                table: "ContaBancaria",
                column: "CacccId");

            migrationBuilder.CreateIndex(
                name: "IX_Conteudo_CacccId",
                schema: "DoacaoMais",
                table: "Conteudo",
                column: "CacccId");

            migrationBuilder.CreateIndex(
                name: "IX_Dispositivo_UsuarioId",
                schema: "DoacaoMais",
                table: "Dispositivo",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Noticia_CacccId",
                schema: "DoacaoMais",
                table: "Noticia",
                column: "CacccId");

            migrationBuilder.CreateIndex(
                name: "IX_Notificacao_BoletimId",
                schema: "DoacaoMais",
                table: "Notificacao",
                column: "BoletimId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificacaoDispositivo_DispositivoId",
                schema: "DoacaoMais",
                table: "NotificacaoDispositivo",
                column: "DispositivoId");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_CacccId",
                schema: "DoacaoMais",
                table: "Paciente",
                column: "CacccId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bazar",
                schema: "DoacaoMais");

            migrationBuilder.DropTable(
                name: "ContaBancaria",
                schema: "DoacaoMais");

            migrationBuilder.DropTable(
                name: "Conteudo",
                schema: "DoacaoMais");

            migrationBuilder.DropTable(
                name: "Noticia",
                schema: "DoacaoMais");

            migrationBuilder.DropTable(
                name: "NotificacaoDispositivo",
                schema: "DoacaoMais");

            migrationBuilder.DropTable(
                name: "Paciente",
                schema: "DoacaoMais");

            migrationBuilder.DropTable(
                name: "Dispositivo",
                schema: "DoacaoMais");

            migrationBuilder.DropTable(
                name: "Notificacao",
                schema: "DoacaoMais");

            migrationBuilder.DropTable(
                name: "Usuario",
                schema: "DoacaoMais");

            migrationBuilder.DropTable(
                name: "Boletim",
                schema: "DoacaoMais");

            migrationBuilder.DropTable(
                name: "Caccc",
                schema: "DoacaoMais");
        }
    }
}
