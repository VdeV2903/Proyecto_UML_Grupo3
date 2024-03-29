USE [master]
GO
/****** Object:  Database [Tec_Shop_UMLG3]    Script Date: 7/12/2021 01:24:02 a. m. ******/
CREATE DATABASE [Tec_Shop_UMLG3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Tec_Shop_UMLG3', FILENAME = N'E:\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Tec_Shop_UMLG3.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Tec_Shop_UMLG3_log', FILENAME = N'E:\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Tec_Shop_UMLG3_log.ldf' , SIZE = 5248KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Tec_Shop_UMLG3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET ARITHABORT OFF 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET RECOVERY FULL 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET  MULTI_USER 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Tec_Shop_UMLG3', N'ON'
GO
USE [Tec_Shop_UMLG3]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categorias](
	[ID_Categoria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Categoria] [varchar](50) NOT NULL,
	[Estado] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[ID_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Cliente] [varchar](100) NOT NULL,
	[Telefono_Cliente] [varchar](15) NULL,
	[Correo_Cliente] [varchar](50) NULL,
	[Estatus] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cotizaciones]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cotizaciones](
	[ID_Cotizacion] [int] IDENTITY(1,1) NOT NULL,
	[Codigo_Cotizacion] [varchar](50) NOT NULL,
	[Fecha_Cotización] [date] NOT NULL,
	[Sub_Total] [float] NOT NULL,
	[Total] [float] NOT NULL,
	[ID_Cliente] [int] NOT NULL,
	[Nombre_Empleado] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Cotizacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DocumentosFiscales]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DocumentosFiscales](
	[ID_Documento] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_Doc] [date] NOT NULL,
	[Nota] [varchar](200) NULL,
	[Tipo_Doc] [varchar](50) NOT NULL,
	[NIT] [varchar](50) NOT NULL,
	[Registro] [varchar](50) NOT NULL,
	[Cliente] [varchar](100) NOT NULL,
	[Direccion] [varchar](200) NOT NULL,
	[Municipio] [varchar](50) NOT NULL,
	[Departamento] [varchar](50) NOT NULL,
	[Condicion] [varchar](100) NOT NULL,
	[ID_Empleado] [int] NOT NULL,
	[ID_Venta] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleados](
	[ID_Empleado] [int] IDENTITY(1,1) NOT NULL,
	[Carnet_Empleado] [varchar](15) NOT NULL,
	[Nombre_Empleado] [varchar](50) NOT NULL,
	[Apellidos_Empleado] [varchar](50) NOT NULL,
	[Telefono_Empleado] [varchar](15) NOT NULL,
	[Correo_Empleado] [varchar](50) NOT NULL,
	[Roll] [varchar](25) NOT NULL,
	[ID_Usuario] [int] NOT NULL,
	[Estatus] [varchar](15) NOT NULL,
	[Fecha_Nacimiento] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Productos](
	[ID_Producto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Producto] [varchar](50) NOT NULL,
	[Marca_Producto] [varchar](50) NOT NULL,
	[Distribuidor] [varchar](50) NOT NULL,
	[Precio_Compra] [decimal](5, 2) NOT NULL,
	[Precio_Venta] [decimal](5, 2) NOT NULL,
	[ID_Categoria] [int] NOT NULL,
	[Estado] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Productos_Cotizaciones]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos_Cotizaciones](
	[ID_ProductoCotizacion] [int] IDENTITY(1,1) NOT NULL,
	[ID_Cotizacion] [int] NOT NULL,
	[ID_Producto] [int] NOT NULL,
	[Precio] [float] NOT NULL,
	[Cantidad_Producto] [int] NOT NULL,
	[Total_Producto] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_ProductoCotizacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Productos_Ventas]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos_Ventas](
	[ID_ProductosVenta] [int] IDENTITY(1,1) NOT NULL,
	[ID_Producto] [int] NOT NULL,
	[ID_Venta] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[TotalProducto] [float] NOT NULL,
	[Precio] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_ProductosVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Promociones]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Promociones](
	[ID_Promoción] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Promocion] [varchar](100) NOT NULL,
	[Fecha_Fin] [date] NOT NULL,
	[Precio_Anterior] [float] NOT NULL,
	[Porcentaje] [float] NOT NULL,
	[Nuevo_Precio] [float] NOT NULL,
	[ID_Producto] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Promoción] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Contrasenia] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ventas](
	[ID_Venta] [int] IDENTITY(1,1) NOT NULL,
	[Codigo_Venta] [varchar](50) NOT NULL,
	[Fecha_Venta] [date] NOT NULL,
	[Sub_Total] [float] NOT NULL,
	[Total] [float] NOT NULL,
	[ID_Cliente] [int] NOT NULL,
	[Vendedor] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Categorias] ON 

INSERT [dbo].[Categorias] ([ID_Categoria], [Nombre_Categoria], [Estado]) VALUES (3, N'Cables', N'ACTIVA')
INSERT [dbo].[Categorias] ([ID_Categoria], [Nombre_Categoria], [Estado]) VALUES (4, N'Monitores', N'ACTIVA')
INSERT [dbo].[Categorias] ([ID_Categoria], [Nombre_Categoria], [Estado]) VALUES (5, N'Muebles', N'ACTIVA')
INSERT [dbo].[Categorias] ([ID_Categoria], [Nombre_Categoria], [Estado]) VALUES (6, N'Sillas', N'ACTIVA')
INSERT [dbo].[Categorias] ([ID_Categoria], [Nombre_Categoria], [Estado]) VALUES (7, N'Tarjetas Graficas', N'ACTIVA')
INSERT [dbo].[Categorias] ([ID_Categoria], [Nombre_Categoria], [Estado]) VALUES (8, N'MotherBoards', N'ACTIVA')
INSERT [dbo].[Categorias] ([ID_Categoria], [Nombre_Categoria], [Estado]) VALUES (9, N'Almacenamiento', N'ACTIVA')
INSERT [dbo].[Categorias] ([ID_Categoria], [Nombre_Categoria], [Estado]) VALUES (1002, N'Memorias RAM', N'ACTIVA')
INSERT [dbo].[Categorias] ([ID_Categoria], [Nombre_Categoria], [Estado]) VALUES (1003, N'Lapices Digitales', N'ACTIVA')
INSERT [dbo].[Categorias] ([ID_Categoria], [Nombre_Categoria], [Estado]) VALUES (1004, N'Routers', N'ACTIVA')
INSERT [dbo].[Categorias] ([ID_Categoria], [Nombre_Categoria], [Estado]) VALUES (1005, N'Teclados', N'ACTIVA')
SET IDENTITY_INSERT [dbo].[Categorias] OFF
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([ID_Cliente], [Nombre_Cliente], [Telefono_Cliente], [Correo_Cliente], [Estatus]) VALUES (1, N'Gerson David Ramirez Estevez', N'72545265', N'gerson@utecc.edu', N'ACTIVO')
INSERT [dbo].[Clientes] ([ID_Cliente], [Nombre_Cliente], [Telefono_Cliente], [Correo_Cliente], [Estatus]) VALUES (2, N'Marcos Adonay Medina', N'72583461', N'hola@gmail.com', N'ACTIVO')
INSERT [dbo].[Clientes] ([ID_Cliente], [Nombre_Cliente], [Telefono_Cliente], [Correo_Cliente], [Estatus]) VALUES (1002, N'Juan Alberto Hernandez', N'21222344', N'alberto@gmail.com', N'ACTIVO')
INSERT [dbo].[Clientes] ([ID_Cliente], [Nombre_Cliente], [Telefono_Cliente], [Correo_Cliente], [Estatus]) VALUES (1003, N'Melanie Osorio', N'74356768', N'melanieo@gmail.com', N'ACTIVO')
INSERT [dbo].[Clientes] ([ID_Cliente], [Nombre_Cliente], [Telefono_Cliente], [Correo_Cliente], [Estatus]) VALUES (1004, N'Edwin Mateo Flores', N'76789854', N'edwinmat@gmail.com', N'ACTIVO')
INSERT [dbo].[Clientes] ([ID_Cliente], [Nombre_Cliente], [Telefono_Cliente], [Correo_Cliente], [Estatus]) VALUES (1005, N'Katia Pacheco', N'74356756', N'katiapac2@hotmail.com', N'ACTIVO')
INSERT [dbo].[Clientes] ([ID_Cliente], [Nombre_Cliente], [Telefono_Cliente], [Correo_Cliente], [Estatus]) VALUES (3006, N'Gerson Reinosa', N'75986232', N'gersonchiquillo@gmail.com', N'ACTIVO')
INSERT [dbo].[Clientes] ([ID_Cliente], [Nombre_Cliente], [Telefono_Cliente], [Correo_Cliente], [Estatus]) VALUES (3007, N'Gerson David Ramirez Estevez', N'', N'gerson@utec.edu.sv', N'ACTIVO')
INSERT [dbo].[Clientes] ([ID_Cliente], [Nombre_Cliente], [Telefono_Cliente], [Correo_Cliente], [Estatus]) VALUES (3008, N'Gerson David Ramirez', N'78789898', N'gerson@utec.edu.sv', N'INACTIVO')
INSERT [dbo].[Clientes] ([ID_Cliente], [Nombre_Cliente], [Telefono_Cliente], [Correo_Cliente], [Estatus]) VALUES (3009, N'Cristian David Ramirez Reinosa', N'', N'gersondavid@gmail.com', N'INACTIVO')
INSERT [dbo].[Clientes] ([ID_Cliente], [Nombre_Cliente], [Telefono_Cliente], [Correo_Cliente], [Estatus]) VALUES (4007, N'George Hernandez', N'76565654', N'george@gmai.com', N'ACTIVO')
INSERT [dbo].[Clientes] ([ID_Cliente], [Nombre_Cliente], [Telefono_Cliente], [Correo_Cliente], [Estatus]) VALUES (4008, N'Edwin Alberto Callejas', N'78541212', N'edwin@gmail.com', N'ACTIVO')
INSERT [dbo].[Clientes] ([ID_Cliente], [Nombre_Cliente], [Telefono_Cliente], [Correo_Cliente], [Estatus]) VALUES (4009, N'Jorge Pineda', N'72336232', N'edwin@gmail.com', N'ACTIVO')
INSERT [dbo].[Clientes] ([ID_Cliente], [Nombre_Cliente], [Telefono_Cliente], [Correo_Cliente], [Estatus]) VALUES (4010, N'Jorge Alberto B', N'78451212', N'jorgea@gmail.com', N'ACTIVO')
INSERT [dbo].[Clientes] ([ID_Cliente], [Nombre_Cliente], [Telefono_Cliente], [Correo_Cliente], [Estatus]) VALUES (4011, N'Enzo Lima', N'78451233', N'enzo@gmail.com', N'ACTIVO')
INSERT [dbo].[Clientes] ([ID_Cliente], [Nombre_Cliente], [Telefono_Cliente], [Correo_Cliente], [Estatus]) VALUES (4012, N'Edwin Alberto Callejas', N'78451214', N'edwina@gmail.com', N'ACTIVO')
SET IDENTITY_INSERT [dbo].[Clientes] OFF
SET IDENTITY_INSERT [dbo].[Cotizaciones] ON 

INSERT [dbo].[Cotizaciones] ([ID_Cotizacion], [Codigo_Cotizacion], [Fecha_Cotización], [Sub_Total], [Total], [ID_Cliente], [Nombre_Empleado]) VALUES (7, N'Ger20211126_200111', CAST(N'2021-11-26' AS Date), 3600, 3600, 1, N' ')
INSERT [dbo].[Cotizaciones] ([ID_Cotizacion], [Codigo_Cotizacion], [Fecha_Cotización], [Sub_Total], [Total], [ID_Cliente], [Nombre_Empleado]) VALUES (8, N'Ger20211126_200309', CAST(N'2021-11-26' AS Date), 6300, 6300, 1, N' ')
INSERT [dbo].[Cotizaciones] ([ID_Cotizacion], [Codigo_Cotizacion], [Fecha_Cotización], [Sub_Total], [Total], [ID_Cliente], [Nombre_Empleado]) VALUES (9, N'Mar20211127_164340', CAST(N'2021-11-27' AS Date), 1110, 1110, 2, N' ')
INSERT [dbo].[Cotizaciones] ([ID_Cotizacion], [Codigo_Cotizacion], [Fecha_Cotización], [Sub_Total], [Total], [ID_Cliente], [Nombre_Empleado]) VALUES (10, N'Mar20211127_164418', CAST(N'2021-11-27' AS Date), 630, 630, 2, N' ')
INSERT [dbo].[Cotizaciones] ([ID_Cotizacion], [Codigo_Cotizacion], [Fecha_Cotización], [Sub_Total], [Total], [ID_Cliente], [Nombre_Empleado]) VALUES (11, N'Mar20211127_164514', CAST(N'2021-11-27' AS Date), 210, 210, 2, N' ')
INSERT [dbo].[Cotizaciones] ([ID_Cotizacion], [Codigo_Cotizacion], [Fecha_Cotización], [Sub_Total], [Total], [ID_Cliente], [Nombre_Empleado]) VALUES (12, N'Ger20211127_164549', CAST(N'2021-11-27' AS Date), 2700, 2700, 1, N' ')
INSERT [dbo].[Cotizaciones] ([ID_Cotizacion], [Codigo_Cotizacion], [Fecha_Cotización], [Sub_Total], [Total], [ID_Cliente], [Nombre_Empleado]) VALUES (13, N'Edw20211127_201232', CAST(N'2021-11-27' AS Date), 1490, 1490, 4012, N' ')
SET IDENTITY_INSERT [dbo].[Cotizaciones] OFF
SET IDENTITY_INSERT [dbo].[Empleados] ON 

INSERT [dbo].[Empleados] ([ID_Empleado], [Carnet_Empleado], [Nombre_Empleado], [Apellidos_Empleado], [Telefono_Empleado], [Correo_Empleado], [Roll], [ID_Usuario], [Estatus], [Fecha_Nacimiento]) VALUES (1016, N'Mar082000Med', N'Marcos Adonay', N'Medina Salazar', N'75654646', N'marcos@gmail.com', N'JEFE/GERENTE', 2014, N'ACTIVO', CAST(N'2000-08-12' AS Date))
INSERT [dbo].[Empleados] ([ID_Empleado], [Carnet_Empleado], [Nombre_Empleado], [Apellidos_Empleado], [Telefono_Empleado], [Correo_Empleado], [Roll], [ID_Usuario], [Estatus], [Fecha_Nacimiento]) VALUES (1017, N'Kam082000Mon', N'Kamila Javiera', N'Monroy', N'78451212', N'kamila@gmail.com', N'EMPLEADO', 2015, N'ACTIVO', CAST(N'2000-08-12' AS Date))
INSERT [dbo].[Empleados] ([ID_Empleado], [Carnet_Empleado], [Nombre_Empleado], [Apellidos_Empleado], [Telefono_Empleado], [Correo_Empleado], [Roll], [ID_Usuario], [Estatus], [Fecha_Nacimiento]) VALUES (1018, N'Jos071994Mar', N'Jose Eduardo', N'Martinez', N'78451236', N'eduardo23@gmail.com', N'EMPLEADO', 2016, N'ACTIVO', CAST(N'1994-07-27' AS Date))
INSERT [dbo].[Empleados] ([ID_Empleado], [Carnet_Empleado], [Nombre_Empleado], [Apellidos_Empleado], [Telefono_Empleado], [Correo_Empleado], [Roll], [ID_Usuario], [Estatus], [Fecha_Nacimiento]) VALUES (1019, N'Edw061995Cal', N'Edwin', N'Callejas', N'75123256', N'edwinaa@gmail.com', N'JEFE/GERENTE', 2017, N'ACTIVO', CAST(N'1995-06-14' AS Date))
SET IDENTITY_INSERT [dbo].[Empleados] OFF
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([ID_Producto], [Nombre_Producto], [Marca_Producto], [Distribuidor], [Precio_Compra], [Precio_Venta], [ID_Categoria], [Estado]) VALUES (2, N'RTX 3080', N'Gigabyte', N'Nvidia', CAST(800.00 AS Decimal(5, 2)), CAST(900.00 AS Decimal(5, 2)), 7, N'DISPONIBLE')
INSERT [dbo].[Productos] ([ID_Producto], [Nombre_Producto], [Marca_Producto], [Distribuidor], [Precio_Compra], [Precio_Venta], [ID_Categoria], [Estado]) VALUES (3, N'Motherboard Z210', N'Asus', N'Tecbin', CAST(150.00 AS Decimal(5, 2)), CAST(210.00 AS Decimal(5, 2)), 8, N'DISPONIBLE')
INSERT [dbo].[Productos] ([ID_Producto], [Nombre_Producto], [Marca_Producto], [Distribuidor], [Precio_Compra], [Precio_Venta], [ID_Categoria], [Estado]) VALUES (4, N'8GB Kingston 3200mhz', N'Kingston', N'Tecbin', CAST(50.00 AS Decimal(5, 2)), CAST(70.00 AS Decimal(5, 2)), 1002, N'DISPONIBLE')
INSERT [dbo].[Productos] ([ID_Producto], [Nombre_Producto], [Marca_Producto], [Distribuidor], [Precio_Compra], [Precio_Venta], [ID_Categoria], [Estado]) VALUES (5, N'Lapiz Digital', N'Apple', N'Apple', CAST(70.00 AS Decimal(5, 2)), CAST(100.00 AS Decimal(5, 2)), 1003, N'DISPONIBLE')
INSERT [dbo].[Productos] ([ID_Producto], [Nombre_Producto], [Marca_Producto], [Distribuidor], [Precio_Compra], [Precio_Venta], [ID_Categoria], [Estado]) VALUES (6, N'Cable VGA', N'Toshiba', N'Intec', CAST(2.00 AS Decimal(5, 2)), CAST(4.50 AS Decimal(5, 2)), 3, N'DISPONIBLE')
INSERT [dbo].[Productos] ([ID_Producto], [Nombre_Producto], [Marca_Producto], [Distribuidor], [Precio_Compra], [Precio_Venta], [ID_Categoria], [Estado]) VALUES (7, N'Cable HDMI', N'Toshiba', N'Intec', CAST(2.00 AS Decimal(5, 2)), CAST(4.50 AS Decimal(5, 2)), 3, N'DISPONIBLE')
INSERT [dbo].[Productos] ([ID_Producto], [Nombre_Producto], [Marca_Producto], [Distribuidor], [Precio_Compra], [Precio_Venta], [ID_Categoria], [Estado]) VALUES (8, N'Teclado Mecanico', N'Logitech', N'InWin', CAST(60.50 AS Decimal(5, 2)), CAST(95.50 AS Decimal(5, 2)), 1005, N'DISPONIBLE')
SET IDENTITY_INSERT [dbo].[Productos] OFF
SET IDENTITY_INSERT [dbo].[Productos_Cotizaciones] ON 

INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (19, 7, 2, 900, 1, 900)
INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (20, 7, 2, 900, 1, 900)
INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (21, 7, 2, 900, 1, 900)
INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (22, 7, 2, 900, 1, 900)
INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (23, 8, 2, 900, 1, 900)
INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (24, 8, 2, 900, 1, 900)
INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (25, 8, 2, 900, 1, 900)
INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (26, 8, 2, 900, 1, 900)
INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (27, 8, 2, 900, 1, 900)
INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (28, 8, 2, 900, 1, 900)
INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (29, 8, 2, 900, 1, 900)
INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (30, 9, 3, 210, 1, 210)
INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (31, 9, 2, 900, 1, 900)
INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (32, 10, 3, 210, 1, 210)
INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (33, 10, 3, 210, 1, 210)
INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (34, 10, 3, 210, 1, 210)
INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (35, 11, 4, 70, 1, 70)
INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (36, 11, 4, 70, 1, 70)
INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (37, 11, 4, 70, 1, 70)
INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (38, 12, 2, 900, 1, 900)
INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (39, 12, 2, 900, 1, 900)
INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (40, 12, 2, 900, 1, 900)
INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (41, 13, 3, 210, 1, 210)
INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (42, 13, 4, 70, 1, 70)
INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (43, 13, 5, 100, 1, 100)
INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (44, 13, 2, 900, 1, 900)
INSERT [dbo].[Productos_Cotizaciones] ([ID_ProductoCotizacion], [ID_Cotizacion], [ID_Producto], [Precio], [Cantidad_Producto], [Total_Producto]) VALUES (45, 13, 3, 210, 1, 210)
SET IDENTITY_INSERT [dbo].[Productos_Cotizaciones] OFF
SET IDENTITY_INSERT [dbo].[Productos_Ventas] ON 

INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (43, 2, 15, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (44, 2, 15, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (45, 2, 15, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (46, 2, 16, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (47, 2, 16, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (48, 2, 16, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (49, 2, 16, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (50, 2, 17, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (51, 2, 17, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (52, 2, 17, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (53, 2, 17, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (54, 2, 17, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (55, 2, 18, 1, 450, 450)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (56, 2, 18, 1, 450, 450)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (57, 2, 18, 1, 450, 450)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (58, 2, 18, 1, 450, 450)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (59, 2, 18, 1, 450, 450)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (60, 2, 19, 1, 450, 450)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (61, 2, 19, 1, 450, 450)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (62, 2, 19, 1, 450, 450)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (63, 2, 19, 1, 450, 450)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (64, 2, 19, 1, 450, 450)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (65, 2, 19, 1, 450, 450)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (66, 2, 20, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (67, 3, 20, 1, 210, 210)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (68, 4, 20, 1, 70, 70)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (69, 4, 20, 1, 70, 70)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (70, 4, 20, 1, 70, 70)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (71, 4, 20, 1, 70, 70)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (72, 5, 20, 1, 100, 100)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (73, 6, 20, 1, 4.5, 4.5)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (74, 2, 21, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (75, 3, 21, 1, 210, 210)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (76, 4, 21, 1, 70, 70)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (77, 4, 21, 1, 70, 70)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (78, 4, 21, 1, 70, 70)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (79, 4, 21, 1, 70, 70)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (80, 6, 21, 1, 4.5, 4.5)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (81, 7, 21, 1, 4.5, 4.5)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (82, 2, 22, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (83, 2, 22, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (84, 2, 22, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (85, 2, 22, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (86, 2, 22, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (87, 2, 23, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (88, 2, 23, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (89, 3, 23, 1, 210, 210)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (90, 3, 23, 1, 210, 210)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (91, 2, 24, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (92, 2, 24, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (93, 2, 24, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (94, 4, 25, 1, 70, 70)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (95, 4, 25, 1, 70, 70)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (96, 4, 25, 1, 70, 70)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (97, 4, 25, 1, 70, 70)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (98, 4, 25, 1, 70, 70)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (99, 3, 26, 1, 210, 210)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (100, 3, 26, 1, 210, 210)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (101, 3, 26, 1, 210, 210)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (102, 4, 27, 1, 70, 70)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (103, 4, 27, 1, 70, 70)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (104, 4, 27, 1, 70, 70)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (105, 4, 27, 1, 70, 70)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (106, 4, 27, 1, 70, 70)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (107, 2, 28, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (108, 2, 28, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (109, 2, 29, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (110, 2, 29, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (111, 2, 29, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (112, 2, 29, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (113, 4, 29, 1, 70, 70)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (114, 4, 29, 1, 70, 70)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (115, 2, 30, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (116, 2, 30, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (117, 3, 30, 1, 210, 210)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (118, 3, 30, 1, 210, 210)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (119, 3, 30, 1, 210, 210)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (120, 2, 31, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (121, 2, 31, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (122, 2, 31, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (123, 2, 32, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (124, 4, 32, 1, 70, 70)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (125, 7, 32, 2, 9, 4.5)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (126, 2, 33, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (127, 3, 33, 1, 210, 210)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (128, 4, 33, 4, 280, 70)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (129, 7, 33, 1, 4.5, 4.5)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (130, 8, 33, 1, 95.5, 95.5)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (1126, 2, 1033, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (1127, 2, 1033, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (1128, 2, 1033, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (1129, 2, 1033, 1, 900, 900)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (1130, 3, 1034, 1, 210, 210)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (1131, 4, 1034, 1, 70, 70)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (1132, 4, 1034, 1, 70, 70)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (1133, 7, 1034, 1, 4.5, 4.5)
INSERT [dbo].[Productos_Ventas] ([ID_ProductosVenta], [ID_Producto], [ID_Venta], [Cantidad], [TotalProducto], [Precio]) VALUES (1134, 8, 1034, 1, 95.5, 95.5)
SET IDENTITY_INSERT [dbo].[Productos_Ventas] OFF
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([ID_Usuario], [Usuario], [Contrasenia]) VALUES (2014, N'MarMed082000', 0x0100000046CC01C5C6E61C99816E31A4237734A15D0289DC62122207)
INSERT [dbo].[Usuarios] ([ID_Usuario], [Usuario], [Contrasenia]) VALUES (2015, N'KamMon082000', 0x0100000099C7F0840BB768C095D825F83EAF9617B3C09FE58CA966B4)
INSERT [dbo].[Usuarios] ([ID_Usuario], [Usuario], [Contrasenia]) VALUES (2016, N'JosMar071994', 0x010000006940FD3EC39D73BE7B06CDDC7A9897BF86553D1EDBF5CCA4)
INSERT [dbo].[Usuarios] ([ID_Usuario], [Usuario], [Contrasenia]) VALUES (2017, N'EdwCal061995', 0x0100000059A21D17271A29CE78A4D64524B7535092B132A1B5B29EF7)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
SET IDENTITY_INSERT [dbo].[Ventas] ON 

INSERT [dbo].[Ventas] ([ID_Venta], [Codigo_Venta], [Fecha_Venta], [Sub_Total], [Total], [ID_Cliente], [Vendedor]) VALUES (12, N'Ger20211126_195311', CAST(N'2021-11-26' AS Date), 4500, 4500, 1, N' ')
INSERT [dbo].[Ventas] ([ID_Venta], [Codigo_Venta], [Fecha_Venta], [Sub_Total], [Total], [ID_Cliente], [Vendedor]) VALUES (13, N'Ger20211126_195644', CAST(N'2021-11-26' AS Date), 4500, 4500, 1, N' ')
INSERT [dbo].[Ventas] ([ID_Venta], [Codigo_Venta], [Fecha_Venta], [Sub_Total], [Total], [ID_Cliente], [Vendedor]) VALUES (14, N'Ger20211126_195644', CAST(N'2021-11-26' AS Date), 3600, 3600, 1, N' ')
INSERT [dbo].[Ventas] ([ID_Venta], [Codigo_Venta], [Fecha_Venta], [Sub_Total], [Total], [ID_Cliente], [Vendedor]) VALUES (15, N'Ger20211126_195922', CAST(N'2021-11-26' AS Date), 2700, 2700, 1, N' ')
INSERT [dbo].[Ventas] ([ID_Venta], [Codigo_Venta], [Fecha_Venta], [Sub_Total], [Total], [ID_Cliente], [Vendedor]) VALUES (16, N'Ger20211126_200046', CAST(N'2021-11-26' AS Date), 3600, 3600, 1, N' ')
INSERT [dbo].[Ventas] ([ID_Venta], [Codigo_Venta], [Fecha_Venta], [Sub_Total], [Total], [ID_Cliente], [Vendedor]) VALUES (17, N'Ger20211126_200200', CAST(N'2021-11-26' AS Date), 4500, 4500, 1, N' ')
INSERT [dbo].[Ventas] ([ID_Venta], [Codigo_Venta], [Fecha_Venta], [Sub_Total], [Total], [ID_Cliente], [Vendedor]) VALUES (18, N'Ger20211127_134223', CAST(N'2021-11-27' AS Date), 2250, 2250, 1, N' ')
INSERT [dbo].[Ventas] ([ID_Venta], [Codigo_Venta], [Fecha_Venta], [Sub_Total], [Total], [ID_Cliente], [Vendedor]) VALUES (19, N'Mar20211127_134223', CAST(N'2021-11-27' AS Date), 2700, 2700, 2, N' ')
INSERT [dbo].[Ventas] ([ID_Venta], [Codigo_Venta], [Fecha_Venta], [Sub_Total], [Total], [ID_Cliente], [Vendedor]) VALUES (20, N'Ger20211127_154758', CAST(N'2021-11-27' AS Date), 1494.5, 1494.5, 1, N' ')
INSERT [dbo].[Ventas] ([ID_Venta], [Codigo_Venta], [Fecha_Venta], [Sub_Total], [Total], [ID_Cliente], [Vendedor]) VALUES (21, N'Ger20211127_154840', CAST(N'2021-11-27' AS Date), 1399, 1399, 1, N' ')
INSERT [dbo].[Ventas] ([ID_Venta], [Codigo_Venta], [Fecha_Venta], [Sub_Total], [Total], [ID_Cliente], [Vendedor]) VALUES (22, N'Mar20211127_154925', CAST(N'2021-11-27' AS Date), 4500, 4500, 2, N' ')
INSERT [dbo].[Ventas] ([ID_Venta], [Codigo_Venta], [Fecha_Venta], [Sub_Total], [Total], [ID_Cliente], [Vendedor]) VALUES (23, N'Ger20211127_155108', CAST(N'2021-11-27' AS Date), 2220, 2220, 1, N' ')
INSERT [dbo].[Ventas] ([ID_Venta], [Codigo_Venta], [Fecha_Venta], [Sub_Total], [Total], [ID_Cliente], [Vendedor]) VALUES (24, N'Mar20211127_155252', CAST(N'2021-11-27' AS Date), 2700, 2700, 2, N' ')
INSERT [dbo].[Ventas] ([ID_Venta], [Codigo_Venta], [Fecha_Venta], [Sub_Total], [Total], [ID_Cliente], [Vendedor]) VALUES (25, N'Jua20211127_155458', CAST(N'2021-11-27' AS Date), 350, 350, 1002, N' ')
INSERT [dbo].[Ventas] ([ID_Venta], [Codigo_Venta], [Fecha_Venta], [Sub_Total], [Total], [ID_Cliente], [Vendedor]) VALUES (26, N'Mar20211127_155714', CAST(N'2021-11-27' AS Date), 630, 630, 2, N' ')
INSERT [dbo].[Ventas] ([ID_Venta], [Codigo_Venta], [Fecha_Venta], [Sub_Total], [Total], [ID_Cliente], [Vendedor]) VALUES (27, N'Mar20211127_160105', CAST(N'2021-11-27' AS Date), 350, 350, 2, N' ')
INSERT [dbo].[Ventas] ([ID_Venta], [Codigo_Venta], [Fecha_Venta], [Sub_Total], [Total], [ID_Cliente], [Vendedor]) VALUES (28, N'Mar20211127_160242', CAST(N'2021-11-27' AS Date), 1800, 1800, 2, N' ')
INSERT [dbo].[Ventas] ([ID_Venta], [Codigo_Venta], [Fecha_Venta], [Sub_Total], [Total], [ID_Cliente], [Vendedor]) VALUES (29, N'Edw20211127_164130', CAST(N'2021-11-27' AS Date), 3740, 3740, 4008, N' ')
INSERT [dbo].[Ventas] ([ID_Venta], [Codigo_Venta], [Fecha_Venta], [Sub_Total], [Total], [ID_Cliente], [Vendedor]) VALUES (30, N'Ger20211127_173500', CAST(N'2021-11-27' AS Date), 2430, 2430, 1, N' ')
INSERT [dbo].[Ventas] ([ID_Venta], [Codigo_Venta], [Fecha_Venta], [Sub_Total], [Total], [ID_Cliente], [Vendedor]) VALUES (31, N'Ger20211127_195827', CAST(N'2021-11-27' AS Date), 2700, 2700, 1, N' ')
INSERT [dbo].[Ventas] ([ID_Venta], [Codigo_Venta], [Fecha_Venta], [Sub_Total], [Total], [ID_Cliente], [Vendedor]) VALUES (32, N'Edw20211127_201001', CAST(N'2021-11-27' AS Date), 979, 979, 4012, N' ')
INSERT [dbo].[Ventas] ([ID_Venta], [Codigo_Venta], [Fecha_Venta], [Sub_Total], [Total], [ID_Cliente], [Vendedor]) VALUES (33, N'Ger20211128_201023', CAST(N'2021-11-28' AS Date), 1490, 1490, 1, N' ')
INSERT [dbo].[Ventas] ([ID_Venta], [Codigo_Venta], [Fecha_Venta], [Sub_Total], [Total], [ID_Cliente], [Vendedor]) VALUES (1033, N'Mar20211206_180734', CAST(N'2021-12-06' AS Date), 3600, 3600, 2, N' ')
INSERT [dbo].[Ventas] ([ID_Venta], [Codigo_Venta], [Fecha_Venta], [Sub_Total], [Total], [ID_Cliente], [Vendedor]) VALUES (1034, N'Ger20211206_182628', CAST(N'2021-12-06' AS Date), 450, 450, 1, N' ')
SET IDENTITY_INSERT [dbo].[Ventas] OFF
ALTER TABLE [dbo].[Cotizaciones]  WITH CHECK ADD  CONSTRAINT [fk_clienteCotizacion] FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[Clientes] ([ID_Cliente])
GO
ALTER TABLE [dbo].[Cotizaciones] CHECK CONSTRAINT [fk_clienteCotizacion]
GO
ALTER TABLE [dbo].[DocumentosFiscales]  WITH CHECK ADD  CONSTRAINT [fk_empleadoDocumentos] FOREIGN KEY([ID_Empleado])
REFERENCES [dbo].[Empleados] ([ID_Empleado])
GO
ALTER TABLE [dbo].[DocumentosFiscales] CHECK CONSTRAINT [fk_empleadoDocumentos]
GO
ALTER TABLE [dbo].[DocumentosFiscales]  WITH CHECK ADD  CONSTRAINT [fk_ventasDocumentos] FOREIGN KEY([ID_Venta])
REFERENCES [dbo].[Ventas] ([ID_Venta])
GO
ALTER TABLE [dbo].[DocumentosFiscales] CHECK CONSTRAINT [fk_ventasDocumentos]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [fk_usuarioEmpleados] FOREIGN KEY([ID_Usuario])
REFERENCES [dbo].[Usuarios] ([ID_Usuario])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [fk_usuarioEmpleados]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [fk_catProducto] FOREIGN KEY([ID_Categoria])
REFERENCES [dbo].[Categorias] ([ID_Categoria])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [fk_catProducto]
GO
ALTER TABLE [dbo].[Productos_Cotizaciones]  WITH CHECK ADD  CONSTRAINT [fk_productoxCotizacion] FOREIGN KEY([ID_Cotizacion])
REFERENCES [dbo].[Cotizaciones] ([ID_Cotizacion])
GO
ALTER TABLE [dbo].[Productos_Cotizaciones] CHECK CONSTRAINT [fk_productoxCotizacion]
GO
ALTER TABLE [dbo].[Productos_Cotizaciones]  WITH CHECK ADD  CONSTRAINT [fk_productoxProducto] FOREIGN KEY([ID_Producto])
REFERENCES [dbo].[Productos] ([ID_Producto])
GO
ALTER TABLE [dbo].[Productos_Cotizaciones] CHECK CONSTRAINT [fk_productoxProducto]
GO
ALTER TABLE [dbo].[Productos_Ventas]  WITH CHECK ADD  CONSTRAINT [fk_prodxventas_producto] FOREIGN KEY([ID_Producto])
REFERENCES [dbo].[Productos] ([ID_Producto])
GO
ALTER TABLE [dbo].[Productos_Ventas] CHECK CONSTRAINT [fk_prodxventas_producto]
GO
ALTER TABLE [dbo].[Productos_Ventas]  WITH CHECK ADD  CONSTRAINT [fk_prodxventas_venta] FOREIGN KEY([ID_Venta])
REFERENCES [dbo].[Ventas] ([ID_Venta])
GO
ALTER TABLE [dbo].[Productos_Ventas] CHECK CONSTRAINT [fk_prodxventas_venta]
GO
ALTER TABLE [dbo].[Promociones]  WITH CHECK ADD  CONSTRAINT [fk_productosPromociones] FOREIGN KEY([ID_Producto])
REFERENCES [dbo].[Productos] ([ID_Producto])
GO
ALTER TABLE [dbo].[Promociones] CHECK CONSTRAINT [fk_productosPromociones]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [fk_ventasCliente] FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[Clientes] ([ID_Cliente])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [fk_ventasCliente]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarCliente]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ActualizarCliente]
@ID INT,
@nombre VARCHAR(100),
@telefono VARCHAR(15),
@correo VARCHAR(50),
@estado VARCHAR(25)
AS
	UPDATE [dbo].[Clientes] SET Nombre_Cliente = @nombre, Telefono_Cliente = @telefono, Correo_Cliente = @correo, Estatus = @estado WHERE ID_Cliente = @ID

GO
/****** Object:  StoredProcedure [dbo].[AnadirCategoria]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AnadirCategoria]
@nombre VARCHAR(50)
AS
	INSERT INTO [dbo].[Categorias] (Nombre_Categoria,Estado) VALUES (@nombre,'ACTIVA')

GO
/****** Object:  StoredProcedure [dbo].[AnadirCliente]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AnadirCliente]
@nombre VARCHAR(100),
@telefono VARCHAR(15),
@correo VARCHAR(50)
AS
	INSERT INTO [dbo].[Clientes] (Nombre_Cliente,Telefono_Cliente,Correo_Cliente,Estatus) 
						   VALUES(@nombre,@telefono,@correo,'ACTIVO');

GO
/****** Object:  StoredProcedure [dbo].[AnadirUsuarioEmpleado]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AnadirUsuarioEmpleado]
@user VARCHAR(50),
@contrasenia VARCHAR(MAX),
@carnet VARCHAR(15),
@nombre VARCHAR(50),
@apellido VARCHAR(50),
@telefono VARCHAR(15),
@correo VARCHAR(50),
@roll VARCHAR(25),
@fecha DATE
AS
	DECLARE @objetive INT;
	INSERT INTO [dbo].[Usuarios] (Usuario,Contrasenia) VALUES (@user,ENCRYPTBYPASSPHRASE('29S4ZMA0317',@contrasenia))

	SET @objetive = (SELECT ID_Usuario FROM [dbo].[Usuarios] WHERE Usuario = @user)

	INSERT INTO [dbo].[Empleados] (Carnet_Empleado,Nombre_Empleado,Apellidos_Empleado,Telefono_Empleado,Correo_Empleado,Roll,ID_Usuario,Estatus,Fecha_Nacimiento) 
							VALUES(@carnet,@nombre,@apellido,@telefono,@correo,@roll,@objetive,'ACTIVO',@fecha)


GO
/****** Object:  StoredProcedure [dbo].[AutenticarUsuario]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AutenticarUsuario]
@user VARCHAR(50),
@contrasenia varchar(MAX)
AS
	SELECT u.Usuario,u.Contrasenia,e.Estatus FROM [dbo].[Usuarios] u INNER JOIN [dbo].[Empleados] e ON u.ID_Usuario = e.ID_Usuario WHERE u.Usuario = @user AND CONVERT(VARCHAR(MAX), DECRYPTBYPASSPHRASE('29S4ZMA0317',u.Contrasenia)) = @contrasenia AND e.Estatus = 'ACTIVO'
		

GO
/****** Object:  StoredProcedure [dbo].[CargarCategorias]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CargarCategorias]
AS
	SELECT Nombre_Categoria FROM [dbo].[Categorias] WHERE Estado = 'ACTIVA' ORDER BY Nombre_Categoria

GO
/****** Object:  StoredProcedure [dbo].[cargarProductos]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[cargarProductos]
AS
	SELECT Nombre_Producto AS 'Nombre',Marca_Producto AS 'Marca',Precio_Venta AS 'Precio Venta'
	FROM [dbo].[Productos] WHERE Estado = 'ACTIVO'

GO
/****** Object:  StoredProcedure [dbo].[crearPromo]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[crearPromo]
@nombrepromo VARCHAR(100),
@fechafin DATE,
@precioanterior FLOAT,
@porcentaje FLOAT,
@nuevoprecio FLOAT,
@ID int
AS
	INSERT INTO [dbo].[Promociones] (Nombre_Promocion,Fecha_Fin,Precio_Anterior,Porcentaje,Nuevo_Precio,ID_Producto) VALUES (@nombrepromo,@fechafin,@precioanterior,@porcentaje,@nuevoprecio,@ID)
	UPDATE [dbo].[Productos] SET Precio_Venta = @nuevoprecio WHERE ID_Producto = @ID;

GO
/****** Object:  StoredProcedure [dbo].[EditarCategoria]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[EditarCategoria]
@ID INT,
@nombre VARCHAR(50),
@estado VARCHAR(15)
AS
	UPDATE [dbo].[Categorias] SET Nombre_Categoria = @nombre, Estado = @estado WHERE ID_Categoria = @ID;

GO
/****** Object:  StoredProcedure [dbo].[EditarEmpleado]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[EditarEmpleado]
--EL USUARIO NO SE PUEDE CAMBIAR
@carnet VARCHAR(15),
@nombre VARCHAR(50),
@apellido VARCHAR(50),
@telefono VARCHAR(15),
@correo VARCHAR(50),
@roll VARCHAR(25),
@estado VARCHAR(15)
AS
	UPDATE [dbo].[Empleados] 
	SET Nombre_Empleado = @nombre,
		Apellidos_Empleado = @apellido,
		Telefono_Empleado = @telefono,
		Correo_Empleado = @correo,
		Roll = @roll, 
		Estatus = @estado
	WHERE
		Carnet_Empleado = @carnet;

GO
/****** Object:  StoredProcedure [dbo].[EliminarCategoria]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[EliminarCategoria]
@ID INT
AS
	UPDATE [dbo].[Categorias] SET Estado = 'INACTIVA' WHERE ID_Categoria = @ID;

GO
/****** Object:  StoredProcedure [dbo].[EliminarCliente]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[EliminarCliente]
-- solo cambiar el estado a inactivo
@id INT
AS
	UPDATE [dbo].[Clientes] SET Estatus = 'INACTIVO' WHERE ID_Cliente = @id

GO
/****** Object:  StoredProcedure [dbo].[EliminarEmpleado]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[EliminarEmpleado]
-- solo cambiar el estado a inactivo
@carnet VARCHAR(15)
AS
	UPDATE [dbo].[Empleados] SET Estatus = 'INACTIVO' WHERE Carnet_Empleado = @carnet

GO
/****** Object:  StoredProcedure [dbo].[eliminarProducto]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[eliminarProducto]
@ID INT
AS
	UPDATE [dbo].[Productos] SET Estado = 'NO DISPONIBLE' WHERE ID_Producto = @ID

GO
/****** Object:  StoredProcedure [dbo].[eliminarPromo]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[eliminarPromo]
@ID INT
AS
	DECLARE @ID_PROD INT,@preciorec FLOAT
	SET @ID_PROD  = (SELECT ID_Producto FROM Promociones WHERE ID_Promoción = @ID)
	SET @preciorec = (SELECT Precio_Anterior FROM Promociones WHERE ID_Promoción = @ID)

	UPDATE [dbo].[Productos] SET Precio_Venta = @preciorec WHERE ID_Producto = @ID_PROD

	DELETE FROM [dbo].[Promociones] WHERE ID_Promoción = @ID;

GO
/****** Object:  StoredProcedure [dbo].[GenerarCotizacion]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GenerarCotizacion]
@codigo VARCHAR(50),
@fecha DATE,
@subtotal FLOAT,
@cliente VARCHAR(100),
@correo VARCHAR(50),
@vendedor VARCHAR(100),
@totalv FLOAT
AS
	
	DECLARE @id INT
	SET @id = (SELECT ID_Cliente FROM [dbo].[Clientes] WHERE Nombre_Cliente = @cliente AND Correo_Cliente = @correo)

	INSERT INTO [dbo].[Cotizaciones] (Codigo_Cotizacion,Fecha_Cotización,Sub_Total,Total,ID_Cliente,Nombre_Empleado)
						 VALUES(@codigo,@fecha,@subtotal,@totalv,@id,@vendedor)

GO
/****** Object:  StoredProcedure [dbo].[generarFactura]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[generarFactura]
@codigoventa VARCHAR(50)
AS
	SELECT        dbo.Clientes.Nombre_Cliente, dbo.Ventas.Codigo_Venta, dbo.Ventas.Fecha_Venta, dbo.Ventas.Total, dbo.Productos.Nombre_Producto, dbo.Productos.Marca_Producto, dbo.Productos_Ventas.Precio, 
                         dbo.Productos_Ventas.Cantidad, dbo.Productos_Ventas.TotalProducto
	FROM            dbo.Productos_Ventas INNER JOIN
							 dbo.Productos ON dbo.Productos_Ventas.ID_Producto = dbo.Productos.ID_Producto INNER JOIN
							 dbo.Ventas ON dbo.Productos_Ventas.ID_Venta = dbo.Ventas.ID_Venta INNER JOIN
							 dbo.Clientes ON dbo.Ventas.ID_Cliente = dbo.Clientes.ID_Cliente
	WHERE Codigo_Venta = @codigoventa

GO
/****** Object:  StoredProcedure [dbo].[generarFacturaCotizacion]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[generarFacturaCotizacion]
@codigo VARCHAR(50)
AS
	SELECT        dbo.Clientes.Nombre_Cliente, dbo.Cotizaciones.Total, dbo.Cotizaciones.Codigo_Cotizacion, dbo.Productos.Nombre_Producto, dbo.Productos_Cotizaciones.Cantidad_Producto, dbo.Productos_Cotizaciones.Precio, 
							 dbo.Productos_Cotizaciones.Total_Producto, dbo.Productos.Marca_Producto
	FROM            dbo.Clientes INNER JOIN
							 dbo.Cotizaciones ON dbo.Clientes.ID_Cliente = dbo.Cotizaciones.ID_Cliente INNER JOIN
							 dbo.Productos_Cotizaciones ON dbo.Cotizaciones.ID_Cotizacion = dbo.Productos_Cotizaciones.ID_Cotizacion INNER JOIN
							 dbo.Productos ON dbo.Productos_Cotizaciones.ID_Producto = dbo.Productos.ID_Producto
	WHERE        (dbo.Cotizaciones.Codigo_Cotizacion = @codigo)

GO
/****** Object:  StoredProcedure [dbo].[GenerarProductosCotizacion]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GenerarProductosCotizacion]
@producto VARCHAR(50),
@marca VARCHAR(50),
@cot VARCHAR(50),
@precio FLOAT,
@cantidad INT,
@subtotal FLOAT
AS
	DECLARE @idprod INT
	SET @idprod = (SELECT ID_Producto FROM [dbo].[Productos] WHERE Nombre_Producto = @producto AND Marca_Producto = @marca)

	DECLARE @idcot INT
	SET @idcot = (SELECT ID_Cotizacion FROM [dbo].[Cotizaciones] WHERE Codigo_Cotizacion = @cot)

	INSERT INTO [dbo].[Productos_Cotizaciones] (ID_Cotizacion,ID_Producto,Precio,Cantidad_Producto,Total_Producto) VALUES (@idcot,@idprod,@precio,@cantidad,@subtotal)

GO
/****** Object:  StoredProcedure [dbo].[GenerarProductosVenta]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GenerarProductosVenta]
@producto VARCHAR(50),
@marca VARCHAR(50),
@venta VARCHAR(50),
@precio FLOAT,
@cantidad INT,
@subtotal FLOAT
AS
	DECLARE @idprod INT
	SET @idprod = (SELECT ID_Producto FROM [dbo].[Productos] WHERE Nombre_Producto = @producto AND Marca_Producto = @marca)

	DECLARE @idventa INT
	SET @idventa = (SELECT ID_Venta FROM [dbo].[Ventas] WHERE Codigo_Venta = @venta)

	INSERT INTO [dbo].[Productos_Ventas] (ID_Producto,ID_Venta,Cantidad,TotalProducto,Precio) VALUES (@idprod,@idventa,@cantidad,@subtotal,@precio)

GO
/****** Object:  StoredProcedure [dbo].[GenerarVenta]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GenerarVenta]
@codigo VARCHAR(50),
@fecha DATE,
@subtotal FLOAT,
@cliente VARCHAR(100),
@correo VARCHAR(50),
@vendedor VARCHAR(100),
@totalv FLOAT
AS
	
	DECLARE @id INT
	SET @id = (SELECT ID_Cliente FROM [dbo].[Clientes] WHERE Nombre_Cliente = @cliente AND Correo_Cliente = @correo)

	INSERT INTO [dbo].[Ventas] (Codigo_Venta,Fecha_Venta,Sub_Total,Total,ID_Cliente,Vendedor)
						 VALUES(@codigo,@fecha,@subtotal,@totalv,@id,@vendedor)

GO
/****** Object:  StoredProcedure [dbo].[getSession]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getSession]
@usuario VARCHAR(50)
AS
	DECLARE @ID INT
	SET @ID = (SELECT ID_Usuario FROM [dbo].[Usuarios] WHERE Usuario = @usuario)
	SELECT ID_Empleado,Nombre_Empleado,Apellidos_Empleado,Carnet_Empleado,Roll FROM [dbo].[Empleados] WHERE ID_Usuario = @ID;

GO
/****** Object:  StoredProcedure [dbo].[insertarProducto]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[insertarProducto]
@nombre VARCHAR(50),
@marca VARCHAR(50),
@distribuidor VARCHAR(50),
@precioc DECIMAL(5,2),
@preciov DECIMAL(5,2),
@categoria VARCHAR(50)
AS
	DECLARE @ID INT
	SET @ID = (SELECT ID_Categoria FROM [dbo].[Categorias] WHERE Nombre_Categoria = @categoria)
	INSERT INTO [dbo].[Productos] (Nombre_Producto,Marca_Producto,Distribuidor,Precio_Compra,Precio_Venta,ID_Categoria,Estado) VALUES (@nombre,@marca,@distribuidor,@precioc,@preciov,@ID,'DISPONIBLE')

GO
/****** Object:  StoredProcedure [dbo].[modificarProducto]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[modificarProducto]
@ID INT,
@nombre VARCHAR(50),
@marca VARCHAR(50),
@distribuidor VARCHAR(50),
@precioc DECIMAL(5,2),
@preciov DECIMAL(5,2),
@categoria VARCHAR(50),
@estado VARCHAR(15)
AS
	DECLARE @IDcat INT
	SET @IDcat = (SELECT ID_Categoria FROM [dbo].[Categorias] WHERE Nombre_Categoria = @categoria)
	UPDATE [dbo].[Productos] SET Nombre_Producto = @nombre,Marca_Producto = @marca,Distribuidor = @distribuidor,Precio_Compra = @precioc,Precio_Venta = @preciov,ID_Categoria = @IDcat,Estado = @estado WHERE ID_Producto = @ID

GO
/****** Object:  StoredProcedure [dbo].[RecuperarContrasenia]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[RecuperarContrasenia]
@user VARCHAR(50),
@nuevacontrasenia VARCHAR(MAX),
@carnetempleado VARCHAR(15)
AS
	IF EXISTS(SELECT * FROM [dbo].[Usuarios] WHERE Usuario = @user)
		DECLARE @carnet VARCHAR(15), @id INT
		SET @id = (SELECT ID_Usuario FROM [dbo].[Usuarios] WHERE Usuario = @user)
		SET @carnet = (SELECT Carnet_Empleado FROM [dbo].[Empleados] WHERE ID_Usuario = @id)

		UPDATE [dbo].[Usuarios] SET Contrasenia = ENCRYPTBYPASSPHRASE('29S4ZMA0317',@nuevacontrasenia) WHERE Usuario = @user AND @carnet = @carnetempleado
		

GO
/****** Object:  StoredProcedure [dbo].[reporteVentas]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[reporteVentas]
@fechain DATE,
@fechafin DATE
AS
SELECT        dbo.Ventas.Codigo_Venta, dbo.Ventas.Fecha_Venta, dbo.Ventas.Total, dbo.Clientes.Nombre_Cliente, dbo.Ventas.Vendedor
FROM            dbo.Ventas INNER JOIN
                         dbo.Clientes ON dbo.Ventas.ID_Cliente = dbo.Clientes.ID_Cliente
WHERE Fecha_Venta BETWEEN @fechain AND @fechafin

GO
/****** Object:  StoredProcedure [dbo].[traerIDCliente]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[traerIDCliente]
@nombre VARCHAR(100),
@correop VARCHAR(50)
AS
	SELECT ID_Cliente FROM [dbo].[Clientes] WHERE Nombre_Cliente = @nombre AND Correo_Cliente = @correop

GO
/****** Object:  StoredProcedure [dbo].[ventaClientes]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ventaClientes]
@word VARCHAR(50)
AS
	SELECT Nombre_Cliente AS 'Nombre',Telefono_Cliente AS 'Telefono',Correo_Cliente AS 'Correo' FROM [dbo].[Clientes] WHERE Estatus = 'ACTIVO' AND Nombre_Cliente LIKE '%' + @word + '%';

GO
/****** Object:  StoredProcedure [dbo].[VerCategorias]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[VerCategorias]
AS
	SELECT ID_Categoria AS 'ID' , Nombre_Categoria 'Nombre', Estado AS 'Estado' FROM [dbo].[Categorias]	ORDER BY Nombre_Categoria

GO
/****** Object:  StoredProcedure [dbo].[VerClientes]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[VerClientes]
@word VARCHAR(100),
@filtro VARCHAR(10)
AS
	
		IF(@filtro='TODOS')
			BEGIN
				SELECT Nombre_Cliente AS 'Nombre',Telefono_Cliente AS 'Telefono',Correo_Cliente AS 'Correo',Estatus AS 'Estado' FROM [dbo].[Clientes] WHERE Nombre_Cliente LIKE '%' + @word + '%';
			END
		ELSE IF(@filtro ='ACTIVO')
			BEGIN
				SELECT Nombre_Cliente AS 'Nombre',Telefono_Cliente AS 'Telefono',Correo_Cliente AS 'Correo',Estatus AS 'Estado' FROM [dbo].[Clientes] WHERE Estatus = 'ACTIVO' AND Nombre_Cliente LIKE '%' + @word + '%';
			END
		ELSE IF(@filtro = 'INACTIVO')
			BEGIN
				SELECT Nombre_Cliente AS 'Nombre',Telefono_Cliente AS 'Telefono',Correo_Cliente AS 'Correo',Estatus AS 'Estado' FROM [dbo].[Clientes] WHERE Estatus = 'INACTIVO' AND Nombre_Cliente LIKE '%' + @word + '%';
			END
		

GO
/****** Object:  StoredProcedure [dbo].[VerClientesEditar]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[VerClientesEditar]
@word VARCHAR(100),
@filtro VARCHAR(10)
AS
	
		IF(@filtro='TODOS')
			BEGIN
				SELECT Nombre_Cliente AS 'Nombre',Telefono_Cliente AS 'Telefono',Correo_Cliente AS 'Correo',Estatus AS 'Estado' FROM [dbo].[Clientes] WHERE Nombre_Cliente LIKE '%' + @word + '%';
			END
		ELSE IF(@filtro ='ACTIVO')
			BEGIN
				SELECT Nombre_Cliente AS 'Nombre',Telefono_Cliente AS 'Telefono',Correo_Cliente AS 'Correo',Estatus AS 'Estado' FROM [dbo].[Clientes] WHERE Estatus = 'ACTIVO' AND Nombre_Cliente LIKE '%' + @word + '%';
			END
		ELSE IF(@filtro = 'INACTIVO')
			BEGIN
				SELECT Nombre_Cliente AS 'Nombre',Telefono_Cliente AS 'Telefono',Correo_Cliente AS 'Correo',Estatus AS 'Estado' FROM [dbo].[Clientes] WHERE Estatus = 'INACTIVO' AND Nombre_Cliente LIKE '%' + @word + '%';
			END
		

GO
/****** Object:  StoredProcedure [dbo].[verCotizaciones]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[verCotizaciones]
@word VARCHAR(25)
AS
	SELECT Codigo_Cotizacion AS 'Codigo', Fecha_Cotización AS 'Fecha',Sub_Total AS 'Sub Total',Total,c.Nombre_Cliente AS 'Cliente',Nombre_Empleado FROM [dbo].[Cotizaciones] v INNER JOIN [dbo].[Clientes] c ON v.ID_Cliente = c.ID_Cliente WHERE Codigo_Cotizacion LIKE '%' + @word + '%'

GO
/****** Object:  StoredProcedure [dbo].[VerEmpleados]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[VerEmpleados]
@word VARCHAR(100),
@filtro VARCHAR(10)
AS
	
		IF(@filtro='TODOS')
			BEGIN
				SELECT Nombre_Empleado AS 'Nombres', Apellidos_Empleado  AS 'Apellidos',Carnet_Empleado AS 'Carnet',Telefono_Empleado AS 'Telefono',Correo_Empleado AS 'Correo', Roll AS 'Cargo', Estatus FROM [dbo].[Empleados] WHERE Nombre_Empleado LIKE '%' + @word + '%';
			END
		ELSE IF(@filtro ='JEFE/GERENTE')
			BEGIN
				SELECT Nombre_Empleado AS 'Nombres', Apellidos_Empleado  AS 'Apellidos',Carnet_Empleado AS 'Carnet',Telefono_Empleado AS 'Telefono',Correo_Empleado AS 'Correo', Roll AS 'Cargo', Estatus  FROM [dbo].[Empleados] WHERE Roll = 'JEFE/GERENTE' AND Nombre_Empleado LIKE '%' + @word + '%';
			END
		ELSE IF(@filtro = 'EMPLEADO')
			BEGIN
				SELECT Nombre_Empleado AS 'Nombres', Apellidos_Empleado  AS 'Apellidos',Carnet_Empleado AS 'Carnet',Telefono_Empleado AS 'Telefono',Correo_Empleado AS 'Correo', Roll AS 'Cargo', Estatus  FROM [dbo].[Empleados] WHERE Roll = 'EMPLEADO' AND Nombre_Empleado LIKE '%' + @word + '%';
			END

GO
/****** Object:  StoredProcedure [dbo].[VerificarCategoria]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[VerificarCategoria]
@nombre VARCHAR(50)
AS
	SELECT ID_Categoria FROM [dbo].[Categorias] WHERE Nombre_Categoria = @nombre

GO
/****** Object:  StoredProcedure [dbo].[VerificarCliente]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[VerificarCliente]
@nombre VARCHAR(100),
@correo VARCHAR(50)
AS	
	SELECT Nombre_Cliente FROM [dbo].[Clientes] WHERE Nombre_Cliente = @nombre AND Correo_Cliente = @correo		

GO
/****** Object:  StoredProcedure [dbo].[VerificarEmpleado]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[VerificarEmpleado]
@nombre VARCHAR(100),
@correo VARCHAR(50),
@fecha DATE
AS	
	SELECT ID_Empleado FROM [dbo].[Empleados] WHERE Nombre_Empleado = @nombre AND Correo_Empleado = @correo AND Fecha_Nacimiento = @fecha

GO
/****** Object:  StoredProcedure [dbo].[VerificarProducto]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[VerificarProducto]
@nombre VARCHAR(50),
@marca VARCHAR(50)
AS
	SELECT ID_Producto FROM [dbo].[Productos] WHERE Nombre_Producto = @nombre AND Marca_Producto = @marca

GO
/****** Object:  StoredProcedure [dbo].[VerProductos]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[VerProductos]
AS
	SELECT Nombre_Producto AS 'Nombre',Marca_Producto AS 'Marca',Distribuidor AS 'Distr.',c.Nombre_Categoria AS 'Categ.',Precio_Compra AS 'PCompra',Precio_Venta AS 'PVenta',p.Estado AS 'Estado'
	FROM [dbo].[Productos] p INNER JOIN [dbo].[Categorias] c ON p.ID_Categoria = c.ID_Categoria

GO
/****** Object:  StoredProcedure [dbo].[VerProductosPromo]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[VerProductosPromo]
@word VARCHAR(50)
AS
	SELECT ID_Producto AS 'ID', Nombre_Producto AS 'Nombre',Marca_Producto AS 'Marca',Precio_Venta AS 'Precio Venta' FROM [dbo].[Productos] WHERE Nombre_Producto LIKE '%' + @word + '%'

GO
/****** Object:  StoredProcedure [dbo].[VerProductosVenta]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[VerProductosVenta]
@word VARCHAR(50)
AS
	SELECT Nombre_Producto AS 'Nombre',Marca_Producto AS 'Marca',Precio_Venta AS 'PVenta' FROM [dbo].[Productos] WHERE Estado = 'DISPONIBLE' AND Nombre_Producto LIKE '%' + @word + '%';

GO
/****** Object:  StoredProcedure [dbo].[verPromos]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[verPromos]
@word VARCHAR(100)
AS
	SELECT ID_Promoción AS 'ID',Nombre_Promocion AS 'Nombre',pd.Nombre_Producto AS 'Producto',Fecha_Fin AS 'Fin',Precio_Anterior AS 'Anterior',Porcentaje AS '%',Nuevo_Precio AS 'Precio Nuevo' FROM [dbo].[Promociones] p INNER JOIN [dbo].[Productos] pd ON p.ID_Producto = pd.ID_Producto WHERE p.Nombre_Promocion LIKE '%' + @word + '%'

GO
/****** Object:  StoredProcedure [dbo].[verVentas]    Script Date: 7/12/2021 01:24:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[verVentas]
@word VARCHAR(25)
AS
	SELECT Codigo_Venta AS 'Codigo', Fecha_Venta AS 'Fecha',Sub_Total AS 'Sub Total',Total,c.Nombre_Cliente AS 'Cliente',Vendedor FROM [dbo].[Ventas] v INNER JOIN [dbo].[Clientes] c ON v.ID_Cliente = c.ID_Cliente WHERE Codigo_Venta LIKE '%' + @word + '%'

GO
USE [master]
GO
ALTER DATABASE [Tec_Shop_UMLG3] SET  READ_WRITE 
GO
