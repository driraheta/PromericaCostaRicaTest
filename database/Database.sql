USE [demo]
GO
/****** Object:  Table [dbo].[Make]    Script Date: 17/08/2021 09:26:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Make](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
	[country] [varchar](1500) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pattern]    Script Date: 17/08/2021 09:26:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pattern](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[make_id] [int] NULL,
	[name] [varchar](200) NOT NULL,
	[color] [varchar](100) NOT NULL,
	[year] [int] NOT NULL,
	[doors] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Make] ON 

INSERT [dbo].[Make] ([id], [name], [country]) VALUES (1, N'TOYOTA', N'JAPON')
INSERT [dbo].[Make] ([id], [name], [country]) VALUES (2, N'HONDA', N'NOLOSE')
INSERT [dbo].[Make] ([id], [name], [country]) VALUES (3, N'MAZDA', N'JAPON')
INSERT [dbo].[Make] ([id], [name], [country]) VALUES (4, N'HYUNDAI', N'COREA DEL SUR')
INSERT [dbo].[Make] ([id], [name], [country]) VALUES (5, N'AUDI', N'ALEMANIA')
INSERT [dbo].[Make] ([id], [name], [country]) VALUES (6, N'MERCEDEZ BENZ', N'ALEMANIA')
INSERT [dbo].[Make] ([id], [name], [country]) VALUES (7, N'KIA', N'COREA DEL SUR')
INSERT [dbo].[Make] ([id], [name], [country]) VALUES (8, N'BMW', N'ALEMANIA')
INSERT [dbo].[Make] ([id], [name], [country]) VALUES (9, N'BENTLEY', N'REINO UNIDO')
INSERT [dbo].[Make] ([id], [name], [country]) VALUES (10, N'TESLA', N'AAAA')
SET IDENTITY_INSERT [dbo].[Make] OFF
GO
SET IDENTITY_INSERT [dbo].[Pattern] ON 

INSERT [dbo].[Pattern] ([id], [make_id], [name], [color], [year], [doors]) VALUES (2, 1, N'COROLLA', N'NEGRO', 2015, 4)
INSERT [dbo].[Pattern] ([id], [make_id], [name], [color], [year], [doors]) VALUES (3, 1, N'COROLLA', N'BLANCO', 2018, 4)
INSERT [dbo].[Pattern] ([id], [make_id], [name], [color], [year], [doors]) VALUES (4, 1, N'COROLLA', N'AZUL', 204, 4)
INSERT [dbo].[Pattern] ([id], [make_id], [name], [color], [year], [doors]) VALUES (5, 1, N'COROLLA', N'ROJO', 20120, 4)
INSERT [dbo].[Pattern] ([id], [make_id], [name], [color], [year], [doors]) VALUES (6, 1, N'YARIS', N'NEGRO', 2009, 4)
INSERT [dbo].[Pattern] ([id], [make_id], [name], [color], [year], [doors]) VALUES (7, 1, N'YARIS', N'NEGRO', 2015, 4)
INSERT [dbo].[Pattern] ([id], [make_id], [name], [color], [year], [doors]) VALUES (8, 2, N'CIVIC', N'OCRE', 2009, 4)
INSERT [dbo].[Pattern] ([id], [make_id], [name], [color], [year], [doors]) VALUES (9, 2, N'CIVIC', N'AZUL', 2013, 2)
INSERT [dbo].[Pattern] ([id], [make_id], [name], [color], [year], [doors]) VALUES (10, 2, N'CIVIC', N'BLANCO', 2015, 2)
INSERT [dbo].[Pattern] ([id], [make_id], [name], [color], [year], [doors]) VALUES (11, 2, N'CITY', N'BLANCO', 2016, 4)
INSERT [dbo].[Pattern] ([id], [make_id], [name], [color], [year], [doors]) VALUES (12, 2, N'CITY', N'GRIS', 2018, 4)
INSERT [dbo].[Pattern] ([id], [make_id], [name], [color], [year], [doors]) VALUES (13, 3, N'3', N'GRIS', 2020, 4)
INSERT [dbo].[Pattern] ([id], [make_id], [name], [color], [year], [doors]) VALUES (14, 3, N'3', N'NEGRO', 2018, 4)
INSERT [dbo].[Pattern] ([id], [make_id], [name], [color], [year], [doors]) VALUES (15, 3, N'3', N'ROJO', 2010, 4)
INSERT [dbo].[Pattern] ([id], [make_id], [name], [color], [year], [doors]) VALUES (16, 3, N'CX-3', N'ROJO', 2018, 4)
INSERT [dbo].[Pattern] ([id], [make_id], [name], [color], [year], [doors]) VALUES (17, 3, N'CX-5', N'NEGRO', 2020, 4)
INSERT [dbo].[Pattern] ([id], [make_id], [name], [color], [year], [doors]) VALUES (18, 4, N'ACCENT', N'GRIS', 2020, 4)
INSERT [dbo].[Pattern] ([id], [make_id], [name], [color], [year], [doors]) VALUES (19, 4, N'ELANTRA', N'BLANCO', 2018, 4)
INSERT [dbo].[Pattern] ([id], [make_id], [name], [color], [year], [doors]) VALUES (21, 7, N'RIO', N'NEGRO', 2014, 4)
INSERT [dbo].[Pattern] ([id], [make_id], [name], [color], [year], [doors]) VALUES (22, 7, N'RIO', N'ROJO', 2018, 4)
INSERT [dbo].[Pattern] ([id], [make_id], [name], [color], [year], [doors]) VALUES (23, 7, N'FORTE', N'AZUL', 2016, 4)
INSERT [dbo].[Pattern] ([id], [make_id], [name], [color], [year], [doors]) VALUES (24, 7, N'FORTE', N'NEGRO', 2012, 2)
SET IDENTITY_INSERT [dbo].[Pattern] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [uq_pattern]    Script Date: 17/08/2021 09:26:49 p. m. ******/
ALTER TABLE [dbo].[Pattern] ADD  CONSTRAINT [uq_pattern] UNIQUE NONCLUSTERED 
(
	[make_id] ASC,
	[name] ASC,
	[year] ASC,
	[doors] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Pattern]  WITH CHECK ADD FOREIGN KEY([make_id])
REFERENCES [dbo].[Make] ([id])
GO
/****** Object:  StoredProcedure [dbo].[sp_deletepattern]    Script Date: 17/08/2021 09:26:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_deletepattern]
    @Id int = null
AS
BEGIN

set NOCOUNT on

IF @Id is not null
BEGIN
    DELETE
    FROM Pattern 
    WHERE id = @Id
END


END
GO
/****** Object:  StoredProcedure [dbo].[sp_updatemake]    Script Date: 17/08/2021 09:26:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[sp_updatemake]
    @Id int = null,
    @Name varchar(100),
    @Country varchar(150)
AS
BEGIN

set NOCOUNT on

IF @Id is not null
BEGIN
    UPDATE Make 
    SET name = @Name, 
    country = @Country 
    WHERE id = @Id
END


END
GO
