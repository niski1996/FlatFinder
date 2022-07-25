USE [ClientDatabase]
GO

INSERT INTO [dbo].[Session_in_Domain]
           ([sessionId]
           ,[domainName]
           ,[accepted]
           ,[rejected]
           ,[unknown]
           ,[repated])
     VALUES
           (1,'olx',1,2,12,1)
GO

INSERT INTO [dbo].[Session_in_Domain]([sessionId],[domainName] ,[accepted],[rejected],[unknown],[repated])
     VALUES (1,'facebook',10,2,12,1)
GO
INSERT INTO [dbo].[Session_in_Domain]([sessionId],[domainName] ,[accepted],[rejected],[unknown],[repated])
     VALUES (2,'facebook',10,2,12,1)
GO
INSERT INTO [dbo].[Session_in_Domain]([sessionId],[domainName] ,[accepted],[rejected],[unknown],[repated])
     VALUES (3,'facebook',10,2,12,1)
GO
INSERT INTO [dbo].[Session_in_Domain]([sessionId],[domainName] ,[accepted],[rejected],[unknown],[repated])
     VALUES (4,'facebook',10,2,12,1)
GO
INSERT INTO [dbo].[Session_in_Domain]([sessionId],[domainName] ,[accepted],[rejected],[unknown],[repated])
     VALUES (1,'olx',10,2,12,1)
GO
INSERT INTO [dbo].[Session_in_Domain]([sessionId],[domainName] ,[accepted],[rejected],[unknown],[repated])
     VALUES (2,'allegro',10,2,12,1)
GO
INSERT INTO [dbo].[Session_in_Domain]([sessionId],[domainName] ,[accepted],[rejected],[unknown],[repated])
     VALUES (3,'olx',10,2,12,1)
GO
INSERT INTO [dbo].[Session_in_Domain]([sessionId],[domainName] ,[accepted],[rejected],[unknown],[repated])
     VALUES (4,'allegro',100,20,102,10)
GO

