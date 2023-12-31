USE [Generacion23]
GO
/****** Object:  Table [dbo].[Grupo]    Script Date: 21/12/2023 11:28:29 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grupo](
	[CveGpo] [varchar](50) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Grupo] PRIMARY KEY CLUSTERED 
(
	[CveGpo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos1]    Script Date: 21/12/2023 11:28:30 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos1](
	[Productos] [varchar](50) NOT NULL,
	[CveGpo] [varchar](50) NULL,
	[Estatus] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
	[Auto] [varchar](50) NULL,
	[AñoInicio] [int] NULL,
	[AñoFin] [int] NULL,
	[Proveedor] [varchar](50) NULL,
	[Costo] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Productos1] PRIMARY KEY CLUSTERED 
(
	[Productos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Grupo] ([CveGpo], [Descripcion]) VALUES (N'ATC', N'ATENCION A CLIENTES')
INSERT [dbo].[Grupo] ([CveGpo], [Descripcion]) VALUES (N'CAR', N'CARBURACION')
INSERT [dbo].[Grupo] ([CveGpo], [Descripcion]) VALUES (N'CRR', N'CARROCERIA')
INSERT [dbo].[Grupo] ([CveGpo], [Descripcion]) VALUES (N'ENC', N'ENCENDIDO')
INSERT [dbo].[Grupo] ([CveGpo], [Descripcion]) VALUES (N'ENF', N'ENFRIAMIENTO')
GO
INSERT [dbo].[Productos1] ([Productos], [CveGpo], [Estatus], [Descripcion], [Auto], [AñoInicio], [AñoFin], [Proveedor], [Costo]) VALUES (N'0-001-107-020', N'ATC', N'*', N'MARCHA COMPLETA', N'A3', 93, 99, N'BOE', CAST(2234.00 AS Decimal(18, 2)))
INSERT [dbo].[Productos1] ([Productos], [CveGpo], [Estatus], [Descripcion], [Auto], [AñoInicio], [AñoFin], [Proveedor], [Costo]) VALUES (N'0-001-123-012', N'ATC', N'DFD', N'MARCHA COMPLETA', N'href', 25, 36, N'BRU', CAST(1235.25 AS Decimal(18, 2)))
INSERT [dbo].[Productos1] ([Productos], [CveGpo], [Estatus], [Descripcion], [Auto], [AñoInicio], [AñoFin], [Proveedor], [Costo]) VALUES (N'0-001-125-039', N'ENC', N'*', N'MARCHA COMPLETA', N'A3', 93, 99, N'BOE', CAST(3698.23 AS Decimal(18, 2)))
INSERT [dbo].[Productos1] ([Productos], [CveGpo], [Estatus], [Descripcion], [Auto], [AñoInicio], [AñoFin], [Proveedor], [Costo]) VALUES (N'0-040-402-001', N'CAR', N'*', N'BOBINA ENCENDIDO ELEC', N'A3', 93, 99, N'BOE', CAST(2125.57 AS Decimal(18, 2)))
INSERT [dbo].[Productos1] ([Productos], [CveGpo], [Estatus], [Descripcion], [Auto], [AñoInicio], [AñoFin], [Proveedor], [Costo]) VALUES (N'0-101-302-111', N'CAR', N' ', N'GENERADOR', N'SEDAN', 70, 93, N'BOE', CAST(1872.00 AS Decimal(18, 2)))
INSERT [dbo].[Productos1] ([Productos], [CveGpo], [Estatus], [Descripcion], [Auto], [AñoInicio], [AñoFin], [Proveedor], [Costo]) VALUES (N'0-120-488-306', N'ENC', N'*', N'ALTERNADOR', N'TSURU', 93, 0, N'BOS', CAST(1512.00 AS Decimal(18, 2)))
INSERT [dbo].[Productos1] ([Productos], [CveGpo], [Estatus], [Descripcion], [Auto], [AñoInicio], [AñoFin], [Proveedor], [Costo]) VALUES (N'1-001-123-012', N'ATC', N'DFD', N'MARCHA COMPLETA', N'few', 23, 25, N'BRU', CAST(1586.23 AS Decimal(18, 2)))
INSERT [dbo].[Productos1] ([Productos], [CveGpo], [Estatus], [Descripcion], [Auto], [AñoInicio], [AñoFin], [Proveedor], [Costo]) VALUES (N'15-36-96', N'CAR', N'Lolo', N'GENERADOR', N'href', 36, 41, N'wef', CAST(36.24 AS Decimal(18, 2)))
GO
ALTER TABLE [dbo].[Productos1]  WITH CHECK ADD  CONSTRAINT [FK_Productos1_Grupo] FOREIGN KEY([CveGpo])
REFERENCES [dbo].[Grupo] ([CveGpo])
GO
ALTER TABLE [dbo].[Productos1] CHECK CONSTRAINT [FK_Productos1_Grupo]
GO
