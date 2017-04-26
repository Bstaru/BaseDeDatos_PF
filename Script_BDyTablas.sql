USE [master]
GO
/****** Object:  Database [ProyectoFinal_BD]    Script Date: 25/05/2016 02:27:45 p. m. ******/
CREATE DATABASE [ProyectoFinal_BD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProyectoFinal_BD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ProyectoFinal_BD.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ProyectoFinal_BD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ProyectoFinal_BD_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ProyectoFinal_BD] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProyectoFinal_BD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProyectoFinal_BD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProyectoFinal_BD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProyectoFinal_BD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProyectoFinal_BD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProyectoFinal_BD] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProyectoFinal_BD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProyectoFinal_BD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProyectoFinal_BD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProyectoFinal_BD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProyectoFinal_BD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProyectoFinal_BD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProyectoFinal_BD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProyectoFinal_BD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProyectoFinal_BD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProyectoFinal_BD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProyectoFinal_BD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProyectoFinal_BD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProyectoFinal_BD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProyectoFinal_BD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProyectoFinal_BD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProyectoFinal_BD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProyectoFinal_BD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProyectoFinal_BD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProyectoFinal_BD] SET  MULTI_USER 
GO
ALTER DATABASE [ProyectoFinal_BD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProyectoFinal_BD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProyectoFinal_BD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProyectoFinal_BD] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ProyectoFinal_BD] SET DELAYED_DURABILITY = DISABLED 
GO

USE [ProyectoFinal_BD]
GO

/****** Object:  Table [dbo].[tblEmpleado]    Script Date: 25/05/2016 03:03:44 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblEmpleado](
	[IdEmp] [int] IDENTITY(1,1) NOT NULL,
	[NomEmp] [varchar](20) NULL,
	[APEmp] [varchar](20) NULL,
	[AMEmp] [varchar](20) NULL,
	[FeNacEmp] [date] NULL,
	[FeIngEmp] [date] NULL,
	[IdPuesto] [int] NULL,
	[IdSubD] [int] NULL,
	[IdRol] [int] NULL,
	[ActivoEmp] [bit] NULL,
	[Email] [varchar](50) NULL,
	[ContEmp] [varchar](50) NULL,
 CONSTRAINT [PK_tblEmpleado] PRIMARY KEY CLUSTERED 
(
	[IdEmp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tblEmpleado]  WITH CHECK ADD  CONSTRAINT [FK_tblEmpleado_tblPuesto2] FOREIGN KEY([IdPuesto])
REFERENCES [dbo].[tblPuesto2] ([IdPuesto])
GO

ALTER TABLE [dbo].[tblEmpleado] CHECK CONSTRAINT [FK_tblEmpleado_tblPuesto2]
GO

ALTER TABLE [dbo].[tblEmpleado]  WITH CHECK ADD  CONSTRAINT [FK_tblEmpleado_tblRol] FOREIGN KEY([IdRol])
REFERENCES [dbo].[tblRol] ([IdRol])
GO

ALTER TABLE [dbo].[tblEmpleado] CHECK CONSTRAINT [FK_tblEmpleado_tblRol]
GO

ALTER TABLE [dbo].[tblEmpleado]  WITH CHECK ADD  CONSTRAINT [FK_tblEmpleado_tblSubdireccion] FOREIGN KEY([IdSubD])
REFERENCES [dbo].[tblSubdireccion] ([IdSubD])
GO

ALTER TABLE [dbo].[tblEmpleado] CHECK CONSTRAINT [FK_tblEmpleado_tblSubdireccion]
GO

USE [ProyectoFinal_BD]
GO

/****** Object:  Table [dbo].[tblFactura]    Script Date: 25/05/2016 03:28:26 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblFactura](
	[IdFact] [int] IDENTITY(1,1) NOT NULL,
	[TotalFact] [float] NULL,
	[IdEmp] [int] NULL,
	[IdProv] [int] NULL,
	[IdImp] [int] NULL,
 CONSTRAINT [PK_tblFactura] PRIMARY KEY CLUSTERED 
(
	[IdFact] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tblFactura]  WITH CHECK ADD  CONSTRAINT [FK_tblFactura_tblEmpleado] FOREIGN KEY([IdEmp])
REFERENCES [dbo].[tblEmpleado] ([IdEmp])
GO

ALTER TABLE [dbo].[tblFactura] CHECK CONSTRAINT [FK_tblFactura_tblEmpleado]
GO

ALTER TABLE [dbo].[tblFactura]  WITH CHECK ADD  CONSTRAINT [FK_tblFactura_tblImpuesto] FOREIGN KEY([IdImp])
REFERENCES [dbo].[tblImpuesto] ([IdImp])
GO

ALTER TABLE [dbo].[tblFactura] CHECK CONSTRAINT [FK_tblFactura_tblImpuesto]
GO

ALTER TABLE [dbo].[tblFactura]  WITH CHECK ADD  CONSTRAINT [FK_tblFactura_tblProveedor] FOREIGN KEY([IdProv])
REFERENCES [dbo].[tblProveedor] ([IdProv])
GO

ALTER TABLE [dbo].[tblFactura] CHECK CONSTRAINT [FK_tblFactura_tblProveedor]
GO


USE [ProyectoFinal_BD]
GO

/****** Object:  Table [dbo].[tblImpuesto]    Script Date: 25/05/2016 03:29:05 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblImpuesto](
	[IdImp] [int] IDENTITY(1,1) NOT NULL,
	[IVAImp] [float] NULL,
 CONSTRAINT [PK_tblImpuesto] PRIMARY KEY CLUSTERED 
(
	[IdImp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [ProyectoFinal_BD]
GO

/****** Object:  Table [dbo].[tblProveedor]    Script Date: 25/05/2016 03:29:22 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblProveedor](
	[IdProv] [int] IDENTITY(1,1) NOT NULL,
	[NomProv] [varchar](20) NULL,
	[ActivoProv] [bit] NULL,
 CONSTRAINT [PK_tblProveedor] PRIMARY KEY CLUSTERED 
(
	[IdProv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


USE [ProyectoFinal_BD]
GO

/****** Object:  Table [dbo].[tblPuesto2]    Script Date: 25/05/2016 03:29:33 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblPuesto2](
	[IdPuesto] [int] IDENTITY(1,1) NOT NULL,
	[NomPuesto] [varchar](50) NULL,
	[HorarioPuesto] [varchar](50) NULL,
	[SalarioPuesto] [float] NULL,
	[IdSuperior] [int] NULL,
 CONSTRAINT [PK_tblPuesto2] PRIMARY KEY CLUSTERED 
(
	[IdPuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tblPuesto2]  WITH CHECK ADD  CONSTRAINT [FK_tblPuesto2_tblPuesto2] FOREIGN KEY([IdSuperior])
REFERENCES [dbo].[tblPuesto2] ([IdPuesto])
GO

ALTER TABLE [dbo].[tblPuesto2] CHECK CONSTRAINT [FK_tblPuesto2_tblPuesto2]
GO


USE [ProyectoFinal_BD]
GO

/****** Object:  Table [dbo].[tblRol]    Script Date: 25/05/2016 03:29:46 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblRol](
	[IdRol] [int] IDENTITY(1,1) NOT NULL,
	[NomRol] [varchar](20) NULL,
 CONSTRAINT [PK_tblRol] PRIMARY KEY CLUSTERED 
(
	[IdRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


USE [ProyectoFinal_BD]
GO

/****** Object:  Table [dbo].[tblSubD-Emp]    Script Date: 25/05/2016 03:30:16 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblSubD-Emp](
	[IdSubD] [int] NULL,
	[IdEmp] [int] NULL
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tblSubD-Emp]  WITH CHECK ADD  CONSTRAINT [FK_tblSubD-Emp_tblEmpleado] FOREIGN KEY([IdEmp])
REFERENCES [dbo].[tblEmpleado] ([IdEmp])
GO

ALTER TABLE [dbo].[tblSubD-Emp] CHECK CONSTRAINT [FK_tblSubD-Emp_tblEmpleado]
GO

ALTER TABLE [dbo].[tblSubD-Emp]  WITH CHECK ADD  CONSTRAINT [FK_tblSubD-Emp_tblSubdireccion] FOREIGN KEY([IdSubD])
REFERENCES [dbo].[tblSubdireccion] ([IdSubD])
GO

ALTER TABLE [dbo].[tblSubD-Emp] CHECK CONSTRAINT [FK_tblSubD-Emp_tblSubdireccion]
GO


USE [ProyectoFinal_BD]
GO

/****** Object:  Table [dbo].[tblSubdireccion]    Script Date: 25/05/2016 03:30:22 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblSubdireccion](
	[IdSubD] [int] IDENTITY(1,1) NOT NULL,
	[NomSubD] [varchar](20) NULL,
	[IdEmpEncar] [int] NULL,
	[ActivoSD] [bit] NULL,
 CONSTRAINT [PK_tblSubdireccion] PRIMARY KEY CLUSTERED 
(
	[IdSubD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tblSubdireccion]  WITH CHECK ADD  CONSTRAINT [FK_tblSubdireccion_tblEmpleado] FOREIGN KEY([IdEmpEncar])
REFERENCES [dbo].[tblEmpleado] ([IdEmp])
GO

ALTER TABLE [dbo].[tblSubdireccion] CHECK CONSTRAINT [FK_tblSubdireccion_tblEmpleado]
GO


USE [master]
GO
ALTER DATABASE [ProyectoFinal_BD] SET  READ_WRITE 
GO
