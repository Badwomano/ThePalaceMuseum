```sql
USE [master]
GO
/****** Object:  Database [Museum]    Script Date: 2024/11/27 10:45:34 ******/
CREATE DATABASE [Museum]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Museum', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Museum.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Museum_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Museum_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Museum] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Museum].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Museum] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Museum] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Museum] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Museum] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Museum] SET ARITHABORT OFF 
GO
ALTER DATABASE [Museum] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Museum] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Museum] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Museum] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Museum] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Museum] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Museum] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Museum] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Museum] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Museum] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Museum] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Museum] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Museum] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Museum] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Museum] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Museum] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Museum] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Museum] SET RECOVERY FULL 
GO
ALTER DATABASE [Museum] SET  MULTI_USER 
GO
ALTER DATABASE [Museum] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Museum] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Museum] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Museum] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Museum] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Museum] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Museum', N'ON'
GO
ALTER DATABASE [Museum] SET QUERY_STORE = OFF
GO
USE [Museum]
GO
/****** Object:  Table [dbo].[CollectCategory]    Script Date: 2024/11/27 10:45:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CollectCategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CollectImg] [nvarchar](max) NOT NULL,
	[CollectCategory] [nvarchar](max) NOT NULL,
	[CollectNum] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Collect] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cultural]    Script Date: 2024/11/27 10:45:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cultural](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CulturalNumber] [nvarchar](max) NOT NULL,
	[CulturalName] [nvarchar](max) NOT NULL,
	[CulturalCategory] [nvarchar](max) NULL,
	[CulturalAntique] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Cultural] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manage]    Script Date: 2024/11/27 10:45:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manage](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ManageId] [nvarchar](50) NOT NULL,
	[ManagePassword] [nvarchar](50) NOT NULL,
	[ManageName] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Position] [nvarchar](50) NULL,
	[Department] [nvarchar](50) NULL,
	[Role] [nvarchar](50) NULL,
	[CharState] [nvarchar](50) NULL,
 CONSTRAINT [PK_Manage] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notice]    Script Date: 2024/11/27 10:45:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notice](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[OpenTitle] [nvarchar](max) NULL,
	[OpenContent] [nvarchar](max) NULL,
	[OpenReleaseTime] [nvarchar](max) NULL,
	[OpenPublishDepatment] [nvarchar](max) NULL,
	[ActivitiesContent] [nvarchar](max) NULL,
	[ActivitiesTime] [nvarchar](max) NULL,
	[AcademicContent] [nvarchar](max) NULL,
	[AcademicTime] [nvarchar](max) NULL,
	[ConsultTitle] [nvarchar](max) NULL,
	[ConsultContent] [nvarchar](max) NULL,
	[ConsultTime] [nvarchar](max) NULL,
 CONSTRAINT [PK_OpenNotice] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 2024/11/27 10:45:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Verification] [nvarchar](50) NULL,
	[HeadPortrait] [nvarchar](max) NULL,
	[RegDate] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[UserAddress] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Voice]    Script Date: 2024/11/27 10:45:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Voice](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[VoiceMessage] [nvarchar](max) NULL,
	[VoiceResponse] [nvarchar](max) NULL,
	[VoiceTime] [nvarchar](max) NULL,
	[ProblemInquire] [nvarchar](max) NULL,
	[ProblemAnswer] [nvarchar](max) NULL,
 CONSTRAINT [PK_Voice] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[CollectCategory] ADD  CONSTRAINT [DF_Collect_CollectImg]  DEFAULT ('') FOR [CollectImg]
GO
ALTER TABLE [dbo].[CollectCategory] ADD  CONSTRAINT [DF_Collect_CollectName]  DEFAULT ('') FOR [CollectCategory]
GO
ALTER TABLE [dbo].[CollectCategory] ADD  CONSTRAINT [DF_Collect_CollectNum]  DEFAULT ('') FOR [CollectNum]
GO
ALTER TABLE [dbo].[Cultural] ADD  CONSTRAINT [DF_Cultural_CulturalNumber]  DEFAULT ('') FOR [CulturalNumber]
GO
ALTER TABLE [dbo].[Cultural] ADD  CONSTRAINT [DF_Cultural_CulturalName]  DEFAULT ('') FOR [CulturalName]
GO
ALTER TABLE [dbo].[Cultural] ADD  CONSTRAINT [DF_Cultural_CulturalCategory]  DEFAULT ('') FOR [CulturalCategory]
GO
ALTER TABLE [dbo].[Cultural] ADD  CONSTRAINT [DF_Cultural_CulturalAntique]  DEFAULT ('') FOR [CulturalAntique]
GO
ALTER TABLE [dbo].[Manage] ADD  CONSTRAINT [DF_Manage_ManageId]  DEFAULT ('') FOR [ManageId]
GO
ALTER TABLE [dbo].[Manage] ADD  CONSTRAINT [DF_Manage_ManagePassword]  DEFAULT ('') FOR [ManagePassword]
GO
ALTER TABLE [dbo].[Manage] ADD  CONSTRAINT [DF_Manage_ManageName]  DEFAULT ('') FOR [ManageName]
GO
ALTER TABLE [dbo].[Manage] ADD  CONSTRAINT [DF_Manage_Phone]  DEFAULT ('') FOR [Phone]
GO
ALTER TABLE [dbo].[Manage] ADD  CONSTRAINT [DF_Manage_Email]  DEFAULT ('') FOR [Email]
GO
ALTER TABLE [dbo].[Manage] ADD  CONSTRAINT [DF_Manage_Address]  DEFAULT (N'四川省成都市') FOR [Address]
GO
ALTER TABLE [dbo].[Manage] ADD  CONSTRAINT [DF_Manage_Position]  DEFAULT (N'员工') FOR [Position]
GO
ALTER TABLE [dbo].[Manage] ADD  CONSTRAINT [DF_Manage_Department]  DEFAULT ('') FOR [Department]
GO
ALTER TABLE [dbo].[Manage] ADD  CONSTRAINT [DF_Manage_Role]  DEFAULT ('') FOR [Role]
GO
ALTER TABLE [dbo].[Manage] ADD  CONSTRAINT [DF_Manage_CharState]  DEFAULT (N'启用') FOR [CharState]
GO
ALTER TABLE [dbo].[Notice] ADD  CONSTRAINT [DF_Notice_OpenTitle]  DEFAULT ('') FOR [OpenTitle]
GO
ALTER TABLE [dbo].[Notice] ADD  CONSTRAINT [DF_OpenNotice_OpenContent]  DEFAULT ('') FOR [OpenContent]
GO
ALTER TABLE [dbo].[Notice] ADD  CONSTRAINT [DF_OpenNotice_OpenReleaseTime]  DEFAULT ('') FOR [OpenReleaseTime]
GO
ALTER TABLE [dbo].[Notice] ADD  CONSTRAINT [DF_Table_1_PublishDepatment]  DEFAULT ('') FOR [OpenPublishDepatment]
GO
ALTER TABLE [dbo].[Notice] ADD  CONSTRAINT [DF_Notice_ActivitiesContent]  DEFAULT ('') FOR [ActivitiesContent]
GO
ALTER TABLE [dbo].[Notice] ADD  CONSTRAINT [DF_Notice_ActivitiesTime]  DEFAULT ('') FOR [ActivitiesTime]
GO
ALTER TABLE [dbo].[Notice] ADD  CONSTRAINT [DF_Notice_AcademicContent]  DEFAULT ('') FOR [AcademicContent]
GO
ALTER TABLE [dbo].[Notice] ADD  CONSTRAINT [DF_Notice_ConsultTitle]  DEFAULT ('') FOR [ConsultTitle]
GO
ALTER TABLE [dbo].[Notice] ADD  CONSTRAINT [DF_Notice_ConsultTime]  DEFAULT ('') FOR [ConsultTime]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_UserId]  DEFAULT ('') FOR [UserId]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_Password]  DEFAULT ('') FOR [Password]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_Verification]  DEFAULT ('') FOR [Verification]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_HeadPortrait]  DEFAULT ('') FOR [HeadPortrait]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_RegDate]  DEFAULT ('2022-6-8') FOR [RegDate]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_UserName]  DEFAULT ('') FOR [UserName]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_UserAddress]  DEFAULT ('') FOR [UserAddress]
GO
ALTER TABLE [dbo].[Voice] ADD  CONSTRAINT [DF_Voice_VoiceMessage]  DEFAULT ('') FOR [VoiceMessage]
GO
ALTER TABLE [dbo].[Voice] ADD  CONSTRAINT [DF_Voice_VoiceResponse]  DEFAULT ('') FOR [VoiceResponse]
GO
ALTER TABLE [dbo].[Voice] ADD  CONSTRAINT [DF_Voice_VoiceTime]  DEFAULT ('') FOR [VoiceTime]
GO
ALTER TABLE [dbo].[Voice] ADD  CONSTRAINT [DF_Voice_ProblemInquire]  DEFAULT ('') FOR [ProblemInquire]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'藏品图片' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CollectCategory', @level2type=N'COLUMN',@level2name=N'CollectImg'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'藏品类别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CollectCategory', @level2type=N'COLUMN',@level2name=N'CollectCategory'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'藏品数目' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CollectCategory', @level2type=N'COLUMN',@level2name=N'CollectNum'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'文物号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Cultural', @level2type=N'COLUMN',@level2name=N'CulturalNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'文物名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Cultural', @level2type=N'COLUMN',@level2name=N'CulturalName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'文物类别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Cultural', @level2type=N'COLUMN',@level2name=N'CulturalCategory'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'藏品年代' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Cultural', @level2type=N'COLUMN',@level2name=N'CulturalAntique'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'管理员账号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manage', @level2type=N'COLUMN',@level2name=N'ManageId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'管理员密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manage', @level2type=N'COLUMN',@level2name=N'ManagePassword'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manage', @level2type=N'COLUMN',@level2name=N'ManageName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manage', @level2type=N'COLUMN',@level2name=N'Phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'邮件' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manage', @level2type=N'COLUMN',@level2name=N'Email'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manage', @level2type=N'COLUMN',@level2name=N'Address'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'职位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manage', @level2type=N'COLUMN',@level2name=N'Position'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'部门' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manage', @level2type=N'COLUMN',@level2name=N'Department'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manage', @level2type=N'COLUMN',@level2name=N'Role'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manage', @level2type=N'COLUMN',@level2name=N'CharState'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'开放公告标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Notice', @level2type=N'COLUMN',@level2name=N'OpenTitle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'公告内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Notice', @level2type=N'COLUMN',@level2name=N'OpenContent'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发布时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Notice', @level2type=N'COLUMN',@level2name=N'OpenReleaseTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发布部门' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Notice', @level2type=N'COLUMN',@level2name=N'OpenPublishDepatment'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'博物馆活动内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Notice', @level2type=N'COLUMN',@level2name=N'ActivitiesContent'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'博物馆活动时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Notice', @level2type=N'COLUMN',@level2name=N'ActivitiesTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学术研究内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Notice', @level2type=N'COLUMN',@level2name=N'AcademicContent'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学术研究时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Notice', @level2type=N'COLUMN',@level2name=N'AcademicTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'故宫咨询标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Notice', @level2type=N'COLUMN',@level2name=N'ConsultTitle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'故宫咨询内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Notice', @level2type=N'COLUMN',@level2name=N'ConsultContent'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'故宫咨询时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Notice', @level2type=N'COLUMN',@level2name=N'ConsultTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'账号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User', @level2type=N'COLUMN',@level2name=N'UserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User', @level2type=N'COLUMN',@level2name=N'Password'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'验证码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User', @level2type=N'COLUMN',@level2name=N'Verification'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'头像' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User', @level2type=N'COLUMN',@level2name=N'HeadPortrait'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'注册时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User', @level2type=N'COLUMN',@level2name=N'RegDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User', @level2type=N'COLUMN',@level2name=N'UserName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User', @level2type=N'COLUMN',@level2name=N'UserAddress'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'留言信息' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Voice', @level2type=N'COLUMN',@level2name=N'VoiceMessage'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'留言回复' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Voice', @level2type=N'COLUMN',@level2name=N'VoiceResponse'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'留言时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Voice', @level2type=N'COLUMN',@level2name=N'VoiceTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'网友疑问' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Voice', @level2type=N'COLUMN',@level2name=N'ProblemInquire'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'网友答复' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Voice', @level2type=N'COLUMN',@level2name=N'ProblemAnswer'
GO
USE [master]
GO
ALTER DATABASE [Museum] SET  READ_WRITE 
GO
```

