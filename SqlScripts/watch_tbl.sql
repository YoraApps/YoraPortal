USE [YoraEcommerce]
GO
/****** Object:  Table [dbo].[Watch]    Script Date: 05-07-2018 09:51:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Watch](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Price] [bigint] NULL,
	[Brand] [varchar](50) NULL,
 CONSTRAINT [PK_Watche] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Watch] ON 

INSERT [dbo].[Watch] ([ID], [Price], [Brand]) VALUES (3, 3500, N'Diesel')
INSERT [dbo].[Watch] ([ID], [Price], [Brand]) VALUES (4, 2000, N'Seiko Bulova')
INSERT [dbo].[Watch] ([ID], [Price], [Brand]) VALUES (5, 2500, N' Casio')
INSERT [dbo].[Watch] ([ID], [Price], [Brand]) VALUES (6, 2000, N'fossil')
INSERT [dbo].[Watch] ([ID], [Price], [Brand]) VALUES (8, 0, NULL)
INSERT [dbo].[Watch] ([ID], [Price], [Brand]) VALUES (9, 34567, N'police')
SET IDENTITY_INSERT [dbo].[Watch] OFF
