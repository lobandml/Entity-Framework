CREATE TABLE [dbo].[City] ( 
    [CityId] INT IDENTITY (1, 1) NOT NULL, 
    [Name] NVARCHAR (200) NULL, 
    CONSTRAINT [PK_dbo.City] PRIMARY KEY CLUSTERED ([CityId] ASC) 
); 
 
CREATE TABLE [dbo].[User] ( 
    [UserId] INT IDENTITY (1, 1) NOT NULL, 
	[Title] NVARCHAR (200) NULL, 
    [CityId] INT NOT NULL, 
    CONSTRAINT [PK_dbo.User] PRIMARY KEY CLUSTERED ([UserId] ASC), 
    CONSTRAINT [FK_dbo.User_dbo.City_CityId] FOREIGN KEY ([CityId]) REFERENCES [dbo].[City] ([CityId]) ON DELETE CASCADE 
);