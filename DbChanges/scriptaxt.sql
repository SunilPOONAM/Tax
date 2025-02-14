USE [TaxService]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 14-02-2022 17:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [bigint] IDENTITY(1,1) NOT NULL,
	[CustomerCode] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 14-02-2022 17:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Role] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 14-02-2022 17:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[RoleId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerID], [CustomerCode], [Name], [Email], [CreatedDate], [ModifiedDate]) VALUES (1, N'75a68a29-c627-45a4-93e5-e962ad1eb794', N'Test Customer', N'test.nextolive2@gmail.com', CAST(N'2021-01-29T15:03:53.617' AS DateTime), CAST(N'2021-01-29T15:03:53.617' AS DateTime))
INSERT [dbo].[Customers] ([CustomerID], [CustomerCode], [Name], [Email], [CreatedDate], [ModifiedDate]) VALUES (2, N'99213bfb-7609-49d8-925a-84dac033288d', N'TRX Pro Alliance', N'Doug@TaxLync.com', CAST(N'2021-01-29T23:16:48.313' AS DateTime), CAST(N'2021-01-29T23:16:48.313' AS DateTime))
INSERT [dbo].[Customers] ([CustomerID], [CustomerCode], [Name], [Email], [CreatedDate], [ModifiedDate]) VALUES (3, N'5851741d-af8b-49b5-a385-19bfc8677fb4', N'Jeremy kj', N'Jeremy@TaxLync.com', CAST(N'2021-01-29T23:59:46.000' AS DateTime), CAST(N'2021-06-28T13:19:19.257' AS DateTime))
INSERT [dbo].[Customers] ([CustomerID], [CustomerCode], [Name], [Email], [CreatedDate], [ModifiedDate]) VALUES (4, N'3273efcc-36c4-4d02-9137-8cbd63e45847', N'Zach Benefield', N'Zach@TaxLync.com', CAST(N'2021-01-30T00:55:03.180' AS DateTime), CAST(N'2021-01-30T00:55:03.180' AS DateTime))
INSERT [dbo].[Customers] ([CustomerID], [CustomerCode], [Name], [Email], [CreatedDate], [ModifiedDate]) VALUES (5, N'e7eccf4f-a785-4339-8680-a36d723bb087', N'Natalia Olive', N'NataliaO@nexus1040.org', CAST(N'2021-02-03T01:52:43.113' AS DateTime), CAST(N'2021-02-03T01:52:43.113' AS DateTime))
INSERT [dbo].[Customers] ([CustomerID], [CustomerCode], [Name], [Email], [CreatedDate], [ModifiedDate]) VALUES (6, N'fe0e5132-e6f3-42c0-8c99-c0d3e48e20af', N'test', N'hadmin@gmail.com', CAST(N'2021-06-28T13:31:48.663' AS DateTime), CAST(N'2021-06-28T13:31:48.663' AS DateTime))
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[UserRoles] ON 

INSERT [dbo].[UserRoles] ([Id], [Role]) VALUES (1, N'SuperAdmin')
INSERT [dbo].[UserRoles] ([Id], [Role]) VALUES (2, N'Admin')
SET IDENTITY_INSERT [dbo].[UserRoles] OFF
GO
