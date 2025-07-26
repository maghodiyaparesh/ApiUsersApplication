
CREATE TABLE [dbo].[Users](
	[Id] [uniqueidentifier] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[JoiningDate] [datetime] NOT NULL,
	[MemberType] [nvarchar](50) NOT NULL,
	[JobTitle] [nvarchar](50) NOT NULL,
	[IsMember] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
))
