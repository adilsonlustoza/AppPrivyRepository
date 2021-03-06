USE [MeusProjetosCore]
GO
ALTER TABLE [Security].[UserToken] DROP CONSTRAINT [FK_UserToken_User_UserId]
GO
ALTER TABLE [Security].[UserRole] DROP CONSTRAINT [FK_UserRole_User_UserId]
GO
ALTER TABLE [Security].[UserRole] DROP CONSTRAINT [FK_UserRole_Role_RoleId]
GO
ALTER TABLE [Security].[UserLogin] DROP CONSTRAINT [FK_UserLogin_User_UserId]
GO
ALTER TABLE [Security].[UserClaim] DROP CONSTRAINT [FK_UserClaim_User_UserId]
GO
ALTER TABLE [Security].[RoleClaim] DROP CONSTRAINT [FK_RoleClaim_Role_RoleId]
GO
ALTER TABLE [DoacaoMais].[Paciente] DROP CONSTRAINT [FK_Paciente_Caccc_CacccId]
GO
ALTER TABLE [DoacaoMais].[NotificacaoDispositivo] DROP CONSTRAINT [FK_NotificacaoDispositivo_Notificacao_NotificacaoId]
GO
ALTER TABLE [DoacaoMais].[NotificacaoDispositivo] DROP CONSTRAINT [FK_NotificacaoDispositivo_Dispositivo_DispositivoId]
GO
ALTER TABLE [DoacaoMais].[Notificacao] DROP CONSTRAINT [FK_Notificacao_Boletim_BoletimId]
GO
ALTER TABLE [DoacaoMais].[Noticia] DROP CONSTRAINT [FK_Noticia_Caccc_CacccId]
GO
ALTER TABLE [DoacaoMais].[Dispositivo] DROP CONSTRAINT [FK_Dispositivo_Usuario_UsuarioId]
GO
ALTER TABLE [DoacaoMais].[Conteudo] DROP CONSTRAINT [FK_Conteudo_Caccc_CacccId]
GO
ALTER TABLE [DoacaoMais].[ContaBancaria] DROP CONSTRAINT [FK_ContaBancaria_Caccc_CacccId]
GO
ALTER TABLE [DoacaoMais].[Boletim] DROP CONSTRAINT [FK_Boletim_Caccc_CacccId]
GO
ALTER TABLE [DoacaoMais].[Bazar] DROP CONSTRAINT [FK_Bazar_Caccc_CacccId]
GO
/****** Object:  Table [Site].[Pesquisa]    Script Date: 25/07/2020 17:46:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Site].[Pesquisa]') AND type in (N'U'))
DROP TABLE [Site].[Pesquisa]
GO
/****** Object:  Table [Security].[UserToken]    Script Date: 25/07/2020 17:46:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Security].[UserToken]') AND type in (N'U'))
DROP TABLE [Security].[UserToken]
GO
/****** Object:  Table [Security].[UserRole]    Script Date: 25/07/2020 17:46:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Security].[UserRole]') AND type in (N'U'))
DROP TABLE [Security].[UserRole]
GO
/****** Object:  Table [Security].[UserLogin]    Script Date: 25/07/2020 17:46:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Security].[UserLogin]') AND type in (N'U'))
DROP TABLE [Security].[UserLogin]
GO
/****** Object:  Table [Security].[UserClaim]    Script Date: 25/07/2020 17:46:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Security].[UserClaim]') AND type in (N'U'))
DROP TABLE [Security].[UserClaim]
GO
/****** Object:  Table [Security].[User]    Script Date: 25/07/2020 17:46:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Security].[User]') AND type in (N'U'))
DROP TABLE [Security].[User]
GO
/****** Object:  Table [Security].[RoleClaim]    Script Date: 25/07/2020 17:46:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Security].[RoleClaim]') AND type in (N'U'))
DROP TABLE [Security].[RoleClaim]
GO
/****** Object:  Table [Security].[Role]    Script Date: 25/07/2020 17:46:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Security].[Role]') AND type in (N'U'))
DROP TABLE [Security].[Role]
GO
/****** Object:  Table [DoacaoMais].[Usuario]    Script Date: 25/07/2020 17:46:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[DoacaoMais].[Usuario]') AND type in (N'U'))
DROP TABLE [DoacaoMais].[Usuario]
GO
/****** Object:  Table [DoacaoMais].[Paciente]    Script Date: 25/07/2020 17:46:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[DoacaoMais].[Paciente]') AND type in (N'U'))
DROP TABLE [DoacaoMais].[Paciente]
GO
/****** Object:  Table [DoacaoMais].[NotificacaoDispositivo]    Script Date: 25/07/2020 17:46:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[DoacaoMais].[NotificacaoDispositivo]') AND type in (N'U'))
DROP TABLE [DoacaoMais].[NotificacaoDispositivo]
GO
/****** Object:  Table [DoacaoMais].[Notificacao]    Script Date: 25/07/2020 17:46:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[DoacaoMais].[Notificacao]') AND type in (N'U'))
DROP TABLE [DoacaoMais].[Notificacao]
GO
/****** Object:  Table [DoacaoMais].[Noticia]    Script Date: 25/07/2020 17:46:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[DoacaoMais].[Noticia]') AND type in (N'U'))
DROP TABLE [DoacaoMais].[Noticia]
GO
/****** Object:  Table [DoacaoMais].[Dispositivo]    Script Date: 25/07/2020 17:46:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[DoacaoMais].[Dispositivo]') AND type in (N'U'))
DROP TABLE [DoacaoMais].[Dispositivo]
GO
/****** Object:  Table [DoacaoMais].[Conteudo]    Script Date: 25/07/2020 17:46:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[DoacaoMais].[Conteudo]') AND type in (N'U'))
DROP TABLE [DoacaoMais].[Conteudo]
GO
/****** Object:  Table [DoacaoMais].[ContaBancaria]    Script Date: 25/07/2020 17:46:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[DoacaoMais].[ContaBancaria]') AND type in (N'U'))
DROP TABLE [DoacaoMais].[ContaBancaria]
GO
/****** Object:  Table [DoacaoMais].[Caccc]    Script Date: 25/07/2020 17:46:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[DoacaoMais].[Caccc]') AND type in (N'U'))
DROP TABLE [DoacaoMais].[Caccc]
GO
/****** Object:  Table [DoacaoMais].[Boletim]    Script Date: 25/07/2020 17:46:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[DoacaoMais].[Boletim]') AND type in (N'U'))
DROP TABLE [DoacaoMais].[Boletim]
GO
/****** Object:  Table [DoacaoMais].[Bazar]    Script Date: 25/07/2020 17:46:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[DoacaoMais].[Bazar]') AND type in (N'U'))
DROP TABLE [DoacaoMais].[Bazar]
GO
/****** Object:  Table [DoacaoMais].[Bazar]    Script Date: 25/07/2020 17:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [DoacaoMais].[Bazar](
	[BazarId] [int] IDENTITY(1,1) NOT NULL,
	[DataCadastro] [datetime2](7) NULL,
	[IdentificadorUnico] [nvarchar](max) NULL,
	[Nome] [nvarchar](150) NULL,
	[Informacao] [nvarchar](250) NULL,
	[Endereco_Cep] [nvarchar](10) NULL,
	[Endereco_Logradouro] [nvarchar](150) NULL,
	[Endereco_Numero] [nvarchar](10) NULL,
	[Endereco_Longitude] [float] NULL,
	[Endereco_Latitude] [float] NULL,
	[Endereco_Bairro] [nvarchar](50) NULL,
	[Endereco_Cidade] [nvarchar](100) NULL,
	[Endereco_Estado] [nvarchar](50) NULL,
	[Email] [nvarchar](300) NULL,
	[Telefone] [nvarchar](14) NULL,
	[OutrosContatos] [nvarchar](300) NULL,
	[UrlImagem] [nvarchar](500) NULL,
	[CacccId] [int] NOT NULL,
 CONSTRAINT [PK_Bazar] PRIMARY KEY CLUSTERED 
(
	[BazarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [DoacaoMais].[Boletim]    Script Date: 25/07/2020 17:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [DoacaoMais].[Boletim](
	[BoletimId] [int] IDENTITY(1,1) NOT NULL,
	[DataCadastro] [datetime2](7) NULL,
	[IdentificadorUnico] [nvarchar](max) NULL,
	[Nome] [nvarchar](150) NULL,
	[Descricao] [nvarchar](3500) NULL,
	[LinkWeb] [nvarchar](1000) NULL,
	[DataInicial] [datetime2](7) NULL,
	[DataFinal] [datetime2](7) NULL,
	[UrlImagem] [nvarchar](300) NULL,
	[Ativa] [bit] NOT NULL,
	[tipoCampanha] [int] NOT NULL,
	[CacccId] [int] NOT NULL,
 CONSTRAINT [PK_Boletim] PRIMARY KEY CLUSTERED 
(
	[BoletimId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [DoacaoMais].[Caccc]    Script Date: 25/07/2020 17:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [DoacaoMais].[Caccc](
	[CacccId] [int] IDENTITY(1,1) NOT NULL,
	[DataCadastro] [datetime2](7) NULL,
	[IdentificadorUnico] [nvarchar](max) NULL,
	[Nome] [nvarchar](150) NULL,
	[Apelido] [nvarchar](150) NULL,
	[Cnpj] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[EmailPagSeguro] [nvarchar](max) NULL,
	[EmailPayPal] [nvarchar](max) NULL,
	[UrlImagem] [nvarchar](500) NULL,
	[Telefone] [nvarchar](15) NULL,
	[Celular] [nvarchar](15) NULL,
	[Autorizado] [bit] NOT NULL,
	[Responsavel] [nvarchar](50) NULL,
	[DataFundacao] [datetime2](7) NULL,
	[TipoDoacao] [int] NOT NULL,
	[Endereco_Cep] [nvarchar](10) NULL,
	[Endereco_Logradouro] [nvarchar](150) NULL,
	[Endereco_Numero] [nvarchar](10) NULL,
	[Endereco_Longitude] [float] NULL,
	[Endereco_Latitude] [float] NULL,
	[Endereco_Bairro] [nvarchar](50) NULL,
	[Endereco_Cidade] [nvarchar](100) NULL,
	[Endereco_Estado] [nvarchar](50) NULL,
 CONSTRAINT [PK_Caccc] PRIMARY KEY CLUSTERED 
(
	[CacccId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [DoacaoMais].[ContaBancaria]    Script Date: 25/07/2020 17:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [DoacaoMais].[ContaBancaria](
	[ContaBancariaId] [int] IDENTITY(1,1) NOT NULL,
	[DataCadastro] [datetime2](7) NULL,
	[IdentificadorUnico] [nvarchar](max) NULL,
	[NumeroBanco] [nvarchar](max) NULL,
	[NomeBanco] [nvarchar](max) NULL,
	[Agencia] [nvarchar](max) NULL,
	[Conta] [nvarchar](max) NULL,
	[Beneficiario] [nvarchar](max) NULL,
	[UrlImagem] [nvarchar](max) NULL,
	[CacccId] [int] NOT NULL,
 CONSTRAINT [PK_ContaBancaria] PRIMARY KEY CLUSTERED 
(
	[ContaBancariaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [DoacaoMais].[Conteudo]    Script Date: 25/07/2020 17:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [DoacaoMais].[Conteudo](
	[ConteudoId] [int] IDENTITY(1,1) NOT NULL,
	[DataCadastro] [datetime2](7) NULL,
	[IdentificadorUnico] [nvarchar](max) NULL,
	[Titulo] [nvarchar](150) NULL,
	[Subtitulo] [nvarchar](250) NULL,
	[Coluna] [nvarchar](4000) NULL,
	[Url] [nvarchar](500) NULL,
	[CacccId] [int] NOT NULL,
 CONSTRAINT [PK_Conteudo] PRIMARY KEY CLUSTERED 
(
	[ConteudoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [DoacaoMais].[Dispositivo]    Script Date: 25/07/2020 17:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [DoacaoMais].[Dispositivo](
	[DispositivoId] [int] IDENTITY(1,1) NOT NULL,
	[DataCadastro] [datetime2](7) NULL,
	[IdentificadorUnico] [nvarchar](max) NULL,
	[DeviceId] [nvarchar](150) NULL,
	[Release] [nvarchar](150) NULL,
	[Incremental] [nvarchar](150) NULL,
	[VersaoSDK] [nvarchar](150) NULL,
	[FirgirPrint] [nvarchar](150) NULL,
	[Board] [nvarchar](150) NULL,
	[Brand] [nvarchar](150) NULL,
	[Device] [nvarchar](150) NULL,
	[Manufacture] [nvarchar](150) NULL,
	[Model] [nvarchar](150) NULL,
	[Host] [nvarchar](150) NULL,
	[Code] [nvarchar](150) NULL,
	[Type] [nvarchar](150) NULL,
	[Serial] [nvarchar](150) NULL,
	[UsuarioId] [int] NULL,
 CONSTRAINT [PK_Dispositivo] PRIMARY KEY CLUSTERED 
(
	[DispositivoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [DoacaoMais].[Noticia]    Script Date: 25/07/2020 17:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [DoacaoMais].[Noticia](
	[NoticiaId] [int] IDENTITY(1,1) NOT NULL,
	[DataCadastro] [datetime2](7) NULL,
	[IdentificadorUnico] [nvarchar](max) NULL,
	[Titulo] [nvarchar](300) NULL,
	[SubTitulo] [nvarchar](300) NULL,
	[Conteudo] [nvarchar](max) NULL,
	[UrlImagem] [nvarchar](500) NULL,
	[DataPublicacao] [datetime2](7) NULL,
	[CacccId] [int] NULL,
 CONSTRAINT [PK_Noticia] PRIMARY KEY CLUSTERED 
(
	[NoticiaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [DoacaoMais].[Notificacao]    Script Date: 25/07/2020 17:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [DoacaoMais].[Notificacao](
	[NotificacaoId] [int] IDENTITY(1,1) NOT NULL,
	[DataCadastro] [datetime2](7) NULL,
	[IdentificadorUnico] [nvarchar](max) NULL,
	[Titulo] [nvarchar](150) NULL,
	[Descricao] [nvarchar](500) NULL,
	[Conteudo] [nvarchar](3500) NULL,
	[DataInicial] [datetime2](7) NULL,
	[DataFinal] [datetime2](7) NULL,
	[Ativa] [bit] NOT NULL,
	[BoletimId] [int] NULL,
 CONSTRAINT [PK_Notificacao] PRIMARY KEY CLUSTERED 
(
	[NotificacaoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [DoacaoMais].[NotificacaoDispositivo]    Script Date: 25/07/2020 17:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [DoacaoMais].[NotificacaoDispositivo](
	[DispositivoId] [int] NOT NULL,
	[NotificacaoId] [int] NOT NULL,
 CONSTRAINT [PK_NotificacaoDispositivo] PRIMARY KEY CLUSTERED 
(
	[NotificacaoId] ASC,
	[DispositivoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [DoacaoMais].[Paciente]    Script Date: 25/07/2020 17:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [DoacaoMais].[Paciente](
	[PacienteId] [int] IDENTITY(1,1) NOT NULL,
	[DataCadastro] [datetime2](7) NULL,
	[IdentificadorUnico] [nvarchar](max) NULL,
	[Nome] [nvarchar](150) NULL,
	[Idade] [int] NULL,
	[Enfermidade] [nvarchar](45) NULL,
	[UrlImagem] [nvarchar](300) NULL,
	[CacccId] [int] NULL,
 CONSTRAINT [PK_Paciente] PRIMARY KEY CLUSTERED 
(
	[PacienteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [DoacaoMais].[Usuario]    Script Date: 25/07/2020 17:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [DoacaoMais].[Usuario](
	[UsuarioId] [int] IDENTITY(1,1) NOT NULL,
	[DataCadastro] [datetime2](7) NULL,
	[IdentificadorUnico] [nvarchar](max) NULL,
	[Login] [nvarchar](150) NULL,
	[Email] [nvarchar](350) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Security].[Role]    Script Date: 25/07/2020 17:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Security].[Role](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [RoleId] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Security].[RoleClaim]    Script Date: 25/07/2020 17:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Security].[RoleClaim](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [RoleClaimPk] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Security].[User]    Script Date: 25/07/2020 17:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Security].[User](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [UserId] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Security].[UserClaim]    Script Date: 25/07/2020 17:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Security].[UserClaim](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [UserClaimPk] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Security].[UserLogin]    Script Date: 25/07/2020 17:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Security].[UserLogin](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NULL,
	[ProviderKey] [nvarchar](128) NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
 CONSTRAINT [UserLoginPk] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Security].[UserRole]    Script Date: 25/07/2020 17:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Security].[UserRole](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [UserRolePk] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Security].[UserToken]    Script Date: 25/07/2020 17:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Security].[UserToken](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NULL,
	[Name] [nvarchar](128) NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [UserTokenPk] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Site].[Pesquisa]    Script Date: 25/07/2020 17:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Site].[Pesquisa](
	[PesquisaId] [int] IDENTITY(1,1) NOT NULL,
	[DataCadastro] [datetime2](7) NULL,
	[IdentificadorUnico] [nvarchar](max) NULL,
	[Titulo] [nvarchar](150) NOT NULL,
	[Descricao] [nvarchar](1500) NOT NULL,
	[Url] [nvarchar](500) NOT NULL,
	[Image] [varbinary](max) NULL,
 CONSTRAINT [PK_Pesquisa] PRIMARY KEY CLUSTERED 
(
	[PesquisaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


-------------------------------------------------INSERT SITE-------------------------------------------------
SET IDENTITY_INSERT [SITE].[Pesquisa] ON

INSERT [SITE].[Pesquisa] ([PesquisaId], [Titulo], [Descricao], [Url], [Image], [DataCadastro], [IdentificadorUnico]) VALUES (1, N'Android', N'O Android é um software para celulares, tablets e uma gama crescente de dispositivos abrangendo tudo, desde computação portátil até entretenimento para carros. Foi lançado em 2003 e é o sistema operacional móvel (SO) mais popular do mundo.', N'/Analista/Programador/Android', NULL, CAST(N'2019-06-30T10:35:34.333' AS DateTime), N'525d525c-fd0c-4d72-9f3f-2c2376d5520f')
INSERT [SITE].[Pesquisa] ([PesquisaId], [Titulo], [Descricao], [Url], [Image], [DataCadastro], [IdentificadorUnico]) VALUES (2, N'Engenharia de Software', N'Engenharia de Software é uma área da computação voltada à especificação, relações humanas, metodologias, liderança, boas práticas, mantenabilidade, gestão de projetos e arquitetura.', N'/Analista/Programador/EngenhariaDeSoftware', NULL, CAST(N'2019-06-30T10:35:34.350' AS DateTime), N'd615e1c1-2966-4002-a1ac-0d42a2c50609')
INSERT [Site].[Pesquisa] ([PesquisaId], [Titulo], [Descricao], [Url], [Image], [DataCadastro], [IdentificadorUnico]) VALUES (3, N'Sistema Web', N'Também conhecido como aplicação web, um sistema web provê funcionalidades para a manutenção do negócio da empresa, e deve ser considerado na automatização de processos.', N'/Analista/Programador/SistemasWeb', NULL, CAST(N'2019-06-30T10:35:34.350' AS DateTime), N'8dcd357a-adfb-4fb6-b0a3-096216eb8c90')

SET IDENTITY_INSERT [SITE].[Pesquisa] OFF

SET IDENTITY_INSERT [DoacaoMais].[Bazar] ON 
-------------------------------------------------INSERT DOACAO MAIS-------------------------------------------------
INSERT [DoacaoMais].[Bazar] ([BazarId], [Nome], [Informacao], [Endereco_Cep], [Endereco_Logradouro], [Endereco_Numero], [Endereco_Longitude], [Endereco_Latitude], [Endereco_Bairro], [Endereco_Cidade], [Endereco_Estado], [Email], [Telefone], [OutrosContatos], [UrlImagem], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (1, N'BAZAR BENEFICENTE', N'Funcionamento todos os dias das 10 as 17hs', N'00000-000', N'Rua Miguel Gonçalves Correa', N'308', -46.7724721, -23.6357489, N'Vila Pirajussara, Campo Limpo', N'São Paulo', N'SP', NULL, NULL, NULL, N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/bazar01_img01_caccc.jpg', 1, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'2e53df65-f513-4e27-8475-e2507cdb7990')
INSERT [DoacaoMais].[Bazar] ([BazarId], [Nome], [Informacao], [Endereco_Cep], [Endereco_Logradouro], [Endereco_Numero], [Endereco_Longitude], [Endereco_Latitude], [Endereco_Bairro], [Endereco_Cidade], [Endereco_Estado], [Email], [Telefone], [OutrosContatos], [UrlImagem], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (2, N'ASSOCIAÇÃO INTERNACIONAL DE INTERESSE A HUMANIDADE', N'Realizamos este bazar uma vez por mês', N'00000-000', N'Av. Rudge Ramos', N'545', -46.794212, -23.6629043, N'Jd. Irene ', N'São Paulo', N'SP', NULL, NULL, NULL, N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/bazar02_img01_caccc.jpg', 1, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'95c4ef10-1ebf-470c-8e2e-397ddde4ba33')
INSERT [DoacaoMais].[Bazar] ([BazarId], [Nome], [Informacao], [Endereco_Cep], [Endereco_Logradouro], [Endereco_Numero], [Endereco_Longitude], [Endereco_Latitude], [Endereco_Bairro], [Endereco_Cidade], [Endereco_Estado], [Email], [Telefone], [OutrosContatos], [UrlImagem], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (3, N'BAZAR BENEFICENTE', N'Funcionamento todos os dias das 9 as 17hs', N'00000-000', N'Rua Nicolau Ávila', N'45', -46.7724721, -23.6357489, N'Vila Pirajussara, Campo Limpo', N'São Paulo', N'SP', NULL, NULL, NULL, N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/bazar03_img01_caccc.jpg', 1, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'6fb2ed41-d92d-4b3e-a97e-060357e1c270')
INSERT [DoacaoMais].[Bazar] ([BazarId], [Nome], [Informacao], [Endereco_Cep], [Endereco_Logradouro], [Endereco_Numero], [Endereco_Longitude], [Endereco_Latitude], [Endereco_Bairro], [Endereco_Cidade], [Endereco_Estado], [Email], [Telefone], [OutrosContatos], [UrlImagem], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (4, N'Bazar Beneficente Permanente', N'Localizado na Sede da AACC', N'00000-000', N'Rua Borges Lagoa', N'1603', -46.6523728, -23.5964588, N'Vila Clementino', N'São Paulo', N'SP', NULL, NULL, NULL, N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_marca_aacc.jpg', 2, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'047d646d-382c-4f8b-9fad-538436b4df84')
INSERT [DoacaoMais].[Bazar] ([BazarId], [Nome], [Informacao], [Endereco_Cep], [Endereco_Logradouro], [Endereco_Numero], [Endereco_Longitude], [Endereco_Latitude], [Endereco_Bairro], [Endereco_Cidade], [Endereco_Estado], [Email], [Telefone], [OutrosContatos], [UrlImagem], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (5, N'Casa Maria Helena Paulina - Bazar no Taboão da Serra - ', N'Funcionamento: De segunda a sexta : das 9hrs - 18hrs Sábados: das 9hrs - 15hrs', N'06784-380', N'R. Fideralina Gomes  de Almeida', N'324', -46.7974825, -23.6355219, N'Jd. Record', N'Taboão da Serra', N'SP', NULL, NULL, NULL, N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/bazar_cmhp.png', 6, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'd45caf5f-d307-4035-81dc-29e9f56ad06f')
INSERT [DoacaoMais].[Bazar] ([BazarId], [Nome], [Informacao], [Endereco_Cep], [Endereco_Logradouro], [Endereco_Numero], [Endereco_Longitude], [Endereco_Latitude], [Endereco_Bairro], [Endereco_Cidade], [Endereco_Estado], [Email], [Telefone], [OutrosContatos], [UrlImagem], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (6, N'BAZAR FIXO CAVD (1)', N'Funcionamento: De segunda a sexta : das 9hrs - 18hrs Sábados: das 9hrs - 16hrs', N'00000-000', N'Rua Martinho de Sousa', N'207', -46.4750445, -23.5030268, N'Ermelino Matarazzo', N'São Paulo', N'SP', NULL, NULL, NULL, N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_cavd.png', 7, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'e890d35e-3d36-49a3-a5c8-a5b3447e186e')
INSERT [DoacaoMais].[Bazar] ([BazarId], [Nome], [Informacao], [Endereco_Cep], [Endereco_Logradouro], [Endereco_Numero], [Endereco_Longitude], [Endereco_Latitude], [Endereco_Bairro], [Endereco_Cidade], [Endereco_Estado], [Email], [Telefone], [OutrosContatos], [UrlImagem], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (7, N'BAZAR FIXO CAVD (2)', N'Funcionamento: De segunda a sexta : das 9hrs - 18hrs Sábados: das 9hrs - 16hrs', N'00000-000', N'Avenida Paranaguá', N'378', -46.4760628, -23.5026042, N'Ermelino Matarazzo', N'São Paulo', N'SP', NULL, NULL, NULL, N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_cavd.png', 7, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'bae44a1c-56a7-4379-a583-f01147c56f08')
INSERT [DoacaoMais].[Bazar] ([BazarId], [Nome], [Informacao], [Endereco_Cep], [Endereco_Logradouro], [Endereco_Numero], [Endereco_Longitude], [Endereco_Latitude], [Endereco_Bairro], [Endereco_Cidade], [Endereco_Estado], [Email], [Telefone], [OutrosContatos], [UrlImagem], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (8, N'BAZAR FIXO CAVD (3)', N'Funcionamento: De segunda a sexta : das 9hrs - 18hrs Sábados: das 9hrs - 16hrs', N'00000-000', N'Rua Maraial ', N'358', -46.4760628, -23.5026042, N'Jardim Nordeste', N'São Paulo', N'SP', NULL, NULL, NULL, N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_cavd.png', 7, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'c6307319-b1e3-40d8-a5a9-5d744847d413')


SET IDENTITY_INSERT [DoacaoMais].[Bazar] OFF
SET IDENTITY_INSERT [DoacaoMais].[Boletim] ON 

INSERT [DoacaoMais].[Boletim] ([BoletimId], [Nome], [Descricao], [LinkWeb], [DataInicial], [DataFinal], [UrlImagem], [Ativa], [tipoCampanha], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (1, N'Prestes a ser fechada', N'<p>A CASA do Centro de Apoio C&acirc;ndida Bermejo Camargo est&aacute; prestes a ser leiloada e fechada.</p>

                                                            <p>A possibilidade de perder esse trabalhoque acabou de completar 18 anos em 2017 &eacute; eminente e N&Atilde;O podemos deixar nossas dezenas crian&ccedil;as e seus acompanhantes desamparados dos nossos cuidados e sem moradia.</p>

                                                            <p>Nesses 18 anos, s&oacute; n&oacute;s sabemos o qu&atilde;o dif&iacute;cil foi a nossa trajet&oacute;ria para caminhar de acordo com todas as leis que envolvem o terceiro setor e as crian&ccedil;as.</p>

                                                            <p> Sempre zelamos pela transpar&ecirc;ncia e regularidade do nosso trabalho, mas infelizmente, nem todas as pessoas conseguem enxergar a beleza e sinceridade no nosso trabalho e conseguiram nos prejudicar.</p>

                                                            <p>POR FAVOR,entre nessa corrente do bem, nos ajude arrecadar o valor para recuperar a Casa de Apoio e manter o trabalho em prol das mais de 700 crian&ccedil;as carentes com c&acirc;ncer que j&aacute; foram atendidas ao longo desses 18 anos de CBC.</p>

                                <p>E ajude as dezenas das crian&ccedil;as carentes com c&acirc;nce seus acompanhantes a continuarem o seu tratamento conosco.</p>', NULL, NULL, NULL, N'http://doacaomais.adilsonlustoza.com.br/Arquivos/DoacaoMais/Imagens/noticia_caccc_eliana.webp', 0, 1, 1, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'5d17af7b-f6f5-4cc6-8ba8-2d2274da2e6c')
INSERT [DoacaoMais].[Boletim] ([BoletimId], [Nome], [Descricao], [LinkWeb], [DataInicial], [DataFinal], [UrlImagem], [Ativa], [tipoCampanha], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (2, N'AACC em Construindo o Futuro', N'<p align=''justify''>As forma&ccedil;&otilde;es ter&atilde;o dura&ccedil;&atilde;o de um ano e incluem &aacute;reas como planejamento estrat&eacute;gico, gest&atilde;o de projetos, capta&ccedil;&atilde;o de recursos, jur&iacute;dico financeiro, comunica&ccedil;&atilde;o e advocacy. Durante as forma&ccedil;&otilde;es, atrav&eacute;s de encontros presenciais e online, os participantes ter&atilde;o a oportunidade de refletir suas pr&aacute;ticas organizacionais e planejar cen&aacute;rios para suas atividades a curto, m&eacute;dio e longo prazo, de forma a criar melhores possibilidades de futuro para as comunidades em que atuam, com foco na expans&atilde;o de impacto e na melhoria da qualidade do servi&ccedil;o prestado. O projeto conta tamb&eacute;m com consultorias estrat&eacute;gicas para que cada Organiza&ccedil;&atilde;o beneficiada possa desenvolver sua pr&oacute;pria Teoria de Mudan&ccedil;a e um Plano de Monitoramento e Avalia&ccedil;&atilde;o de suas atividades e resultados&rdquo;, informa os idealizadores do projeto, Instituto Esp&iacute;rita de Educa&ccedil;&atilde;o. <br /> O projeto conta tamb&eacute;m com consultorias estrat&eacute;gicas para que cada Organiza&ccedil;&atilde;o beneficiada possa desenvolver sua pr&oacute;pria Teoria de Mudan&ccedil;a e um Plano de Monitoramento e Avalia&ccedil;&atilde;o de suas atividades e resultados. <br /> Ainda, com o intuito de assegurar o desenvolvimento significativo e alinhado de cada organiza&ccedil;&atilde;o de acordo as tem&aacute;ticas das capacita&ccedil;&otilde;es e consultorias, o Construindo o Futuro promover&aacute; 4 desafios no decorrer do projeto&rdquo;, completam.</p>.', N'@/Arquivos/Imagens/DoacaoMais/visite.jpg', NULL, NULL, N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/proj_constr_final.png', 0, 1, 2, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'9dca82ee-b158-4d49-8e9d-1ab28fb05e00')
INSERT [DoacaoMais].[Boletim] ([BoletimId], [Nome], [Descricao], [LinkWeb], [DataInicial], [DataFinal], [UrlImagem], [Ativa], [tipoCampanha], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (3, N'Apoio Psicológico', N'<p>O apoio psicol&amp;oacute;gico oferecido pela AACC visa proporcionar a interven&amp;ccedil;&amp;atilde;o psicol&amp;oacute;gica para a crian&amp;ccedil;a com c&amp;acirc;ncer e seus familiares na Casa de Apoio da AACC, para oferecer um espa&amp;ccedil;o para que sejam acolhidos desde sua chegada e durante o per&amp;iacute;odo de perman&amp;ecirc;ncia na institui&amp;ccedil;&amp;atilde;o.</p>

                            <p>Com isso se pretende melhorar a qualidade de vida, minimizar a ang&amp;uacute;stia frente &amp;agrave;s poss&amp;iacute;veis mudan&amp;ccedil;as f&amp;iacute;sicas e psicol&amp;oacute;gicas, transmitir informa&amp;ccedil;&amp;otilde;es sobre a doen&amp;ccedil;a e seu tratamento, permitindo uma maior ades&amp;atilde;o e implica&amp;ccedil;&amp;atilde;o no tratamento.</p>

                             <p>Muitas vezes o c&amp;acirc;ncer est&amp;aacute; relacionado com dor e sofrimento, al&amp;eacute;m de ser reconhecido como uma doen&amp;ccedil;a potencialmente terminal. Por isso, ao receber o diagn&amp;oacute;stico de c&amp;acirc;ncer, h&amp;aacute; a necessidade de reorganiza&amp;ccedil;&amp;atilde;o de todo o sistema familiar de modo a adaptar &amp;agrave; condi&amp;ccedil;&amp;atilde;o de perda iminente, presta&amp;ccedil;&amp;atilde;o de cuidados e mudan&amp;ccedil;as impostas pela realidade do tratamento do c&amp;acirc;ncer.</p>

                            <p>Por vezes ocorre a mudan&amp;ccedil;a de cidade e consequente distanciamento da fam&amp;iacute;lia, amigos, havendo a interrup&amp;ccedil;&amp;atilde;o de planos futuros, mudan&amp;ccedil;as f&amp;iacute;sicas e ps&amp;iacute;quicas, mudan&amp;ccedil;a no papel social e do estilo de vida. O trabalho desenvolvido pela a AACC considera todos estes aspectos.</p>', NULL, NULL, NULL, N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_marca_aacc.png', 0, 3, 2, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'9467eab9-eb0c-4202-81ca-48b61240cd21')
INSERT [DoacaoMais].[Boletim] ([BoletimId], [Nome], [Descricao], [LinkWeb], [DataInicial], [DataFinal], [UrlImagem], [Ativa], [tipoCampanha], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (4, N'Alojamento', N'<p align=''justify''>O alojamento é a unidade da AACC que oferece ao paciente com câncer e à sua família,  desde o início do tratamento, o suporte bio-psicossocial necessário, que envolve o comprometimento de uma equipe multiprofissional e a relação com  diferentes setores da sociedade envolvidos no apoio às famílias e à saúde de crianças e jovens. Por isso, a AACC organiza diversas atividades que favoreçam o bem-estar dos atendidos para que a qualidade de vida dos usuários seja uma ferramenta a mais no processo de cura, organizando atividades culturais, passeios estratégicos que coloquem as crianças em contato com pessoas que contribuem com as artes e os desportos, a fim de despertar o sentimento e a vontade de crescimento entre elas.</p>', NULL, NULL, NULL, N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_marca_aacc.png', 0, 3, 2, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'693b0877-2287-4b32-8951-47243195168c')
INSERT [DoacaoMais].[Boletim] ([BoletimId], [Nome], [Descricao], [LinkWeb], [DataInicial], [DataFinal], [UrlImagem], [Ativa], [tipoCampanha], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (5, N'Cobertura', N'Enquanto o paciente realiza seu tratamento no hospital ao qual foi encaminhado, o
                                                    CMK oferece hospedagem, que pode se estender por meses, aos pacientes que não tem aonde permanecer durante o período do tratamento.

                                                    A hospedagem consiste em oferecer um ambiente adequado necessário à condição de indivíduos imunodeficientes, isto é, que tenham pouca ou nenhuma imunidade e que na grande maioria das vêzes não irão encontrar essa situação em casa de parentes, visto que falamos de pacientes carentes.

 

                                                    Há um serviço de transporte para que essas crianças sejam levadas ao hospital para exames, tratamento ou avaliações médicas e, alimentação saudável com orientação de uma nutricionista para suprir as necessidades e dificuldades individuais de cada uma das crianças.

                                                    A casa abriga mãe, irmã ou tia do paciente para oferecer um ponto de referência afetivo, fazendo com que a criança se sinta mais segura no ambiente que lhe é desconhecido.Assim também um apoio psicológico para crianças e mães, para que encontrem um equilíbrio e tentem superar a dor de sua condição física e de sofrimento.

 

                                                    Há brinquedoteca, para que tenham lazer em sua permanência na casa e, programação de aulas de culinária, música, palestras de interesse geral e especifico das doenças neoplásicas. Além de terapias e trabalhos manuais com a intenção de aliviar a tensão, oferecendo e criando oportunidade de aprender uma atividade que possa ser útil como sustento no futuro.

                                                    Resumindo, o CMK foi idealizado para que o paciente faça seu tratamento no hospital mas tenha nosso total apoio para que esse seja um sucesso e o que depender de nós que também esses pequenos meninos e meninas jamais carreguem traumas psicológicos referentes a doença durante o período que o acompanharemos.', NULL, NULL, NULL, N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_marca_aacc.png', 0, 3, 3, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'4db0876e-9f6a-480a-99fc-51bd8f43a683')
INSERT [DoacaoMais].[Boletim] ([BoletimId], [Nome], [Descricao], [LinkWeb], [DataInicial], [DataFinal], [UrlImagem], [Ativa], [tipoCampanha], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (6, N'Apoio', N'O CMK oferece vários tipos e formas de apoio a todos que utilizarem nossos serviços, para que todos tenham maior segurança possível na permanência sob nossa administração durante os tratamentos.

                                            Estes apoio é feito por volutários altamente qualificados e atuantes no mercado, que se comprometeram a oferecer seus conhecimentos em cada área específica, em prol dos pacientes.

                                            Hoje o CMK oferece suporte nas seguintes áreas (clique para conhecer cada uma das atuações):

                                Acompanhantes
                                Nutrição
                                Psicológico
                                Médico
                                Jurídico', NULL, NULL, NULL, N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_marca_aacc.png', 0, 3, 3, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'544d0216-d481-4a66-a556-505660255b91')
INSERT [DoacaoMais].[Boletim] ([BoletimId], [Nome], [Descricao], [LinkWeb], [DataInicial], [DataFinal], [UrlImagem], [Ativa], [tipoCampanha], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (7, N'Agradecimentos', N'O CMK agradece imensamente ao Supermercado Hirota-Natal solidário 2017
                                                e aos 4 clientes sorteados, por ter nos indicado doando 1mil reais cada para                 nossa instituição. Agradecemos de coração!!!!!', NULL, NULL, NULL, N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_marca_aacc.png', 0, 5, 3, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'980843c4-d9d2-430a-a9b0-faf36b521419')
INSERT [DoacaoMais].[Boletim] ([BoletimId], [Nome], [Descricao], [LinkWeb], [DataInicial], [DataFinal], [UrlImagem], [Ativa], [tipoCampanha], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (8, N'Doações', N'Aceitamos  roupas, calçados, brinquedos, alimentos, fraldas, material de                      higiene pessoal e limpeza, etc.', NULL, NULL, NULL, N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo-aacc-2.png', 0, 1, 4, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'3c665d07-7483-4029-9059-cdb52a303fc1')
INSERT [DoacaoMais].[Boletim] ([BoletimId], [Nome], [Descricao], [LinkWeb], [DataInicial], [DataFinal], [UrlImagem], [Ativa], [tipoCampanha], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (9, N'TEMOS O APOIO DA RISÜ', N'A CAJEC  Casa Eduardo José Cavichio apoia a Risü. 
                                               Risü: https://www.risu.com.br/', NULL, NULL, NULL, N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/apoio_risu.jpg', 0, 6, 5, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'7f4f1ba0-5acb-4203-a9fb-dc406fbb111f')
INSERT [DoacaoMais].[Boletim] ([BoletimId], [Nome], [Descricao], [LinkWeb], [DataInicial], [DataFinal], [UrlImagem], [Ativa], [tipoCampanha], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (10, N'GABRIELA', N'A história da Gabriela é impressionante, ela chegou na CAJEC ainda bebê, com problemas nos rins. Passou por remédios, muita gente não acreditava na sua recuperação, mas aos poucos ela foi vencendo obstáculos, muito duros até para um adulto, e foi sobrevivendo. Sua mãe biológica a abandonou na Instituição ainda pequena e foi a D.Luiza quem cuidou dela. Hoje, ela é uma adolescente. Seu pequeno porte porém , não condiz com a sua idade e volta e meia ela tem sua saúde testada. Ela se tornou a “mascote “da Instituição. Pura alegria! Recebe as crianças que chegam com a maior desenvoltura e carinho.', NULL, NULL, NULL, N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo-aacc-2.png', 0, 5, 5, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'408cd559-9628-4d49-ab0b-cd0da543271d')
INSERT [DoacaoMais].[Boletim] ([BoletimId], [Nome], [Descricao], [LinkWeb], [DataInicial], [DataFinal], [UrlImagem], [Ativa], [tipoCampanha], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (11, N'Doe um Produto', N'Para mantermos nossas atividades, contamos com a doação de produtos para serem      usados em nossa casa ou vendidos em nosso bazar! 
                                    ​
                                 Simples e fácil: preencha o formulário abaixo e entraremos em contato por email para   confirmar a retirada do produto ou sua entrega diretamente em nossa sede (você pode escolher).  Nós buscamos produtos usados em boas condições, que permitam ser utilizados ou vendidos. Agradecemos imensamente a sua pequena doação! Ela é muito importante para nós!', NULL, NULL, NULL, N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo-aacc-2.png', 0, 1, 6, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'70207bc4-a6ad-490d-8e13-0ea9df909cfb')
INSERT [DoacaoMais].[Boletim] ([BoletimId], [Nome], [Descricao], [LinkWeb], [DataInicial], [DataFinal], [UrlImagem], [Ativa], [tipoCampanha], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (12, N'Seja Voluntário', N'De acordo com o Centro de Voluntariado de São Paulo  Ser voluntário é doar seu tempo, trabalho e talento  para causas de interesse social e comunitário e com isso melhorar a qualidade de vida da comunidade.
                                        Em nossa casa existem diversas formas e oportunidades de participação, você pode ajudar no entretenimento das crianças, organizando passeios ou nos ajudando com trabalho dentro da sua especialidade!', NULL, NULL, NULL, N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo-aacc-2.png', 0, 5, 6, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'558b8e77-9319-4c10-bc7d-e3dc83d2e42e')
INSERT [DoacaoMais].[Boletim] ([BoletimId], [Nome], [Descricao], [LinkWeb], [DataInicial], [DataFinal], [UrlImagem], [Ativa], [tipoCampanha], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (13, N'TERRENO DA SEDE PRÓPRIA / CONTRIBUA', N'A Casa de Apoio Vida Divina já realiza o trabalho de acolhimento de crianças e adolescentes de outros estados há mais de 10 anos e desde então sempre foi em uma sede alugada. Muitas famílias já passaram por aqui e são gratas pelo espaço que tiveram enquanto necessário, também somos gratos pela história que fizemos juntos nessa casa, porém, acreditamos que podemos oferecer mais qualidade e segurança para as nossas crianças.
                                Por este motivo tiramos do papel um sonho que foi muito pensando pela fundadora da casa, Marli Francisca, a construção da sede própria da Casa de Apoio Vida Divina. O objetivo é poder ter espaço para receber mais famílias que precisam vir para São Paulo para cuidarem de suas crianças, além disso oferecer algumas atividades que hoje não é possível na sede atual como aulas em braile, fisioterapia com acompanhamento, atividades pedagógicas e lúdicas, tanto para as crianças quanto para os pais. Hoje já quitamos o valor do terreno onde está sendo construído a sede própria, mais para continuarmos essa história dependemos da sua ajuda, faça uma contribuição, toda ajuda é importante para nós, quem estende a mão para o próximo, abre o coração para o caminho do bem, juntos somos mais fortes.', NULL, NULL, NULL, N'http://www.cavd.org.br/wp-content/uploads/2015/02/site.png', 0, 1, 7, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'fb644825-bc67-4ae7-9969-821c6d551601')
INSERT [DoacaoMais].[Boletim] ([BoletimId], [Nome], [Descricao], [LinkWeb], [DataInicial], [DataFinal], [UrlImagem], [Ativa], [tipoCampanha], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (14, N'A HISTÓRIA CONTINUA', N'Em Set/2014, através das doações mensais - essenciais à CAVD -, conseguimos comprar o terreno onde será levantada a sede própria da Casa de Apoio Vida Divina.
Junto de toda a assistência prestada pela instituição, existem os gastos com produtos e a manutenção. Entretanto, no caso da CAVD, a situação é outra. A entidade ainda não possui uma sede própria, e por isso busca recursos para a construção de seu prédio, que já está em andamento. A todo momento buscamos a captação de recursos financeiros para a construção de nosso local próprio. A princípio arrecadamos fundos para a manutenção do prédio em que estamos instalados (que atualmente é alugado) e o que sobra é investido na obra da nossa sede oficial, que começou em julho de 2015.
Para colher os recursos, a CAVD reúne diversos tipos de eventos. Além disso, rifas esporádicas, boletos de doadores sócio mensalistas e os bazares da instituição complementam a renda da instituição. A Casa de Apoio Vida Divina também tem o Projeto dos Assistidos, onde 15 famílias são cadastradas. Elas geralmente necessitam de algum apoio, desde medicamentos, alimentação ou roupas. O benefício a elas é entregue mensalmente.

                                          ', NULL, NULL, NULL, N'http://www.cavd.org.br/wp-content/uploads/2015/02/site.png', 0, 1, 7, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'2f12c382-eba4-49a6-9c51-010087e5a530')
INSERT [DoacaoMais].[Boletim] ([BoletimId], [Nome], [Descricao], [LinkWeb], [DataInicial], [DataFinal], [UrlImagem], [Ativa], [tipoCampanha], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (15, N'SEJA VOLUNTÁRIO', N'requentemente precisamos de ajuda em atividades, eventos e manutenções na Casa.                 Se quiser ser um voluntário, o processo é simples e de grande valia pra nós.

                                    Hoje você pode ser voluntário na casa de duas formas, se cadastrando aqui no site, preenchendo as informações corretas e quando a instituição realizar ações externas como festas, jantares, bingos ou ações entraremos em contato para verificar a disponibilidade de horário. Você também pode fazer um trabalho voluntário com as crianças da instituição, para isso entre em contato pelo telefone para mais informações.

                                    Somos gratos a todas as equipes que já nos ajudaram diversas vezes, já são mais de 10 anos de trabalho e muitos grupos já tiveram o prazer de fazer um dia mais feliz para as nossas crianças. Se cadastre, em breve entraremos em contato com você!


                                          ', NULL, NULL, NULL, N'http://www.cavd.org.br/wp-content/uploads/2015/02/site.png', 0, 3, 7, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'5e33f77e-1096-4aaf-a38f-6a2bae8c0442')

SET IDENTITY_INSERT [DoacaoMais].[Boletim] OFF
SET IDENTITY_INSERT [DoacaoMais].[Caccc] ON 

INSERT [DoacaoMais].[Caccc] ([CacccId], [Nome], [Apelido], [Cnpj], [Email], [EmailPagSeguro], [EmailPayPal], [UrlImagem], [Telefone], [Celular], [Autorizado], [Responsavel], [DataFundacao], [TipoDoacao], [Endereco_Cep], [Endereco_Logradouro], [Endereco_Numero], [Endereco_Longitude], [Endereco_Latitude], [Endereco_Bairro], [Endereco_Cidade], [Endereco_Estado], [DataCadastro], [IdentificadorUnico]) VALUES (1, N'Cândida Bermejo Camargo', N'Centro CBC', N'03.333.146/0001-47', N'centrocbc@centrocbc.com.br', N'financeiro@grupoanjoazul.com.br', NULL, N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_caccc.png', N'(11)3224-2990', N'(11) 96858-2990', 0, N'', NULL, 2, N'05786-160', N'Miguel Gonçalves Correia', N'157', -46.7713119, -23.6350549, N'Vila Pirajussara, Campo Limpo', N'São Paulo', N'SP', CAST(N'2019-06-30T10:36:03.253' AS DateTime), N'706322f0-5983-4520-98e0-40c3155b7f9b')
INSERT [DoacaoMais].[Caccc] ([CacccId], [Nome], [Apelido], [Cnpj], [Email], [EmailPagSeguro], [EmailPayPal], [UrlImagem], [Telefone], [Celular], [Autorizado], [Responsavel], [DataFundacao], [TipoDoacao], [Endereco_Cep], [Endereco_Logradouro], [Endereco_Numero], [Endereco_Longitude], [Endereco_Latitude], [Endereco_Bairro], [Endereco_Cidade], [Endereco_Estado], [DataCadastro], [IdentificadorUnico]) VALUES (2, N'AACC - Associação de Apoio a Criança com Cancer', N'Associação de Apoio a Criança com Cancer', N'54.963.061/0001-83', N'contato@aacc.org.br', N'doacoesonline@aacc.org.br', N'doacoesonline@aacc.org.br', N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo-aacc.png', N'(11) 5084-5434', NULL, 0, N'', NULL, 4, N'05854-020', N'Rua Borges Lagoa, 1603', N'30', -46.6523728, -23.5964588, N'Vila Clementino', N'São Paulo', N'SP', CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'f9773913-d5eb-4b89-be35-4a65f60b328c')
INSERT [DoacaoMais].[Caccc] ([CacccId], [Nome], [Apelido], [Cnpj], [Email], [EmailPagSeguro], [EmailPayPal], [UrlImagem], [Telefone], [Celular], [Autorizado], [Responsavel], [DataFundacao], [TipoDoacao], [Endereco_Cep], [Endereco_Logradouro], [Endereco_Numero], [Endereco_Longitude], [Endereco_Latitude], [Endereco_Bairro], [Endereco_Cidade], [Endereco_Estado], [DataCadastro], [IdentificadorUnico]) VALUES (3, N'CACC Marta Kuboiama', N'CACC Marta Kuboiama', N'07.882.523/0001-58', N'cmk@cmk.org.br', NULL, NULL, N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_marta_kuboiama.png', N'(11) 5061-1456 ', N'(11) 99900-7979', 0, N'', NULL, 5, N'04158-070', N'RUA JOÃO DE SANTA MARIA', N'320 ', -46.6199603, -23.6205107, N'JARDIM DA SAÚDE', N'São Paulo', N'SP', CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'844aa486-03c8-4a4d-8908-0984c0a9ee68')
INSERT [DoacaoMais].[Caccc] ([CacccId], [Nome], [Apelido], [Cnpj], [Email], [EmailPagSeguro], [EmailPayPal], [UrlImagem], [Telefone], [Celular], [Autorizado], [Responsavel], [DataFundacao], [TipoDoacao], [Endereco_Cep], [Endereco_Logradouro], [Endereco_Numero], [Endereco_Longitude], [Endereco_Latitude], [Endereco_Bairro], [Endereco_Cidade], [Endereco_Estado], [DataCadastro], [IdentificadorUnico]) VALUES (4, N'CAMACC - Casa Modelo de Apoio à Criança com Câncer', N'CAMACC', N'05.500.597/0001-57', N'casamodelo@ig.com.br', NULL, NULL, N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_camacc.png', N'(11) 3739-3859', NULL, 0, N'', NULL, 5, N'05526-000', N'R. Almirante Aristides Guilhem', N'199', -46.7473632, -23.6029461, N'Jd Jussara V Sonia', N'São Paulo', N'SP', CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'0e56f488-10ed-4116-a545-ff80867592c3')
INSERT [DoacaoMais].[Caccc] ([CacccId], [Nome], [Apelido], [Cnpj], [Email], [EmailPagSeguro], [EmailPayPal], [UrlImagem], [Telefone], [Celular], [Autorizado], [Responsavel], [DataFundacao], [TipoDoacao], [Endereco_Cep], [Endereco_Logradouro], [Endereco_Numero], [Endereco_Longitude], [Endereco_Latitude], [Endereco_Bairro], [Endereco_Cidade], [Endereco_Estado], [DataCadastro], [IdentificadorUnico]) VALUES (5, N'CAJEC - Casa José Eduardo Cavichio', N'CAJEC', N'05.500.597/0001-57', N'apoio@cajec.org.br', NULL, NULL, N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_cajec.png', N'(11) 4701-4194', NULL, 0, N'', NULL, 5, N'06756-170', N'Rua Preciosa', N'86', -46.7744426, -23.6010249, N'Parque Monte Alegre', N'Taboão da Serra', N'SP', CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'8bc88748-facd-498d-bcca-ff024ffb958a')
INSERT [DoacaoMais].[Caccc] ([CacccId], [Nome], [Apelido], [Cnpj], [Email], [EmailPagSeguro], [EmailPayPal], [UrlImagem], [Telefone], [Celular], [Autorizado], [Responsavel], [DataFundacao], [TipoDoacao], [Endereco_Cep], [Endereco_Logradouro], [Endereco_Numero], [Endereco_Longitude], [Endereco_Latitude], [Endereco_Bairro], [Endereco_Cidade], [Endereco_Estado], [DataCadastro], [IdentificadorUnico]) VALUES (6, N'Casa Maria Helena Paulina', N'Casa Maria Helena Paulina', N'05.500.597/0001-57', N'contato@casamariahelenapaulina.org.br', NULL, NULL, N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_cmhp.png', N'(11) 3744-7492', NULL, 0, N'', NULL, 5, N'06756-170', N'R. Judith Passald Esteves', N'137', -46.7321669, -23.6010296, N'Jd. Colombo', N'São Paulo', N'SP', CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'5d804880-1088-4b1b-8990-58dd555ab74b')
INSERT [DoacaoMais].[Caccc] ([CacccId], [Nome], [Apelido], [Cnpj], [Email], [EmailPagSeguro], [EmailPayPal], [UrlImagem], [Telefone], [Celular], [Autorizado], [Responsavel], [DataFundacao], [TipoDoacao], [Endereco_Cep], [Endereco_Logradouro], [Endereco_Numero], [Endereco_Longitude], [Endereco_Latitude], [Endereco_Bairro], [Endereco_Cidade], [Endereco_Estado], [DataCadastro], [IdentificadorUnico]) VALUES (7, N'CAVD -CASA DE APOIO VIDA DIVINA', N'CAVD - CASA DE APOIO VIDA DIVINA', N'000.0000.0000/000', N'cavd@cavd.org.br', NULL, NULL, N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_cavd.png', N'(11) 2545-2150', NULL, 0, N'', NULL, 5, N'03807-290', N'Rua Martinho de Sousa', N'207', -46.4750445, -23.5030268, N'Ermelino Matarazzo, Vila Paranaguá', N'São Paulo', N'SP', CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'f8e9bba2-be5c-4657-9d4b-88fe59b850de')
SET IDENTITY_INSERT [DoacaoMais].[Caccc] OFF
SET IDENTITY_INSERT [DoacaoMais].[ContaBancaria] ON 

INSERT [DoacaoMais].[ContaBancaria] ([ContaBancariaId], [NumeroBanco], [NomeBanco], [Agencia], [Conta], [Beneficiario], [UrlImagem], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (1, NULL, N'Itau', N'806', N'48600-4', N'Centro de Apoio à Criança Carente com Câncer', NULL, 1, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'b27ac331-53f3-4f35-a114-ce5738933e69')
INSERT [DoacaoMais].[ContaBancaria] ([ContaBancariaId], [NumeroBanco], [NomeBanco], [Agencia], [Conta], [Beneficiario], [UrlImagem], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (2, NULL, N'Bradesco', N'0450-2', N'112.100-6', N'Razão Social: AACC – Associação de Apoio à Criança com Câncer', NULL, 2, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'354e4eb1-bcf6-4fc1-bff8-3c35dc283374')
INSERT [DoacaoMais].[ContaBancaria] ([ContaBancariaId], [NumeroBanco], [NomeBanco], [Agencia], [Conta], [Beneficiario], [UrlImagem], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (3, NULL, N'Brasil', N'5934-X', N' 40.013-0', N'Razão Social: AACC – Associação de Apoio à Criança com Câncer', NULL, 2, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'559996cb-5f2d-43ee-afb7-0c6213c740a5')
INSERT [DoacaoMais].[ContaBancaria] ([ContaBancariaId], [NumeroBanco], [NomeBanco], [Agencia], [Conta], [Beneficiario], [UrlImagem], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (4, NULL, N'Bradesco', N'108-2', N'182180-6', N'CNPJ : 07.882.523/0001-58 - MJ: 08071.005685/2008-14 - CMDCA:1718/12', NULL, 3, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'8df3c56a-1a67-4a96-9ea8-5e3c1502bfe6')
INSERT [DoacaoMais].[ContaBancaria] ([ContaBancariaId], [NumeroBanco], [NomeBanco], [Agencia], [Conta], [Beneficiario], [UrlImagem], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (5, NULL, N'Bradesco', N'2799-5', N'9480-3', N'CNPJ : 05.500.597/0001-57', NULL, 4, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'90657c18-69d9-4b32-a9ff-f8aa09be40fb')
INSERT [DoacaoMais].[ContaBancaria] ([ContaBancariaId], [NumeroBanco], [NomeBanco], [Agencia], [Conta], [Beneficiario], [UrlImagem], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (6, NULL, N'Itaú', N'0300', N'06000-1', N'CNPJ: 01.378.697/0001-00', NULL, 5, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'9d914202-ebfb-4de8-851b-5a6ad19e9586')
INSERT [DoacaoMais].[ContaBancaria] ([ContaBancariaId], [NumeroBanco], [NomeBanco], [Agencia], [Conta], [Beneficiario], [UrlImagem], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (7, NULL, N'Bradesco', N'3084-8', N'112.510-9', N'CNPJ: 01.378.697/0001-00', NULL, 5, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'f2053acd-5c06-49b0-bef5-0168e1dbc21e')
INSERT [DoacaoMais].[ContaBancaria] ([ContaBancariaId], [NumeroBanco], [NomeBanco], [Agencia], [Conta], [Beneficiario], [UrlImagem], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (8, NULL, N'Itaú', N'0062', N'35.926-0', N'CNPJ: 69.107.142/0001-59', NULL, 6, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'5bbeacb5-97ea-4af8-bf37-3d375fd2a1f3')
INSERT [DoacaoMais].[ContaBancaria] ([ContaBancariaId], [NumeroBanco], [NomeBanco], [Agencia], [Conta], [Beneficiario], [UrlImagem], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (9, NULL, N'Bradesco', N'0516', N'70.758-9', N'CNPJ: 69.107.142/0001-59', NULL, 6, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'd9838cbf-0c7d-4d60-9146-855baab748fa')
INSERT [DoacaoMais].[ContaBancaria] ([ContaBancariaId], [NumeroBanco], [NomeBanco], [Agencia], [Conta], [Beneficiario], [UrlImagem], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (10, NULL, N'Brasil', N'3050-3', N'2004-4', N'CNPJ: 69.107.142/0001-59', NULL, 6, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'19818bca-ecea-4448-adf8-b9543f37432c')
INSERT [DoacaoMais].[ContaBancaria] ([ContaBancariaId], [NumeroBanco], [NomeBanco], [Agencia], [Conta], [Beneficiario], [UrlImagem], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (11, NULL, N'Itaú', N'0682', N'06237-7', N'Casa de Apoio Vida Divina', NULL, 7, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'95995018-fd90-4e18-aba3-8c77b5112c38')
INSERT [DoacaoMais].[ContaBancaria] ([ContaBancariaId], [NumeroBanco], [NomeBanco], [Agencia], [Conta], [Beneficiario], [UrlImagem], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (12, NULL, N'Caixa Econômica Federal', N'1618', N'817-3', N'Casa de Apoio Vida Divina', NULL, 7, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'4a08863c-daaf-4dff-b478-4e2eea0bfc6b')
SET IDENTITY_INSERT [DoacaoMais].[ContaBancaria] OFF
SET IDENTITY_INSERT [DoacaoMais].[Conteudo] ON 

INSERT [DoacaoMais].[Conteudo] ([ConteudoId], [Titulo], [Subtitulo], [Coluna], [Url], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (1, N'HISTÓRIA', N'', N'<p>O CENTRO DE APOIO &Agrave; CRIAN&Ccedil;A CARENTE COM C&Acirc;NCER - C&Acirc;NDIDA BERMEJO CAMARGO - CACCC-CBC, nasceu da iniciativa da Sra. Jovaneide e Eliana, com o intuito de abrigar, apoiar e cuidar de fam&iacute;lias, cujas crian&ccedil;as precisam de tratamento oncol&oacute;gico.</p>

                                <p>O tratamento gratuito sempre demora meses e a casa cuida para que os pequenos sejam atendidos nos hospitais, providenciando hospedagem, transporte, alimenta&ccedil;&atilde;o e muito carinho &agrave;s crian&ccedil;as, bem como aos acompanhantes respons&aacute;veis, para que o atendimento regular e permanente seja garantido.</p>

                                <p> E tudo isto &eacute; provido com muito empenho de volunt&aacute;rios e pessoas que nos apoiam.</p>', NULL, 1, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'ac519078-26ef-4392-9282-19e0a55285c4')
INSERT [DoacaoMais].[Conteudo] ([ConteudoId], [Titulo], [Subtitulo], [Coluna], [Url], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (2, N'OBJETIVO', N'', N'<p>O Centro ''CBC'' tem como objetivo proporcionar &agrave;s crian&ccedil;as e seus acompanhantes, que vem de outros estados, em busca de tratamento, uma exten&ccedil;&atilde;o de seus lares, com moradia, alimenta&ccedil;&atilde;o, transporte e o que se fizer necess&aacute;rio para o bem estar de todos..</p>', NULL, 1, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'2e0a543b-7f6e-4514-8ffa-34a2875ebe8f')
INSERT [DoacaoMais].[Conteudo] ([ConteudoId], [Titulo], [Subtitulo], [Coluna], [Url], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (3, N'Nossa História', N'11/04/1985', N'<p>A nossa história começa em 11 de abril de 1985 por iniciativa do casal José Marcus Rotta e Wanir Leão Cavalcanti Rotta após experiência numa casa de apoio em Seattle, EUA, no período de 1983 a abril de 1984, em decorrência do tratamento do filho Thiago, vítima de leucemia.</p> ', NULL, 2, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'79b1773b-6fa8-4344-9405-71d037b4f41b')
INSERT [DoacaoMais].[Conteudo] ([ConteudoId], [Titulo], [Subtitulo], [Coluna], [Url], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (4, N'Inauguração Do Suporte Educacional', N'02/05/1995', N'<p>Com o objetivo de facilitar a reinserção social da criança e do adolescente com câncer, desenvolvendo habilidades, recuperando sua defasagem escolar durante o tratamento e adotando uma postura que considere uma perspectiva de cura, a Associação de Apoio à Criança com Câncer inaugura o Suporte Educacional em 1995, a escola da criança com câncer em São Paulo.</p>', NULL, 2, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'5480c90f-bb73-4254-96ba-3e4701353819')
INSERT [DoacaoMais].[Conteudo] ([ConteudoId], [Titulo], [Subtitulo], [Coluna], [Url], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (5, N'Lançamento Da Revista Da AACC', N'02/12/1996', N'O ano de 1992 marcou o lançamento da Revista da AACC - Órgão oficial da Associação de Apoio à Criança com Câncer.', NULL, 2, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'cb81b9b7-f88e-4a12-a10b-03067607d2c1')
INSERT [DoacaoMais].[Conteudo] ([ConteudoId], [Titulo], [Subtitulo], [Coluna], [Url], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (6, N'Casa Nova Da AACC Na Vila Mariana', N'02/09/1997', N'<p>Casa Nova AACC inaugurada na Vila Mariana. A Entidade galga espaço para crescer , ainda mais, com a implantação de novos projetos, informatização do fluxo de informações, com o objetivo de que a AACC se torne cada vez mais conhecida em nossa sociedade.</p>', NULL, 2, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'd4d125ae-54e9-4ff5-ab73-0fdb23fecce3')
INSERT [DoacaoMais].[Conteudo] ([ConteudoId], [Titulo], [Subtitulo], [Coluna], [Url], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (7, N'Nova Fase No Suporte Educacional Da AACC', N'20/11/1997', N'<p>Começa uma nova etapa. A AACC triplica a capacidade de atendimento do Suporte Educacional.</p>
                                <p>Combinando bom gosto, conforto, simplicidade e harmonia, ingredientes estes que fazem da nova estrutura um recanto aconchegante para receber crianças e adolescentes do Brasil todo que procuram a Entidade em busca de auxílio.</p>', NULL, 2, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'a42c254e-bf86-4351-bd14-9fdef48afd18')
INSERT [DoacaoMais].[Conteudo] ([ConteudoId], [Titulo], [Subtitulo], [Coluna], [Url], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (8, N'Histórico', N'', N'O CMK – Centro de Apoio à Criança com Câncer Marta Kuboiama é uma entidade sem fins lucrativos e foi fundado em 11 de janeiro de 2006 graças à iniciativa de Marta Kuboiama, portadora de câncer desde 1994 e, de Dirce Kuboyama, irmã de Marta, que atua na área da saúde pública há mais de vinte anos.

                                A idéia da realização de um projeto para crianças carentes portadoras de câncer nasceu após anos de convivência com a realidade da população carente portadora de câncer.

                                O projeto visa atender às crianças portadoras de câncer oriundas de todo território nacional e acolhê-las durante seu tratamento em São Paulo. Para isso, planejam oferecer uma casa equipada para atender a todas as necessidades dos pacientes e seus acompanhantes.

                                Desde então, o CMK promove o apoio à crianças em hospitais e suas famílias.', NULL, 3, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'f305f746-e9b7-427b-be4b-0449de607098')
INSERT [DoacaoMais].[Conteudo] ([ConteudoId], [Titulo], [Subtitulo], [Coluna], [Url], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (9, N'Nossa missão', N'', N'Promover a assistência psicossocial, médica e financeira às crianças com câncer,            de famílias carentes de todo Brasil.', NULL, 4, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'31d0d05a-038c-4505-8b48-a27371322d41')
INSERT [DoacaoMais].[Conteudo] ([ConteudoId], [Titulo], [Subtitulo], [Coluna], [Url], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (10, N'Quem Somos', N'', N'Fundada em setembro de 2002 por um grupo de voluntários, que conviveram com a  dificuldade de se manter em São Paulo os seus filhos e a eles mesmos durante o tratamento oncológico e que se estabeleceu a Casa Modelo de Apoio a Criança com Câncer.

                                Como e de conhecimento publico que o tratamento quando fornecido não contempla as questões de hospedagem da mãe e filho, alimentação, logística de transporte apoio social a criança e a mãe durante esse longo tempo, pois a maioria dos tratamentos demanda um período de permanência mínima de 12 meses de idas e vindas de hospital.

                                A grande maioria das crianças vem de outros estados, principalmente, do norte e nordeste do país, os quais não têm recursos suficientes como médicos e clinicas especializadas para diagnósticos complexos. Em muitos casos, o tratamento é longo com varias internações hospitalar, cirurgia, exames e transplantes que requerem tratamento especial.

                                Muitas vezes por falta de informação as famílias não têm conhecimento desse tipo de assistência que é gratuita e acabam desistindo do tratamento, pois não tem como se alimentar, como se locomover e nem onde ficar..', NULL, 4, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'3d887d3d-5663-4f30-8779-ddc6a5360303')
INSERT [DoacaoMais].[Conteudo] ([ConteudoId], [Titulo], [Subtitulo], [Coluna], [Url], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (11, N'HISTÓRIA', N'', N'A CAJEC é fruto do sonho de um rapaz de 16 anos, que lutou contra o câncer, e          inspirou a voluntária Maria Luiza Candido Centelles, fundadora / presidente da CAJEC, a colocar   em prática o sonho dele. E em janeiro de 1996, a Casa José Eduardo Cavichio foi aberta com o      objetivo de assistir crianças e adolescentes com câncer oriundas de todo o Brasil, e hoje        América Latina.
                                   Hoje, ele é uma estrela que brilha intensamente e ilumina todos os que lutam contra o câncer    infanto-juvenil.', NULL, 5, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'0358da30-354b-486d-8b93-b44ec4f2ca9a')
INSERT [DoacaoMais].[Conteudo] ([ConteudoId], [Titulo], [Subtitulo], [Coluna], [Url], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (12, N'O QUE FAZEMOS?', N'', N'A CAJEC – Casa José Eduardo Cavichio – apoio a criança com câncer, instituição filantrópica, sem fins lucrativos, que desde 1996 assiste crianças e adolescentes com câncer de todo o Brasil e América Latina para realizar tratamento em hospitais na cidade de São Paulo.A vivência do adoecer, o tratamento fora domicílio, gera no assistido angustia e ansiedade. Pensando nisso, o trabalho da CAJEC é proporcionar uma estadia que acolhe, orienta para que mesmo longe de casa, ele possa se sentir em um lar.Desta forma a CAJEC oferece apoio psicológico, fisioterapêutico, assistente social e preocupa-se também com a convivência saudável ajudando no bem estar e na qualidade de vida.', NULL, 5, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'5553c2d9-6f50-488d-b053-46694b78c20e')
INSERT [DoacaoMais].[Conteudo] ([ConteudoId], [Titulo], [Subtitulo], [Coluna], [Url], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (13, N'Sobre nós', N'', N'A Casa Maria Helena Paulina é uma organização não governamental paulista fundada em 1992 que acolhe jovens com câncer - ou outras enfermidades - e seus acompanhantes oriundos de diversos estados brasileiros que se encaminham para São Paulo em busca de infraestrutura de tratamento adequado às suas necessidades. Essas famílias quando chegam, encontram uma realidade tão difícil quanto a própria doença: falta de dinheiro, falta de informação e falta de condições para se manter na cidade durante o tratamento, que pode durar meses.​

                                 O diagnóstico e o tratamento fora de domicílio, interferem no equilíbrio e no bem estar do paciente. Pensando nisso, o trabalho da Casa é voltado a acolher as pessoas, tornando a estadia dos assistidos a melhor possível, como se estivessem em seu próprio lar.​

                                 Desta forma A Casa Maria Helena Paulina oferece moradia, alimentos, assistência psicológica, produtos de higiene e as mais variadas atividades, pois preocupa-se também com a convivência saudável ajudando no bem estar e na qualidade de vida', NULL, 6, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'41563277-3d2c-4e61-8f2f-4f64140895f2')
INSERT [DoacaoMais].[Conteudo] ([ConteudoId], [Titulo], [Subtitulo], [Coluna], [Url], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (14, N'Conheça a nossa História', N'', N'Em 1992, a Casa Maria Helena Paulina abre suas portas. O sonho dessa enfermeira, também vítima de câncer, torna-se realidade. ​

                                A Sra. Maria Helena Paulina foi enfermeira do Hospital das Clínicas de São Paulo e ao se aposentar, descobriu-se portadora de câncer de mama. Durante seu tratamento, deparou-se com uma

                                problemática muito comum: a de famílias que vinham a São Paulo para tratamento médico e, por serem carentes, não tinham recursos para se hospedarem na cidade.                                ​

                                Na época existiam apenas duas casas de apoio na capital, que não supriam a necessidade e diversas pessoas passavam a noite na rua e debaixo de viadutos.  Sabendo como é o funcionamento de uma

                                casa de apoio e com informações suficientes, ela e suas duas primas, Marina e Regina, resolveram criar uma nova instituição, para que estas pessoas não permanecessem em condições tão subumanas durante um tratamento que além de ser demorado, exige diversos cuidados.

                                Inicialmente a casa funcionava com o trabalho da duas primas e outras pessoas que também tinham perdido um ente querido e eram solidárias à causa.                                ​

                                Em 1998, a Casa passou a ser acompanhada periodicamente pela Vara da Infância e da Juventude do Fórum Regional de Pinheiros, processo nº 900196/6 e possui registro no Conselho Municipal dos Direitos da Criança e do Adolescente sob no. 824/CMDCA/1999.                                ​

                                Hoje, a casa acolhe em média 20 pacientes e seus acompanhantes, totalizando 40 pessoas por vez, em esquema de rodízio.', NULL, 6, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'10fb1be8-4068-4bee-9f4d-07da3ee7aff3')
INSERT [DoacaoMais].[Conteudo] ([ConteudoId], [Titulo], [Subtitulo], [Coluna], [Url], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (15, N'Sobre nós', N'', N'A casa foi fundada em 2002 por Marli Francisca, atualmente presidente da                instituição. Infelizmente, ela perdeu sua mãe para o câncer, e a partir disso resolveu se       dedicar ao auxílio às mães e crianças que conheceu durante o tratamento de sua mãe nos          hospitais.

                                 A Casa de Apoio Vida Divina acolhe crianças e adolescentes com câncer de outros estados, todos acompanhados por seus responsáveis e moram aqui provisoriamente durante o tratamento de câncer na capital de São Paulo. Hoje a nossa missão é proporcionar a eles um tratamento digno com amor, esperança e oportunidade para vencer a luta contra o câncer. O apoio à criança com câncer é essencial em diversas esferas. Os pequenos doentes precisam de auxílio e tratamento adequado, mas as famílias também devem passar pela assistência. O local tem como casa o distrito de Ermelino Matarazzo. Além disso, é não-governamental e não possui fins lucrativos. Com mais de 10 anos de história a casa já recebeu maios de 500 famílias oriundas de diversas regiões do país.', NULL, 7, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'943b22c6-ba33-4cea-b09d-e281e16b4444')
INSERT [DoacaoMais].[Conteudo] ([ConteudoId], [Titulo], [Subtitulo], [Coluna], [Url], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (16, N'Missão', N'', N'Atender com qualidade as crianças e adolescentes com câncer e seus acompanhantes durante o tratamento na capital de São Paulo com o intuito de alcançar a cura com qualidade de vida. Oferecer hospedagem, alimentação, transporte, medicamento, atendimento social, pedagógico, atividades lúdicas e recreativas através de voluntários durante o período do tratamento.', NULL, 7, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'5dad538e-46a3-415c-8c7d-733d19d6f404')
INSERT [DoacaoMais].[Conteudo] ([ConteudoId], [Titulo], [Subtitulo], [Coluna], [Url], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (17, N'Visão', N'', N'Ser considerada como uma instituição de referência no modelo de apoio as crianças e adolescentes portadoras do câncer de todos os estados do Brasil.', NULL, 7, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'b3058bd5-8fad-4697-be04-f0de158b3dad')
INSERT [DoacaoMais].[Conteudo] ([ConteudoId], [Titulo], [Subtitulo], [Coluna], [Url], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (18, N'Valores', N'', N'Atuar no atendimento com comprometimento, solidariedade e amor a todos que buscam o nosso apoio.', NULL, 7, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'5248ad4e-0f2c-4627-8a86-bc8e7fe766ac')

SET IDENTITY_INSERT [DoacaoMais].[Conteudo] OFF
SET IDENTITY_INSERT [DoacaoMais].[Dispositivo] ON 

INSERT [DoacaoMais].[Dispositivo] ([DispositivoId], [DeviceId], [Release], [Incremental], [VersaoSDK], [FirgirPrint], [Board], [Brand], [Device], [Manufacture], [Model], [Host], [Code], [Type], [Serial], [DataCadastro], [IdentificadorUnico]) VALUES (1, NULL, N'5.1.1', N'WW_Phone-13.0209.1705.117-20170627', NULL, NULL, N'MSM8226', N'asus', N'err_value', N'asus', N'ASUS_X013D', NULL, NULL, NULL, N'G7AZB601E195FTN', CAST(N'2019-06-30T11:31:22.163' AS DateTime), N'6779d9d2-fb83-486d-b78e-2dac165437e3')
INSERT [DoacaoMais].[Dispositivo] ([DispositivoId], [DeviceId], [Release], [Incremental], [VersaoSDK], [FirgirPrint], [Board], [Brand], [Device], [Manufacture], [Model], [Host], [Code], [Type], [Serial], [DataCadastro], [IdentificadorUnico]) VALUES (2, NULL, N'6.0.1', N'G532MTVJU1ASA1', NULL, NULL, N'MT6737T', N'samsung', N'grandppltedtv', N'samsung', N'SM-G532MT', NULL, NULL, NULL, N'4200f7904f994401', CAST(N'2019-07-06T16:11:47.583' AS DateTime), N'cdd97ccd-3f64-40a4-a9cd-31374c4ed8ee')
SET IDENTITY_INSERT [DoacaoMais].[Dispositivo] OFF
SET IDENTITY_INSERT [DoacaoMais].[Noticia] ON 

INSERT [DoacaoMais].[Noticia] ([NoticiaId], [Titulo], [SubTitulo], [Conteudo], [UrlImagem], [DataPublicacao], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (1, N'Auxilio Doença', N'', N'<p>Beneficia, mensalmente, os portadores de c&acirc;ncer inscritos no Regime Geral de Previd&ecirc;ncia Social.</p>
                                <p>Para isso &eacute; necess&aacute;rio que os enfermos comprovem, por meio de exames realizados pela per&iacute;cia m&eacute;dica do INSS, que est&atilde;o temporariamente incapazes para trabalhar por mais de 15 dias consecutivos.</p>
                                <p>Para solicitar o aux&iacute;lio &eacute; necess&aacute;rio que os pacientes compare&ccedil;am ao posto da Previd&ecirc;ncia Social mais pr&oacute;ximo para agendamento de per&iacute;cia m&eacute;dica, portando sua Carteira de Trabalho ou os documentos que comprovem a sua contribui&ccedil;&atilde;o ao INSS, mais a declara&ccedil;&atilde;o ou o exame m&eacute;dico que descreva seu estado cl&iacute;nico.</p>
                                <p>A partir do 16&deg; dia afastado do trabalho, o segurado empregado come&ccedil;a a receber o benef&iacute;cio.</p>
                                <p>Os segurados desempregados recebem a partir da data do in&iacute;cio da sua incapacidade ou de entrada do requerimento</p>', N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/auxilio_doenca.jpg', NULL, 1, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'528f1714-410c-4285-a243-5281f0a47e3f')
INSERT [DoacaoMais].[Noticia] ([NoticiaId], [Titulo], [SubTitulo], [Conteudo], [UrlImagem], [DataPublicacao], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (2, N'Sua Empresa causa uma boa primeira impressão?', N'', N'<p>Em vez de manter uma pol&iacute;tica de doa&ccedil;&otilde;es ao acaso, seria melhor abra&ccedil;ar uma causa social e se tornar conhecido como o mantenedor dela. Se estes esfor&ccedil;os estiverem concentrados em um problema ou necessidade, a sua empresa vai transmitir uma primeira boa impress&atilde;o a todos.</p>
                                <p>As primeiras empresas a investir em projetos sociais ser&atilde;o as primeiras a abra&ccedil;ar as causas de maior impacto, as &ldquo;melhores causas&rdquo;. Os retardat&aacute;rios na filantropia estrat&eacute;gica ficar&atilde;o com as causas de menor impacto ou ter&atilde;o a necessidade de pesquisar constantemente para descobrir novas causas ou necessidades que ir&atilde;o aparecer com o tempo.</p>
                                <p>Causar uma primeira boa impress&atilde;o deveria ser a primeira preocupa&ccedil;&atilde;o no planejamento estrat&eacute;gico de uma empresa. Muitas campanhas publicit&aacute;rias s&atilde;o no fundo, tentativas criadas para induzir o consumidor em potencial a realizar a sua primeira compra.</p>
                                <p>Ao oferecerem descontos, garantia de satisfa&ccedil;&atilde;o ou o dinheiro de volta, estar&atilde;o induzindo a primeira compra, sem ter causado uma primeira boa impress&atilde;o no cliente. Os profissionais de marketing est&atilde;o enclausurados na id&eacute;ia de que a primeira impress&atilde;o tem que estar relacionada ao produto. A pergunta provocativa que coloco &eacute; se realmente este &eacute; o &uacute;nico caminho, e se &eacute; a maneira mais barata de chegar a este objetivo.</p>
                                <p>Um projeto social coloca a marca na sua empresa, n&atilde;o nos produtos, e define a sua companhia como uma organiza&ccedil;&atilde;o s&eacute;ria, um cidad&atilde;o corporativo, uma empresa com conte&uacute;do, com integridade. Nessa era, devido ao culto &agrave; individualidade, empresas ser&atilde;o vistas e julgadas pelos mesmos padr&otilde;es que costumamos julgar indiv&iacute;duos. N&atilde;o pelo que voc&ecirc; faz, mas pelo que voc&ecirc; &eacute;.</p>
                                <p>Assim, a grande quest&atilde;o que qualquer membro do conselho executivo deve fazer &eacute; &ldquo;A nossa empresa causou uma primeira boa impress&atilde;o em consumidores potenciais suficientes para garantir crescimento?&rdquo;. &ldquo;N&oacute;s causamos<br /> uma primeira boa impress&atilde;o em cada universit&aacute;rio, futuros acionistas e governantes oficiais?&rdquo;<br /> Stephen Kanitz</p>', N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/business_people.jpg', NULL, 1, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'b3ae0f7c-1031-4547-a768-9702c14d2161')
INSERT [DoacaoMais].[Noticia] ([NoticiaId], [Titulo], [SubTitulo], [Conteudo], [UrlImagem], [DataPublicacao], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (3, N'O que é terceiro setor?', N'', N'<p>O primeiro setor &eacute; o governo, que &eacute; respons&aacute;vel pelas quest&otilde;es sociais. O segundo setor &eacute; o privado, respons&aacute;vel pelas quest&otilde;es individuais. Com a fal&ecirc;ncia do Estado, o setor privado come&ccedil;ou a ajudar nas quest&otilde;es sociais, atrav&eacute;s das in&uacute;meras institui&ccedil;&otilde;es que comp&otilde;em o chamado terceiro setor.</p>
                                <p>Ou seja, o terceiro setor &eacute; constitu&iacute;do por organiza&ccedil;&otilde;es sem fins lucrativos e n&atilde;o governamentais, que tem como objetivo gerar servi&ccedil;os de car&aacute;ter p&uacute;blico.</p>
                                <p>Os principais personagens do terceiro setor s&atilde;o:</p>
                                <p>Funda&ccedil;&otilde;es</p>
                                <p>S&atilde;o as institui&ccedil;&otilde;es que financiam o terceiro setor, fazendo doa&ccedil;&otilde;es &agrave;s entidades beneficentes. No Brasil, temos tamb&eacute;m as funda&ccedil;&otilde;es mistas que doam para terceiros e ao mesmo tempo executam projetos pr&oacute;prios.</p>
                                <p>Nos Estados Unidos j&aacute; existem 40.000 funda&ccedil;&otilde;es, sendo que a 10&ordm; colocada tem 10 bilh&otilde;es de d&oacute;lares de patrim&ocirc;nio. Nossa maior funda&ccedil;&atilde;o tem 1 bilh&atilde;o.</p>', N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/cancer_kid.png', NULL, 1, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'5828599a-f6d8-4315-a279-35afb5a120dc')
INSERT [DoacaoMais].[Noticia] ([NoticiaId], [Titulo], [SubTitulo], [Conteudo], [UrlImagem], [DataPublicacao], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (4, N'Faça agora uma doação com PagSeguro', N'', N'<p>Colabore com quanto desejar, mas n&atilde;o esque&ccedil;a de nos enviar seus dados, enviaremos seu recibo e fazemos quest&atilde;o de mostrar como vai ser aplicado sua oferta.</p>', N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/doacao.jpg', NULL, 1, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'07c7d720-f348-4ff5-bf37-845a40f90df9')
INSERT [DoacaoMais].[Noticia] ([NoticiaId], [Titulo], [SubTitulo], [Conteudo], [UrlImagem], [DataPublicacao], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (5, N'Livro “Câncer, Direito e Cidadania”', N'', N'<p>O Livro “Câncer, Direito e Cidadania”, de autoria da Antonieta Barbosa, advogada e Pernambucana, é uma vasta pesquisa sobre os direitos dos pacientes com câncer.</p>

                                    <p>Após um diagnóstico de câncer de mama, ela decide resgatar os seus direitos, enfrentando e vencendo toda sorte de dificuldades, entraves jurídicos e burocráticos, além de uma cirurgia de mastectomia conservadora, quimioterapia, radioterapia e hormonioterapia.</p>

                                <p>Diante dessa experiências e das lições de vida que recebeu nessa caminhada, nasceu a ideia de escrever este livro, quetraz informações úteis e dicas importantes, em linguagem acessível, encorajando o paciente, já fragilizado pela doençae maltratado pela burocracia, a resgatar sua dignidade, a qual só o pleno exercício da cidadania pode proporcionar.</p>


                                <p>O livro busca esclarecer e informar os direitos do paciente no âmbito:Auxílio-doença</p>
                                    <ul>
                                        <li>Aposentadoria integral com adicional de 25% em alguns casos</li>
                                        <li>Atendimento domiciliar</li>
                                        <li>Isenção do Imposto de Renda</li> 
                                        <li>Redução da Contribuição Previdenciária</li> 
                                        <li>Isenção de IPI, ICMS, IOF e IPVA na compra de veículos, em caso
                                        de deficiência</li> 
                                        <li>Isenção de IPTU em alguns municípios</li> 
                                        <li>Saque do FGTS e do PIS/Pasep</li> 
                                        <li>Cirurgia de reconstrução mamária gratuita</li>
                                        <li>Quitação do financiamento imobiliário </li>
                                        <li>Resgate de prêmio de seguro e/ou previdência privada</li> 
                                        <li>Frequência escolar em regime especial</li>
                                        <li>Prioridade no andamento de processos e precatórios</li>
                                        <li>Medicamentos gratuitos</li>
                                        <li>Direitos frente aos Planos de Saúde e na relação médico-paciente</li>
                                    </ul>

                                    <p>Esses e outros direitos e benefícios constam no Livro “Câncer, Direito e Cidadania”, um verdadeiro “garimpo jurídico”, que traz ainda informações sobre os tipos e tratamentos do câncer, dicas de prevenção, estatísticas oficiais e um
                                    guia com sites e endereços de serviços gratuitos em todo o Brasil.</p>

                                    <p>Parceria com a AACC Indispensável não apenas ao paciente com câncer, mas também aos familiares, cuidadores, médicos, assistentes sociais, profissionais da área de saúde e advogados.</p>', N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/cancer_livro.jpg', NULL, 2, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'5cbb146e-4259-4d3c-846c-4a1010036194')
INSERT [DoacaoMais].[Noticia] ([NoticiaId], [Titulo], [SubTitulo], [Conteudo], [UrlImagem], [DataPublicacao], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (6, N'AACC no Museu do Amanhã', N'', N'<p>No aniversário seu aniversário de dois anos, o Museu do Amanhã, em parceria com a IBM Brasil, convida os seus visitantes a criar uma ponte entre a reflexão e a ação, a IRIS+.</p>
                                           <p>O assistente cognitivo construído com IBM Watson – plataforma de Inteligência Artificial para negócios – foi desenvolvido não somente para responder aos visitantes, mas também formular perguntas.</p>
                                           <p> O visitante será questionado sobre diversos temas que possam levá-lo a um engajamento social e, a partir de sua resposta, poderá experenciar o trabalho da AACC, que está na Exposição Principal.</p>', N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/museu_amanha.jpg', NULL, 2, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'd8aea9fd-784d-43af-b0b4-828d5e1a7d1e')
INSERT [DoacaoMais].[Noticia] ([NoticiaId], [Titulo], [SubTitulo], [Conteudo], [UrlImagem], [DataPublicacao], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (7, N'O QUE É O MOVIMENTO TODOS JUNTOS CONTRA O CÂNCER (TJCC)', N'', N'Cenário do Brasil

                                O Brasil vem sofrendo mudanças relevantes em seu perfil demográfico e epidemiológico, consequência, entre outros fatores, do processo de urbanização, da industrialização e dos avanços da ciência e da tecnologia. A essas novas caraterísticas da sociedade brasileira, unem-se a mudança nos hábitos e estilos de vida e a exposição a fatores de risco próprios do mundo contemporâneo. 

                                A mudança demográfica, com consequente envelhecimento da população, associada à transformação nas relações entre as pessoas e o ambiente, acarretaram alterações importantes no perfil de morbimortalidade, diminuindo a ocorrência das doenças infectocontagiosas e colocando as doenças crônico-degenerativas no centro de atenção. O câncer é atualmente a segunda principal causa de morte no país, e estimam-se que serão 600 mil diagnósticos de câncer até o final de 2016.

                                   Para o sistema de saúde se aperfeiçoar e atender a toda essa demanda, garantindo o acesso, cobertura e efetividade na área da Oncologia, é necessária, além da atuação do governo, a participação de diversos interlocutores, tais como usuários, médicos e outros trabalhadores da área da saúde, estabelecimentos de saúde, pesquisadores, órgãos de controle, mídia, entre outros.

                                Observando o esforço fragmentado e a existência de inúmeras entidades e instituições estruturadas para dar apoio, oferecer assistência e defender os direitos das pessoas com câncer, além das diversas demandas apontadas pelos pacientes, familiares, médicos e profissionais de saúde, a Abrale - Associação Brasileira de Linfoma e Leucemia, vislumbrou uma iniciativa inovadora com o objetivo de aproximar os interessados do segmento. Para tal, propôs uma agenda colaborativa visando influenciar as políticas de saúde na área de oncologia e acelerar a promoção da saúde, a prevenção, o acesso ao tratamento e cuidados paliativos às pessoas com câncer no Brasil.', N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/todos_contra_cancer.png', NULL, 5, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'93dda9bb-bc5b-4c97-a378-9605bfcad365')
INSERT [DoacaoMais].[Noticia] ([NoticiaId], [Titulo], [SubTitulo], [Conteudo], [UrlImagem], [DataPublicacao], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (8, N'Câncer: Saiba Mais', N'', N'Câncer (neoplasia, ou tumor maligno) é uma classe de doenças caracterizadas pelo                 crescimento descontrolado de células aberrantes.

                                Ele pode matar devido à invasão destrutiva de órgãos normais por estas células, por extensão direta ou por disseminação à distância, que pode ser através do sangue, linfa ou superfície serosa.

                                O comportamento anormal das células cancerosas é geralmente espelhado por mutações genéticas, expressões de características ontológicas, ou secreção anormal de hormônios ou enzimas. 

                                Todos os cânceres têm o potencial de invasão ou de metastatização, mas cada tipo específico tem características clínicas e biológicas, que devem ser estudadas para um adequado diagnóstico, tratamento e acompanhamento. 

​

                                   Para o sistema de saúde se aperfeiçoar e atender a toda essa demanda, garantindo o acesso, cobertura e efetividade na área da Oncologia, é necessária, além da atuação do governo, a participação de diversos interlocutores, tais como usuários, médicos e outros trabalhadores da área da saúde, estabelecimentos de saúde, pesquisadores, órgãos de controle, mídia, entre outros.

                                Observando o esforço fragmentado e a existência de inúmeras entidades e instituições estruturadas para dar apoio, oferecer assistência e defender os direitos das pessoas com câncer, além das diversas demandas apontadas pelos pacientes, familiares, médicos e profissionais de saúde, a Abrale - Associação Brasileira de Linfoma e Leucemia, vislumbrou uma iniciativa inovadora com o objetivo de aproximar os interessados do segmento. Para tal, propôs uma agenda colaborativa visando influenciar as políticas de saúde na área de oncologia e acelerar a promoção da saúde, a prevenção, o acesso ao tratamento e cuidados paliativos às pessoas com câncer no Brasil.', N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/celulas_doentes.jpg', NULL, 6, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'eaa64b5d-01b8-4deb-a6ae-f6ca387b5a51')
INSERT [DoacaoMais].[Noticia] ([NoticiaId], [Titulo], [SubTitulo], [Conteudo], [UrlImagem], [DataPublicacao], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (9, N'Câncer: Causas e Tratamento', N'', N'<p>As causas que levam ao aparecimento de câncer nos jovens são diferentes das nos adultos. Estão muito mais ligadas a fatores genéticos do que a exposição no ambiente a agentes carcinogênicos.</p>
 <p>Em aproximadamente 10 a 15% dos casos são reconhecidos outros casos na família, ou a criança possui alguma doença genética que confere maior propensão a determinados tipos de câncer, por exemplo, na Síndrome de Down, onde os portadores têm maior chance de desenvolver leucemia.</p>
 <p>Outros fatores que estão associados ao aparecimento de câncer nesta idade seria: exposição à radiação ionizante, vírus (Epstein-Barr), exposição intrauterina a hormônio (diethylstilbestrol).</p>
 <p>Diferente dos adultos, não existe nenhum exame específico associado à idade que pode ser feito de rotina para se detectar precocemente o câncer na criança, na população geral. <br /> O mais importante é que toda criança seja seguida periodicamente por um pediatra, como recomenda a OMS, e que os responsáveis levem a este pediatra se suspeitarem de qualquer sinal que a criança apresente.</p>
 <p>Este profissional deve ser capaz de examinar cuidadosamente e suspeitar de câncer caso seja pertinente e então encaminhar ao centro especializado que convém, mesmo sem a certeza do diagnóstico.</p>
 <p>Tipos:</p>
 <ul>
 <li>Leucemia linfoblástica aguda -</li>
 <li>Leucemia mielocítica aguda</li>
 <li>Cerebrais:Gliomas, astrocitomas cerebelar e cerebral, meduloblastoma - Sarcoma de Ewing ou tumores da família Ewing</li>
 <li>Tumor de células germinativas</li>
 <li>Linfoma de Hodgkin</li>
 <li>Linfoma Não-Hodgkin</li>
 <li>Neuroblastoma</li>
 <li>Câncer hepático</li>
 <li>Osteossarcoma/Histiocitoma fibroso maligno do osso -</li>
 <li>Retinoblastoma</li>
 <li>Rabdomiossarcoma</li>
 <li>Tumor de Wilms</li>
 <li>Sarcoma de tecidos moles</li>
 </ul>
 <p>Tratamento:</p>
 <p>No câncer infantil, assim como nos adultos, o tratamento está baseado no uso de quimioterapia associada à cirurgia e radioterapia. O uso dessas armas vai depender do tipo e a extensão da doença ao diagnóstico.</p>
 <p>Porém, existe uma diferença crucial do tratamento de jovens em relação aos adultos: não podemos nos esquecer que estamos tratando pessoas em fase de crescimento e desenvolvimento.</p>
 <p>A radioterapia e mesmo o uso de várias drogas tóxicas ao organismo podem levar, a longo prazo, a conseqüências desastrosas para o futuro da criança como baixa altura ou até mesmo um segundo câncer.</p>
 <p>Isto torna ainda mais desafiador a luta contra o câncer e estimula a procura de novos métodos de tratamento mais eficientes e menos agressivos.</p>
 <p>Dicas de Prevenção:</p>
 <ul>
 <li> Alimentação balanceada;</li>
 <li> Auto Exame: boca, mama, testículos, pele </li>
 <li>Uso de protetor Solar </li>
 <li>Higiene Íntima -</li>
 <li>Exames médicos periódicos</li>
</ul>
 <p>Direitos do Paciente:</p>
 <ul>
  <li>Requerer aposentadoria</li>
 <li>Saque de FGTS</li>
 <li>Isenção de Imposto de Renda</li>
 <li>Insenção de ICMS e IPI para aquisição de veículos especiais</li>
 <li>Transporte público gratuito para pessoas de baixa renda</li>
 <li> Cirurgia plástica reparadora de mamas</li>
 </ul>', N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/causa_tratamento.jpg', NULL, 6, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'89fb7db4-4369-443d-a12d-9058ba8611b3')
INSERT [DoacaoMais].[Noticia] ([NoticiaId], [Titulo], [SubTitulo], [Conteudo], [UrlImagem], [DataPublicacao], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (10, N'ALICERCE CONTRA O CÂNCER', N'', N'Na edição de Julho saiu no Jornal Cidadania do Grupo de Cidadania Empresarial uma matéria falando sobre o nosso trabalho, sobre os objetivos e desafios de 2016 e dos próximos anos, a matéria completa você encontra no site abaixo.

                        www.cidadania.fcl.com.br/alicerce-contra-o-cancer

                        Agradecemos a responsabilidade social da Fundação Cásper Libero e todas as empresas do Grupo de Cidadania Empresarial pela oportunidade e por virem conhecer um pouco mais da nossa história e luta, juntos somos mais fortes.', N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/alicerce_contra.jpg', NULL, 7, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'9ee16b90-b272-40f8-8d8f-6dc66da7ccc3')
INSERT [DoacaoMais].[Noticia] ([NoticiaId], [Titulo], [SubTitulo], [Conteudo], [UrlImagem], [DataPublicacao], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (11, N'Leucemias', NULL, N'
<p>A leucemia linfoide crônica (LLC) pode ser bem diferente dos outros tipos da doença, já que - por mais estranho que pareça - em alguns casos não será necessário realizar o tratamento.</p>
<p>Tudo acontece quando um tipo de célula do sangue, os glóbulos brancos, responsáveis pela proteção de nosso organismo, passam a se desenvolver de forma descontrolada e param de realizar suas funções.</p>
<p>
    A doença é considerada crônica porque essa alteração provoca o crescimento desordenado de linfócitos B maduros (um tipo de glóbulo branco) que, geralmente, não impede a produção das células normais. Ou seja, ao mesmo tempo em que há uma produção de células com problemas, 
    causando acúmulo na medula óssea, por outro lado o processo de fabricação e maturação das células saudáveis continua acontecendo.
</p>
<p>É importante salientar que a LLC é uma doença adquirida e não hereditária. Ainda não se sabe o motivo para o seu surgimento, mas, na maior parte dos casos, ela atinge pessoas com mais de 50 anos. Não há registros de crianças que tenham sido diagnosticadas com a doença.</p>', N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/leucemia.jpg', NULL, NULL, CAST(N'2019-06-30T11:57:10.760' AS DateTime), N'6FF2E13C-3A31-4919-8114-738663CACB73')
INSERT [DoacaoMais].[Noticia] ([NoticiaId], [Titulo], [SubTitulo], [Conteudo], [UrlImagem], [DataPublicacao], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (12, N'Linfomas', NULL, N'
<p>É denominado linfoma todo tipo de câncer que afeta o sistema linfático.</p>
<p>O sistema linfático é constituído por gânglios interligados pelos vasos linfáticos que atuam na defesa do organismo contra infecções</p>
<p>Os gânglios linfáticos se encontram em diversas partes do corpo, tais como: pescoço, axilas e virilha. Internamente, são encontrados, principalmente, no tórax (mediastino) e abdômen. As amídalas, o fígado e o baço também fazem parte do sistema linfático.</p>
<p>O tumor tem início quando há uma multiplicação desordenada das células do sangue relacionadas ao sistema imunológico (linfócitos), aumentando o excesso de tecido e dando origem ao tumor.</p>
<p>Os Linfomas são classificados em dois principais grupos:</p>
Linfoma de Hodgkin ou doença de Hodgkin<br/>
Linfoma não Hodgkin<br/>
<p>Principais sintomas</p>
<p>Alguns dos principais sintomas apresentados pelos linfomas são comuns a doenças mais simples. Por isso é importante ao identificar esses sinais que se procure orientação médica pra que se possa fazer o diagnóstico correto.</p>
<ul>
	<li>Aumento progressivo e indolor do abdome;</li>
	<li>Aumento progressivo e indolor dos gânglios (ínguas);</li>
	<li>Febre persistente sem evidência de infecção;</li>
	<li>Suor noturno abundante;</li>
	<li>Perda de peso relevante;</li>
	<li>Coceiras pelo corpo;</li>
	<li>Cansaço.</li>
</ul>
', N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/linfoma.jpg', NULL, NULL, CAST(N'2019-06-30T11:57:22.570' AS DateTime), N'E3EEAFB3-6954-4A2D-B2F2-2F884D3CD4EF')
INSERT [DoacaoMais].[Noticia] ([NoticiaId], [Titulo], [SubTitulo], [Conteudo], [UrlImagem], [DataPublicacao], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (13, N'Cerébro - SNC', NULL, N'
<p>Com incidência maior na faixa entre 4 e 9 anos, os tumores do SNC representam 20% de todas as doenças malignas da infância.</p>
<p>Os tumores cerebrais apresentam certas particularidades, que tornam seu diagnóstico e tratamento diferenciado com relação aos outros tipos de câncer infantil.</p>
<p>Por estar localizado numa área extremamente sensível e propícia ao surgimento de seqüelas físicas e psicológicas, o tratamento e acompanhamento do paciente deve ser estendido para diversas outras especialidades médicas.</p>
<p>Como geralmente não ocorre metástase para outros órgãos, a intervenção cirúrgica com retirada total do tumor, pode ser a melhor opção de tratamento. A não ser que a sua localização, dificulte o acesso e não permita o procedimento.</p>
<p>Por se tratar de células que não se regeneram, normalmente não é possível, como em outros órgãos, a retirada do tecido que envolve o tumor, denominada de área de segurança, para evitar a sua volta.</p>
<p>Principais Sintomas</p>
<p>Alguns dos principais sintomas apresentados são comuns a doenças mais simples. Por isso é importante que ao identificar esses sinais se procure orientação médica para que se possa fazer o diagnóstico correto.</p>
<ul>
	<li>Dor de cabeça;</li>
	<li>Vômitos;</li>
	<li>Náuseas;</li>
	<li>Convulsão;</li>
	<li>Alterações na fala, na marcha, no equilíbrio e na coordenação;</li>
	<li>Paralisia de nervos.</li>
</ul>
', N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/sistema_nervoso_central.jpg', NULL, NULL, CAST(N'2019-06-30T11:57:32.523' AS DateTime), N'1C2DACE7-253A-4D26-B562-7A086627457C')
INSERT [DoacaoMais].[Noticia] ([NoticiaId], [Titulo], [SubTitulo], [Conteudo], [UrlImagem], [DataPublicacao], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (14, N'Sarcomas P.M.', NULL, N'
<p>Os sarcomas são tipos de câncer relativamente raros nos adultos, somando apenas 1% de todos os tumores diagnosticados. Na infância, porém, os sarcomas de partes moles representam 6% do total de doenças neoplásicas e os sarcomas de parte óssea, 4%.</p>
<p>Os sarcomas de partes moles, na maioria das vezes, são do tipo rabdomiossarcoma, com origem em células musculares. A localização pode variar muito, afetando músculos, gorduras, tendões e nervos das regiões de cabeça e pescoço, dos órgãos genitais e urinários (geniturinário), braços e pernas (extremidades), órbitas, tronco e vias biliares.</p>
<p>Os principais tipos de sarcomas ósseos são o osteossarcoma, que afeta geralmente os ossos longos da região do fêmur, tíbia e úmero, e o sarcoma de Ewing, que podem afetar essas mesmas regiões do corpo, mas também ossos pequenos, como bacia, coluna vertebral e face. Essa doença foi descrita pela primeira vez em 1921 pelo pesquisador norte-americano James Ewing.</p>
<p>Os sarcomas ósseos costumam afetar mais os adolescentes, e os sarcomas de partes moles, as crianças, informa o dr. Paulo Taufi Maluf Júnior, oncologista pediátrico no Hospital Sírio-Libanês. “Os tumores ósseos caracterizam-se por dor intensa e aumento de volume das áreas afetadas, e os sarcomas de partes moles, cuja distribuição anatômica é universal, apresentam-se com sintomas peculiares conforme a área acometida”, compara o médico.</p>
', N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/sarcoma.jpeg', NULL, NULL, CAST(N'2019-06-30T11:57:41.617' AS DateTime), N'0331B276-3D5C-4971-B0F1-665EB82A3565')
INSERT [DoacaoMais].[Noticia] ([NoticiaId], [Titulo], [SubTitulo], [Conteudo], [UrlImagem], [DataPublicacao], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (15, N'T. Wilms', NULL, N'
<p>Os tumores de Wilms são difíceis de serem diagnosticados precocemente, porque muitas vezes podem se desenvolver sem causar quaisquer sintomas. As crianças podem parecer saudáveis e realizar suas atividades normalmente.</p>
<p>Inchaço ou uma massa dura no abdome. Esse é geralmente o primeiro sinal do tumor de Wilms, que pode ser observada pelos pais durante o banho ou ao vestir a criança. A massa é firme e muitas vezes grande o suficiente para ser sentida em ambos os lados da barriga. Ela geralmente não é dolorida, mas, em alguns casos, pode causar dor de barriga.</p> 
<br/><p>Outros possíveis sintomas</p><br/>
<br/><p>Algumas crianças com tumor de Wilms também podem ter:</p><br/>

<ul>
<li>Febre.</li>
<li>Náuseas.</li>
<li>Perda de apetite.</li>
<li>Falta de ar.</li>
<li>Constipação.</li>
<li>Sangue na urina.</li>
<ul>

<p>Os tumores de Wilms às vezes também podem causar pressão alta. Isso não costuma provocar sintomas por conta própria, mas em casos raros pode causar problemas, como sangramento ocular ou até mesmo alteração da consciência.</p>
<p>Muitos dos sinais e sintomas acima são mais susceptíveis de serem provocados por outras patologias. Ainda assim, se o seu filho apresentar algum destes sintomas, consulte o médico imediatamente para que a causa possa ser diagnosticada e, se necessário, iniciado o tratamento.</p>

', N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/tumor_de_wilms.jpg', NULL, NULL, CAST(N'2019-06-30T11:57:56.820' AS DateTime), N'A7A4169D-1650-4E99-A3A8-B8F87176D60F')
INSERT [DoacaoMais].[Noticia] ([NoticiaId], [Titulo], [SubTitulo], [Conteudo], [UrlImagem], [DataPublicacao], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (16, N'T. Ósseos', NULL, N'<p>Os tumores ósseos ocorrem mais frequentemente em crianças mais velhas e em adolescentes, mas podem se desenvolver a qualquer idade. Eles representam cerca de 3% dos cânceres infantis. O tumor ósseo é diferente da metástase óssea, que se originou de um tumor que se desenvolveu em outro lugar do corpo e se disseminou para os ossos. A metástase óssea é mais comum do que o tumor ósseo. Os 2 tipos principais de tumores ósseos que ocorrem em crianças são osteossarcoma e sarcoma de Ewing</p>.
<ul>
	<li>Osteossarcoma - É mais comum em adolescentes e, normalmente, desenvolve-se em áreas onde o osso está em crescimento, como os ossos longos das pernas ou braços. Muitas vezes provoca dor que piora à noite ou com atividades. Ele pode também causar inchaço na região onde está localizado o osso.</li>
	<li>Tumor de Ewing. É um tipo de câncer ósseo menos comum. É mais frequente em adolescentes e também pode provocar dor óssea. Os locais mais comuns são os ossos da pelve, tórax ou no meio dos ossos da perna.</li>
</ul>
', N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/ossos_doentes.jpg', NULL, NULL, CAST(N'2019-06-30T11:58:08.333' AS DateTime), N'C5F05713-AD1C-4DD5-A56E-A14B5D9A59EC')
INSERT [DoacaoMais].[Noticia] ([NoticiaId], [Titulo], [SubTitulo], [Conteudo], [UrlImagem], [DataPublicacao], [CacccId], [DataCadastro], [IdentificadorUnico]) VALUES (17, N'Outros', NULL, N'<p>Retinoblastoma<p/>
<p>O retinoblastoma é o tipo mais comum de câncer que acomete os olhos na infância. Ele é um tumor maligno embrionário, originário de células da retina, a parte do olho responsável pela visão. Pode estar presente já ao nascimento ou aparecer até os cinco anos de idade.</p>
<p>O retinoblastoma pode ser hereditário ou não e afetar os dois olhos ou apenas um deles. Se forem bilaterais, os casos são sempre hereditários. Apesar de ser uma doença rara (são cerca de 400 novos casos de retinoblastoma por ano, segundo o Ministério da Saúde), é bastante agressivo, pode provocar cegueira e até levar o paciente à morte.</p>
<p>Atualmente, cerca de 50% dos casos diagnosticados no país são identificados tardiamente, o que reduz as chances de cura do paciente. Quando diagnosticado precocemente, entretanto, o retinoblastoma é uma doença altamente curável, inclusive com a preservação da visão e da vida da criança.</p>
<p>Tumores do Fígado</p>
<p>Os tumores hepáticos se dividem em benignos e malignos conforme seu comportamento clínico. Os tumores benignos não são capazes de se disseminar para outras regiões, enquanto os malignos podem enviar metástases para o próprio fígado, para linfonodos, para os ossos e outros órgãos.</p>
<p>Dentre os tumores benignos, destacam-se os hemangiomas, a Hiperplasia Nodular Focal (HNF) e os adenomas. Os cistos são outro tipo de lesões hepáticas comuns e de comportamento benigno.</p>
<p>Os tumores malignos, por sua vez, dividem-se em primários e metastáticos.</p>
<p>Os tumores primários surgem das células do próprio fígado (hepatocarcinoma) ou dos canais da bile que existem no interior do órgão (colangiocarcinomas). Angiossarcomas e hepatoblastomas são outros tipos raros de tumores hepáticos.</p>
<p>O hepatocarcinoma é o tumor maligno que surge das células do fígado, chamados hepatócitos. Sua incidência no mundo todo é muito alta, com cerca de 500.000 novos casos diagnosticados ao ano.</p>
<p>Os tumores metastáticos são muito mais frequentes que os tumores primários, pois o fígado é uma sede comum de metástases dos vários tipos de cânceres de praticamente todos os órgãos do corpo humano. As metástases mais comuns são as de câncer de intestino (cólon e reto) e de tumores neuroendócrinos, cujo tratamento sempre que possível é cirúrgico. Recentemente, casos selecionados de metástases hepáticas de outros órgãos, tais como sarcomas, tumores de rim, mama, melanoma, papila duodenal, tumores ginecológicos, e até mesmo de câncer gástrico têm sido considerados para tratamento cirúrgico.</p>
', N'http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/retinoblastoma.jpg', NULL, NULL, CAST(N'2019-06-30T11:58:53.350' AS DateTime), N'DB7B3937-D687-4EE6-BC56-3F15BADA48B3')


SET IDENTITY_INSERT [DoacaoMais].[Noticia] OFF
SET IDENTITY_INSERT [DoacaoMais].[Notificacao] ON 

INSERT [DoacaoMais].[Notificacao] ([NotificacaoId], [Titulo], [Descricao], [Conteudo], [DataInicial], [DataFinal], [Ativa], [DataCadastro], [IdentificadorUnico]) VALUES (1, N'Menina de cinco anos luta contra câncer e precisa de leite especial', N'Menina de cinco anos luta contra câncer e precisa de leite especial', N'Após filha caçula passar por cirurgia para combater o câncer e ficar paraplégica e sem se comunicar, os pais desempregados pedem ajuda para sobreviver na Capital. Eles trocaram o interior por Campo Grande para salvar a filha.', CAST(N'2019-06-29T10:36:03.113' AS DateTime), CAST(N'2019-07-02T10:36:03.113' AS DateTime), 1, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'ccd5ba4a-81a4-47d6-9fad-416fae8126b6')
INSERT [DoacaoMais].[Notificacao] ([NotificacaoId], [Titulo], [Descricao], [Conteudo], [DataInicial], [DataFinal], [Ativa], [DataCadastro], [IdentificadorUnico]) VALUES (2, N'Porque nós o usamos', N'É um fato conhecido de todos que um leitor se distrairá?', N'É um fato conhecido de todos que um leitor se distrairá com o conteúdo de texto legível de uma página quando estiver examinando sua diagramação', CAST(N'2019-07-04T10:36:03.113' AS DateTime), CAST(N'2019-07-09T10:36:03.113' AS DateTime), 1, CAST(N'2019-06-30T10:36:03.287' AS DateTime), N'6ee69b60-f16d-42b0-b23d-c90d9f45ad32')


SET IDENTITY_INSERT [DoacaoMais].[Notificacao] OFF
INSERT [DoacaoMais].[NotificacaoDispositivo] ([NotificacaoId], [DispositivoId]) VALUES (1, 1)
INSERT [DoacaoMais].[NotificacaoDispositivo] ([NotificacaoId], [DispositivoId]) VALUES (2, 2)


-------------------------------------------------INSERT SECURITY-------------------------------------------------
GO
INSERT [Security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'57f3b74e-1b2f-45af-997b-2bb377b5a539', N'Administrador', N'ADMINISTRADOR', N'b1a07398-c61e-4d87-831f-7d12e1160df2')
INSERT [Security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'bb77857f-f56a-404f-adfe-a3bf93c4b185', N'Blog', N'BLOG', N'd3566715-27ac-4ab6-8591-16437fb3377c')
INSERT [Security].[Role] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'c7fc584e-c49b-47e3-a76a-14c197d6bc03', N'Sistemas', N'SISTEMAS', N'798a7180-fff8-4fdf-b4af-c561775af4f7')
GO
SET IDENTITY_INSERT [Security].[RoleClaim] ON 

INSERT [Security].[RoleClaim] ([Id], [RoleId], [ClaimType], [ClaimValue]) VALUES (1, N'57f3b74e-1b2f-45af-997b-2bb377b5a539', N'http://schemas.microsoft.com/ws/2008/06/identity/claims/role', N'Administrador')
SET IDENTITY_INSERT [Security].[RoleClaim] OFF
GO
INSERT [Security].[User] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'86102f4e-fb93-4b20-84b1-b7f5a38fe373', N'adilsonlustoza@gmail.com', N'ADILSONLUSTOZA@GMAIL.COM', N'adilsonlustoza@gmail.com', N'ADILSONLUSTOZA@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAENT0mkP9ibwY2SjhxSPWr+D9Qu316ZEo3PkqK+yb1DbPZ6zYsEXBJ9tNTK2qQYMmJw==', N'PWNTJIJLTQRVFFAHAOW3VW4PGDQMT3ZM', N'bcfc8f88-49ce-4e14-ae0b-55d87e7e5b6c', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [Security].[UserClaim] ON 

INSERT [Security].[UserClaim] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (1, N'86102f4e-fb93-4b20-84b1-b7f5a38fe373', N'http://schemas.microsoft.com/ws/2008/06/identity/claims/role', N'Administrador')
SET IDENTITY_INSERT [Security].[UserClaim] OFF
GO
INSERT [Security].[UserRole] ([UserId], [RoleId]) VALUES (N'86102f4e-fb93-4b20-84b1-b7f5a38fe373', N'57f3b74e-1b2f-45af-997b-2bb377b5a539')
GO

ALTER TABLE [DoacaoMais].[Bazar]  WITH CHECK ADD  CONSTRAINT [FK_Bazar_Caccc_CacccId] FOREIGN KEY([CacccId])
REFERENCES [DoacaoMais].[Caccc] ([CacccId])
GO
ALTER TABLE [DoacaoMais].[Bazar] CHECK CONSTRAINT [FK_Bazar_Caccc_CacccId]
GO
ALTER TABLE [DoacaoMais].[Boletim]  WITH CHECK ADD  CONSTRAINT [FK_Boletim_Caccc_CacccId] FOREIGN KEY([CacccId])
REFERENCES [DoacaoMais].[Caccc] ([CacccId])
GO
ALTER TABLE [DoacaoMais].[Boletim] CHECK CONSTRAINT [FK_Boletim_Caccc_CacccId]
GO
ALTER TABLE [DoacaoMais].[ContaBancaria]  WITH CHECK ADD  CONSTRAINT [FK_ContaBancaria_Caccc_CacccId] FOREIGN KEY([CacccId])
REFERENCES [DoacaoMais].[Caccc] ([CacccId])
GO
ALTER TABLE [DoacaoMais].[ContaBancaria] CHECK CONSTRAINT [FK_ContaBancaria_Caccc_CacccId]
GO
ALTER TABLE [DoacaoMais].[Conteudo]  WITH CHECK ADD  CONSTRAINT [FK_Conteudo_Caccc_CacccId] FOREIGN KEY([CacccId])
REFERENCES [DoacaoMais].[Caccc] ([CacccId])
GO
ALTER TABLE [DoacaoMais].[Conteudo] CHECK CONSTRAINT [FK_Conteudo_Caccc_CacccId]
GO
ALTER TABLE [DoacaoMais].[Dispositivo]  WITH CHECK ADD  CONSTRAINT [FK_Dispositivo_Usuario_UsuarioId] FOREIGN KEY([UsuarioId])
REFERENCES [DoacaoMais].[Usuario] ([UsuarioId])
GO
ALTER TABLE [DoacaoMais].[Dispositivo] CHECK CONSTRAINT [FK_Dispositivo_Usuario_UsuarioId]
GO
ALTER TABLE [DoacaoMais].[Noticia]  WITH CHECK ADD  CONSTRAINT [FK_Noticia_Caccc_CacccId] FOREIGN KEY([CacccId])
REFERENCES [DoacaoMais].[Caccc] ([CacccId])
GO
ALTER TABLE [DoacaoMais].[Noticia] CHECK CONSTRAINT [FK_Noticia_Caccc_CacccId]
GO
ALTER TABLE [DoacaoMais].[Notificacao]  WITH CHECK ADD  CONSTRAINT [FK_Notificacao_Boletim_BoletimId] FOREIGN KEY([BoletimId])
REFERENCES [DoacaoMais].[Boletim] ([BoletimId])
GO
ALTER TABLE [DoacaoMais].[Notificacao] CHECK CONSTRAINT [FK_Notificacao_Boletim_BoletimId]
GO
ALTER TABLE [DoacaoMais].[NotificacaoDispositivo]  WITH CHECK ADD  CONSTRAINT [FK_NotificacaoDispositivo_Dispositivo_DispositivoId] FOREIGN KEY([DispositivoId])
REFERENCES [DoacaoMais].[Dispositivo] ([DispositivoId])
ON DELETE CASCADE
GO
ALTER TABLE [DoacaoMais].[NotificacaoDispositivo] CHECK CONSTRAINT [FK_NotificacaoDispositivo_Dispositivo_DispositivoId]
GO
ALTER TABLE [DoacaoMais].[NotificacaoDispositivo]  WITH CHECK ADD  CONSTRAINT [FK_NotificacaoDispositivo_Notificacao_NotificacaoId] FOREIGN KEY([NotificacaoId])
REFERENCES [DoacaoMais].[Notificacao] ([NotificacaoId])
ON DELETE CASCADE
GO
ALTER TABLE [DoacaoMais].[NotificacaoDispositivo] CHECK CONSTRAINT [FK_NotificacaoDispositivo_Notificacao_NotificacaoId]
GO
ALTER TABLE [DoacaoMais].[Paciente]  WITH CHECK ADD  CONSTRAINT [FK_Paciente_Caccc_CacccId] FOREIGN KEY([CacccId])
REFERENCES [DoacaoMais].[Caccc] ([CacccId])
GO
ALTER TABLE [DoacaoMais].[Paciente] CHECK CONSTRAINT [FK_Paciente_Caccc_CacccId]
GO
ALTER TABLE [Security].[RoleClaim]  WITH CHECK ADD  CONSTRAINT [FK_RoleClaim_Role_RoleId] FOREIGN KEY([RoleId])
REFERENCES [Security].[Role] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [Security].[RoleClaim] CHECK CONSTRAINT [FK_RoleClaim_Role_RoleId]
GO
ALTER TABLE [Security].[UserClaim]  WITH CHECK ADD  CONSTRAINT [FK_UserClaim_User_UserId] FOREIGN KEY([UserId])
REFERENCES [Security].[User] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [Security].[UserClaim] CHECK CONSTRAINT [FK_UserClaim_User_UserId]
GO
ALTER TABLE [Security].[UserLogin]  WITH CHECK ADD  CONSTRAINT [FK_UserLogin_User_UserId] FOREIGN KEY([UserId])
REFERENCES [Security].[User] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [Security].[UserLogin] CHECK CONSTRAINT [FK_UserLogin_User_UserId]
GO
ALTER TABLE [Security].[UserRole]  WITH CHECK ADD  CONSTRAINT [FK_UserRole_Role_RoleId] FOREIGN KEY([RoleId])
REFERENCES [Security].[Role] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [Security].[UserRole] CHECK CONSTRAINT [FK_UserRole_Role_RoleId]
GO
ALTER TABLE [Security].[UserRole]  WITH CHECK ADD  CONSTRAINT [FK_UserRole_User_UserId] FOREIGN KEY([UserId])
REFERENCES [Security].[User] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [Security].[UserRole] CHECK CONSTRAINT [FK_UserRole_User_UserId]
GO
ALTER TABLE [Security].[UserToken]  WITH CHECK ADD  CONSTRAINT [FK_UserToken_User_UserId] FOREIGN KEY([UserId])
REFERENCES [Security].[User] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [Security].[UserToken] CHECK CONSTRAINT [FK_UserToken_User_UserId]
GO
