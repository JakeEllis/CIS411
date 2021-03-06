/****************************

THIS IS THE DROP SCRIPT TO DROP ALL TABELS

****************************/
USE [team1-playLister]
DROP TABLE [Combo_Bridge_ID]
DROP TABLE [Song_Store]
DROP TABLE [Party]
DROP TABLE [Playlist]
DROP TABLE [Role Permission]
DROP TABLE [Person Role]
DROP TABLE [Profile]
DROP TABLE [Person]
DROP TABLE [Song]

/***************************

END DROP SCRIPT

****************************/


/***************************

CREATE SCRIPT

****************************/
USE [team1-playLister] --Point to the Correct Envrionment Before you run!!!!!!!
GO
/****** Object:  Table [dbo].[Bridge_Combo_ID]    Script Date: 4/23/2013 10:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bridge_Combo_ID](
	[Bridge_Combo_ID] [bigint] NOT NULL,
	[Song_ID] [bigint] NOT NULL,
	[Playlist_ID] [int] NOT NULL,
 CONSTRAINT [PK_Bridge_Combo_ID] PRIMARY KEY CLUSTERED 
(
	[Bridge_Combo_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Party]    Script Date: 4/23/2013 10:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Party](
	[Party_ID] [int] NOT NULL,
	[Playlist] [int] NOT NULL,
	[Party_Title] [varchar](max) NOT NULL,
	[Participant_Count] [int] NOT NULL,
	[Genre_Limitation] [varchar](50) NULL,
	[Repeat_Contraint] [int] NULL,
 CONSTRAINT [PK_Party] PRIMARY KEY CLUSTERED 
(
	[Party_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Person]    Script Date: 4/23/2013 10:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Person](
	[Person_ID] [int] NOT NULL,
	[Last_Name] [varchar](50) NOT NULL,
	[First_Name] [varchar](50) NOT NULL,
	[Role_ID] [int] NOT NULL,
	[User_Name] [varchar](50) NOT NULL,
	[Sex] [bit] NULL,
	[E_Mail] [varchar](50) NULL,
	[Phone] [bigint] NULL,
	[Facebook_Key] [varchar](50) NULL,
	[Twitter_Key] [varchar](50) NULL,
	[Spotify_Key] [varchar](50) NULL,
	[Profile_ID] [int] NOT NULL,
	[Party_Owner_ID] [int] NOT NULL,
	[Party_Participant] [int] NULL,
	[IsActive] [bit] NOT NULL,
	[User_Password] [varchar](50) NOT NULL,
	[Security_Question1] [varchar](max) NOT NULL,
	[Secuirty_Answer1] [varchar](50) NOT NULL,
	[Security_Question2] [varchar](max) NOT NULL,
	[Security_Answer2] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Person_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Person Role]    Script Date: 4/23/2013 10:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Person Role](
	[Person_Role_ID] [int] NOT NULL,
	[Role_Title] [varchar](max) NOT NULL,
	[Role_Permission_Combo_ID] [int] NOT NULL,
 CONSTRAINT [PK_Person Role] PRIMARY KEY CLUSTERED 
(
	[Person_Role_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Playlist]    Script Date: 4/23/2013 10:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Playlist](
	[Playlist_ID] [int] NOT NULL,
	[Playlist_Title] [varchar](max) NOT NULL,
	[Song_ID] [varchar](50) NULL,
	[Song_Title] [varchar](50) NOT NULL,
	[Song_Vote] [int] NULL,
	[Party_ID] [int] NOT NULL,
 CONSTRAINT [PK_Playlist] PRIMARY KEY CLUSTERED 
(
	[Playlist_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Profile]    Script Date: 4/23/2013 10:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Profile](
	[Person_ID] [int] NOT NULL,
	[Profile_ID] [int] NOT NULL,
	[Profile_Name] [varchar](50) NOT NULL,
	[Profile_Picture] [image] NULL,
	[Bio] [varchar](max) NULL,
 CONSTRAINT [PK_Profile] PRIMARY KEY CLUSTERED 
(
	[Person_ID] ASC,
	[Profile_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Role Permission]    Script Date: 4/23/2013 10:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role Permission](
	[Role_Permission_Combo_ID] [int] NOT NULL,
	[Permission1] [bit] NOT NULL,
	[Permission2] [bit] NOT NULL,
	[PermissionN] [int] NOT NULL,
 CONSTRAINT [PK_Role Permission] PRIMARY KEY CLUSTERED 
(
	[Role_Permission_Combo_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Song]    Script Date: 4/23/2013 10:52:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Song](
	[Song_ID] [bigint] NOT NULL,
	[HREF] [text] NOT NULL,
	[Song_Name] [text] NOT NULL,
	[Artist] [text] NOT NULL,
	[Popularity] [text] NOT NULL,
 CONSTRAINT [PK_Song] PRIMARY KEY CLUSTERED 
(
	[Song_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[Bridge_Combo_ID]  WITH CHECK ADD  CONSTRAINT [FK_Bridge_Combo_ID_Playlist] FOREIGN KEY([Playlist_ID])
REFERENCES [dbo].[Playlist] ([Playlist_ID])
GO
ALTER TABLE [dbo].[Bridge_Combo_ID] CHECK CONSTRAINT [FK_Bridge_Combo_ID_Playlist]
GO
ALTER TABLE [dbo].[Bridge_Combo_ID]  WITH CHECK ADD  CONSTRAINT [FK_Bridge_Combo_ID_Song] FOREIGN KEY([Song_ID])
REFERENCES [dbo].[Song] ([Song_ID])
GO
ALTER TABLE [dbo].[Bridge_Combo_ID] CHECK CONSTRAINT [FK_Bridge_Combo_ID_Song]
GO
ALTER TABLE [dbo].[Party]  WITH CHECK ADD  CONSTRAINT [FK_Party_Playlist] FOREIGN KEY([Playlist])
REFERENCES [dbo].[Playlist] ([Playlist_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Party] CHECK CONSTRAINT [FK_Party_Playlist]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Party] FOREIGN KEY([Party_Owner_ID])
REFERENCES [dbo].[Party] ([Party_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Party]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Person Role] FOREIGN KEY([Role_ID])
REFERENCES [dbo].[Person Role] ([Person_Role_ID])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Person Role]
GO
ALTER TABLE [dbo].[Person Role]  WITH CHECK ADD  CONSTRAINT [FK_Person Role_Role Permission] FOREIGN KEY([Role_Permission_Combo_ID])
REFERENCES [dbo].[Role Permission] ([Role_Permission_Combo_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Person Role] CHECK CONSTRAINT [FK_Person Role_Role Permission]
GO
ALTER TABLE [dbo].[Profile]  WITH CHECK ADD  CONSTRAINT [FK_Profile_Person] FOREIGN KEY([Person_ID])
REFERENCES [dbo].[Person] ([Person_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Profile] CHECK CONSTRAINT [FK_Profile_Person]
GO
USE [master]
GO
ALTER DATABASE [team1-qa-playLister] SET  READ_WRITE 
GO
