USE [master]
GO
/****** Object:  Database [DB_SkillsMedieval_WSN]    Script Date: 24/11/2024 10:56:39 ******/
CREATE DATABASE [DB_SkillsMedieval_WSN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_SkillsMedieval_WSN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DB_SkillsMedieval_WSN.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_SkillsMedieval_WSN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DB_SkillsMedieval_WSN_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_SkillsMedieval_WSN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET  MULTI_USER 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET QUERY_STORE = ON
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DB_SkillsMedieval_WSN]
GO
/****** Object:  Table [dbo].[clients]    Script Date: 24/11/2024 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clients](
	[client_id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](100) NOT NULL,
	[last_name] [varchar](100) NOT NULL,
	[taxpayer_number] [varchar](20) NOT NULL,
	[address] [varchar](255) NULL,
	[email] [varchar](100) NULL,
	[phone_number] [varchar](20) NULL,
	[state] [varchar](20) NULL,
	[registration_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[client_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[costumes]    Script Date: 24/11/2024 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[costumes](
	[costume_id] [int] IDENTITY(1,1) NOT NULL,
	[reference_code] [varchar](50) NOT NULL,
	[name] [varchar](255) NOT NULL,
	[available_for_rent] [bit] NULL,
	[rental_price] [decimal](10, 2) NOT NULL,
	[warehouse_id] [int] NULL,
	[image_path] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[costume_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[event_costumes]    Script Date: 24/11/2024 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[event_costumes](
	[event_costume_id] [int] IDENTITY(1,1) NOT NULL,
	[event_id] [int] NULL,
	[costume_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[event_costume_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[events]    Script Date: 24/11/2024 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[events](
	[event_id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](255) NOT NULL,
	[description] [text] NULL,
	[start_date] [datetime] NULL,
	[end_date] [datetime] NULL,
	[location] [varchar](255) NULL,
	[organizer_id] [int] NULL,
	[facebook_link] [varchar](255) NULL,
	[instagram_link] [varchar](255) NULL,
	[tiktok_link] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[event_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[organizers]    Script Date: 24/11/2024 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[organizers](
	[organizer_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NOT NULL,
	[locality] [varchar](100) NULL,
	[taxpayer_number] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[organizer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rental_items]    Script Date: 24/11/2024 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rental_items](
	[rental_item_id] [int] IDENTITY(1,1) NOT NULL,
	[rental_id] [int] NULL,
	[costume_id] [int] NULL,
	[quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[rental_item_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rental_returns]    Script Date: 24/11/2024 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rental_returns](
	[return_id] [int] IDENTITY(1,1) NOT NULL,
	[rental_id] [int] NULL,
	[return_date] [datetime] NULL,
	[status] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[return_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rentals]    Script Date: 24/11/2024 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rentals](
	[rental_id] [int] IDENTITY(1,1) NOT NULL,
	[client_id] [int] NULL,
	[user_id] [int] NULL,
	[rental_date] [datetime] NULL,
	[return_date] [datetime] NULL,
	[status] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[rental_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_access_log]    Script Date: 24/11/2024 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_access_log](
	[log_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NULL,
	[login_time] [datetime] NULL,
	[logout_time] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[log_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_attempts]    Script Date: 24/11/2024 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_attempts](
	[user_id] [int] NULL,
	[failed_attempts] [int] NULL,
	[account_locked] [bit] NULL,
	[pin] [varchar](4) NULL,
	[last_failed_attempt] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_audit_log]    Script Date: 24/11/2024 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_audit_log](
	[log_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NULL,
	[login_time] [datetime] NULL,
	[logout_time] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[log_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 24/11/2024 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](100) NULL,
	[last_name] [varchar](100) NULL,
	[address] [varchar](255) NULL,
	[phone_number] [varchar](20) NULL,
	[email] [varchar](100) NULL,
	[password] [varchar](255) NULL,
	[role] [varchar](20) NULL,
	[registration_date] [datetime] NULL,
	[is_locked] [bit] NULL,
	[failed_login_attempts] [int] NULL,
	[pin_code] [varchar](4) NULL,
	[password_changed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[warehouses]    Script Date: 24/11/2024 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[warehouses](
	[warehouse_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NOT NULL,
	[location] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[warehouse_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__clients__2FD379D531400F0B]    Script Date: 24/11/2024 10:56:39 ******/
ALTER TABLE [dbo].[clients] ADD UNIQUE NONCLUSTERED 
(
	[taxpayer_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__clients__AB6E6164013C5411]    Script Date: 24/11/2024 10:56:39 ******/
ALTER TABLE [dbo].[clients] ADD UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__costumes__372CD1173266622B]    Script Date: 24/11/2024 10:56:39 ******/
ALTER TABLE [dbo].[costumes] ADD UNIQUE NONCLUSTERED 
(
	[reference_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__users__AB6E6164636D5D55]    Script Date: 24/11/2024 10:56:39 ******/
ALTER TABLE [dbo].[users] ADD UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[clients] ADD  DEFAULT ('Inactive') FOR [state]
GO
ALTER TABLE [dbo].[clients] ADD  DEFAULT (getdate()) FOR [registration_date]
GO
ALTER TABLE [dbo].[costumes] ADD  DEFAULT ((1)) FOR [available_for_rent]
GO
ALTER TABLE [dbo].[rental_items] ADD  DEFAULT ((1)) FOR [quantity]
GO
ALTER TABLE [dbo].[rental_returns] ADD  DEFAULT (getdate()) FOR [return_date]
GO
ALTER TABLE [dbo].[rental_returns] ADD  DEFAULT ('Not Returned') FOR [status]
GO
ALTER TABLE [dbo].[rentals] ADD  DEFAULT (getdate()) FOR [rental_date]
GO
ALTER TABLE [dbo].[rentals] ADD  DEFAULT ('In Progress') FOR [status]
GO
ALTER TABLE [dbo].[user_access_log] ADD  DEFAULT (getdate()) FOR [login_time]
GO
ALTER TABLE [dbo].[user_attempts] ADD  DEFAULT ((0)) FOR [failed_attempts]
GO
ALTER TABLE [dbo].[user_attempts] ADD  DEFAULT ((0)) FOR [account_locked]
GO
ALTER TABLE [dbo].[user_audit_log] ADD  DEFAULT (getdate()) FOR [login_time]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT ('Other') FOR [role]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT (getdate()) FOR [registration_date]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT ((0)) FOR [is_locked]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT ((0)) FOR [failed_login_attempts]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT ((0)) FOR [password_changed]
GO
ALTER TABLE [dbo].[costumes]  WITH CHECK ADD FOREIGN KEY([warehouse_id])
REFERENCES [dbo].[warehouses] ([warehouse_id])
GO
ALTER TABLE [dbo].[event_costumes]  WITH CHECK ADD FOREIGN KEY([costume_id])
REFERENCES [dbo].[costumes] ([costume_id])
GO
ALTER TABLE [dbo].[event_costumes]  WITH CHECK ADD FOREIGN KEY([event_id])
REFERENCES [dbo].[events] ([event_id])
GO
ALTER TABLE [dbo].[events]  WITH CHECK ADD FOREIGN KEY([organizer_id])
REFERENCES [dbo].[organizers] ([organizer_id])
GO
ALTER TABLE [dbo].[rental_items]  WITH CHECK ADD FOREIGN KEY([costume_id])
REFERENCES [dbo].[costumes] ([costume_id])
GO
ALTER TABLE [dbo].[rental_items]  WITH CHECK ADD FOREIGN KEY([rental_id])
REFERENCES [dbo].[rentals] ([rental_id])
GO
ALTER TABLE [dbo].[rental_returns]  WITH CHECK ADD FOREIGN KEY([rental_id])
REFERENCES [dbo].[rentals] ([rental_id])
GO
ALTER TABLE [dbo].[rentals]  WITH CHECK ADD FOREIGN KEY([client_id])
REFERENCES [dbo].[clients] ([client_id])
GO
ALTER TABLE [dbo].[rentals]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([user_id])
GO
ALTER TABLE [dbo].[user_access_log]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([user_id])
GO
ALTER TABLE [dbo].[user_attempts]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([user_id])
GO
ALTER TABLE [dbo].[user_audit_log]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([user_id])
GO
ALTER TABLE [dbo].[clients]  WITH CHECK ADD CHECK  (([state]='Inactive' OR [state]='Active'))
GO
ALTER TABLE [dbo].[rental_returns]  WITH CHECK ADD CHECK  (([status]='Not Returned' OR [status]='Returned'))
GO
ALTER TABLE [dbo].[rentals]  WITH CHECK ADD CHECK  (([status]='Completed' OR [status]='In Progress'))
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD CHECK  (([role]='Other' OR [role]='Knight' OR [role]='Moderator' OR [role]='Admin'))
GO
/****** Object:  StoredProcedure [dbo].[MarkCostumeAsUnavailable]    Script Date: 24/11/2024 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creating the Stored Procedure
CREATE PROCEDURE [dbo].[MarkCostumeAsUnavailable]
    @costume_id INT -- ID of the costume to be marked as unavailable
AS
BEGIN
    -- Update the costume's availability to "unavailable" after creation
    UPDATE costumes
    SET available_for_rent = 0  -- Mark the costume as unavailable for rental
    WHERE costume_id = @costume_id;

    -- Message to confirm the update
    PRINT 'Costume marked as unavailable for rental.';
END;

GO
USE [master]
GO
ALTER DATABASE [DB_SkillsMedieval_WSN] SET  READ_WRITE 
GO
